﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Drawing2D;
using Data.Enums;
using Data.Data;
using ChatApp.Forms;
using SenderFrm;
using DevExpress.XtraGrid.Views.Tile;
using System.Media;
using DevExpress.XtraBars.Alerter;

namespace TakeAway
{
  
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
      
        List<Order> UpData = new List<Order>();
        List<Guid> alerted = new List<Guid>(), t1 = new List<Guid>() , t2 = new List<Guid>(), t3 = new List<Guid>();
        
        public SenderUser SenderUser { get; set; }
        List<TimerOrder> TimerOrder = new List<TimerOrder>();
        List<Order> TimerWating = new List<Order>();
        DataContext _context = new DataContext();
        SoundPlayer UpdateSound = new SoundPlayer("UpdateOrder.wav");
        SoundPlayer FinishSound = new SoundPlayer("alert.wav");
        int count1;
        int count2;

        Timer WaitBike;
        Timer Wait;

        protected internal XtraForm1(SenderUser user)
        {
            InitializeComponent();

            SenderUser = user;
            try
            {

                var order = _context.Orders?.Include("Customer")?.Include("Employee")?.Include("Vehicle").Where(S => S.Status == (int)Status.Created || S.Status == (int)Status.Seen || S.Status == (int)Status.Waiting).ToList();
                foreach (var item in order)
                {
                    if (item.Time > DateTime.Now.TimeOfDay && item.WithTimer)
                    {
                        item.Status = (int)Status.Waiting;
                    }
                    else
                    {
                        item.Status = (int)Status.Seen;
                    }

                    if (!TimerWating.Any(s => s.ID == item.ID))
                    {
                        TimerWating.Add(item);
                    }
                }
                _context.Dispose();
                gridControl1.DataSource = order;
                count1 = order.Count;

                LoadSendGrid();


                tileView1.ItemCustomize += (sender, e) =>
                {
                    ColorTile(e.Item);

                };


                tileView1.ItemClick += (sender, e) =>
                {
                    _context = new DataContext();
                    var row = tileView1.GetFocusedRow() as Order;
                    EditFrm fofi = new EditFrm(row.ID, SenderUser.ID, _context);
                    fofi.ShowDialog();
                };
                tileView2.ItemClick += (sender, e) =>
                {
                    var row = tileView2.GetFocusedRow() as SendOrder;
                    if (DialogResult.Yes == MessageBox.Show("لتعديل الطلب اضغط على تعديل \n إذا تم وصول الطلب بنجاح اضغط على : تم التوصيل", "", MessageBoxButtons.YesNo))
                    {
                        _context = new DataContext();

                        var Ord = _context?.Orders
                     ?.Include("Customer")
                     ?.Include("Employee")
                     ?.Include("Vehicle")
                     ?.Include("SenderUser")
                     ?.Include("SenderUser.Employee")
                     ?.Include("CallUser")
                     ?.Include("CallUser.Employee")
                     ?.SingleOrDefault(s => s.ID == row.ID);

                        var finishOrder = new FinishedOrder
                        {
                            Location = Ord?.Location,
                            SenderUserID = Ord?.SenderUserID,
                            StartTime = Ord?.StartTime,
                            CallUserID = Ord?.CallUserID,
                            CustomerID = Ord.CustomerID,
                            Date = Ord.Date,
                            Details = Ord?.Details,
                            Earn = Ord?.Earn,
                            EmployeeID = Ord?.EmployeeID,
                            EndTime = DateTime.Now,
                            VehicleID = Ord?.VehicleID,
                            SenderUserName = Ord?.SenderUser?.Employee?.Name,
                            CallUserName = Ord?.CallUser?.Employee?.Name,
                            CustomerName = Ord?.Customer?.Name,
                            EmployeeNaame = Ord?.Employee?.Name,
                            VehicleNumber = Ord?.Vehicle?.Number
                        };
                        _context.FinishedOrders.Add(finishOrder);
                        if (TimerWating.Contains(Ord)) TimerWating.Remove(Ord);
                        var Tord = TimerOrder?.FirstOrDefault(s => s.order.ID == Ord.ID);
                        if (Tord != null) TimerOrder.Remove(Tord);
                        //     _context.SaveChanges();
                        _context.Orders.Remove(Ord);
                        _context.SaveChanges();
                        _context.Dispose();
                        MessageBox.Show("تمت العملية بنجاح");
                        LoadSendGrid();

                    }
                    else
                    {
                        _context.Dispose();
                        _context = new DataContext();
                        EditFrm fofo = new EditFrm(row.ID, SenderUser.ID, _context);
                        fofo.ShowDialog();
                    }
                };

                EditFrm.UpdateGridAfterRemove += (DeletedOrder) =>
                {
                    _context = new DataContext();
                    var Torder = TimerWating?.SingleOrDefault(s => s.ID == DeletedOrder.ID);
                    if (Torder != null) TimerWating.Remove(Torder);
                    var ord = _context?.Orders?.Where(S => S.Status == (int)Status.Created || S.Status == (int)Status.Seen || S.Status == (int)Status.Waiting).ToList();
                    gridControl1.DataSource = ord;
                    count1 = ord.Count;
                };
                #region this event work after set employee $  Vehicle
                EditFrm.UpdateGrid += (o) =>
                {



                    LoadSendGrid();
                    //using (DataContext newContext = new DataContext())
                    //{
                    //    var oldToSave = newContext.Orders.FirstOrDefault(s => s.ID == o.ID);
                    //    oldToSave = o;
                    //    oldToSave.VehicleID = o.VehicleID;
                    //    oldToSave.EmployeeID = o.EmployeeID;
                    //    oldToSave.BikeTime = o.BikeTime;
                    //    oldToSave.Status = (int)Status.InProgress;
                    //    oldToSave.StartTime = DateTime.Now;
                    //    oldToSave.Earn = o.Earn;
                    //    oldToSave.SenderUserID = o.SenderUserID;
                    //    newContext.SaveChanges();
                    //}

                    TimerOrder.Add(new TimerOrder { order = o, Time = o.BikeTime, IsNew = true, ID = o.ID });
                    var ord = _context?.Orders?.Where(S => S.Status == (int)Status.Created || S.Status == (int)Status.Seen || S.Status == (int)Status.Waiting).ToList();
                    gridControl1.DataSource = ord;
                    count1 = ord.Count();

                };
                #endregion

                #region Finish click Event
                FinishBtn.Click += (sender, e) =>
                {
                    var row = tileView2.GetFocusedRow() as SendOrder;
                    _context.Dispose();
                    _context = new DataContext();
                    var Ord = _context?.Orders
                    ?.Include("Customer")
                    ?.Include("Employee")
                    ?.Include("Vehicle")
                    ?.Include("SenderUser")
                    ?.Include("SenderUser.Employee")
                    ?.Include("CallUser")
                    ?.Include("CallUser.Employee")
                    ?.SingleOrDefault(s => s.ID == row.ID);

                    var finishOrder = new FinishedOrder
                    {
                        Location = Ord?.Location,
                        SenderUserID = Ord?.SenderUserID,
                        StartTime = Ord?.StartTime,
                        CallUserID = Ord?.CallUserID,
                        CustomerID = Ord.CustomerID,
                        Date = Ord.Date,
                        Details = Ord?.Details,
                        Earn = Ord?.Earn,
                        EmployeeID = Ord?.EmployeeID,
                        EndTime = DateTime.Now,
                        VehicleID = Ord?.VehicleID,
                        SenderUserName = Ord?.SenderUser?.Employee?.Name,
                        CallUserName = Ord?.CallUser?.Employee?.Name,
                        CustomerName = Ord?.Customer?.Name,
                        EmployeeNaame = Ord?.Employee?.Name,
                    };
                    _context.FinishedOrders.Add(finishOrder);
                    //     _context.SaveChanges();
                    _context.Orders.Remove(Ord);
                    _context.SaveChanges();
                    MessageBox.Show("تمت العملية بنجاح");
                    LoadSendGrid();
                };
                #endregion

                #region send click Event
                SendButtonEdit.Click += (Sender, e) => {

                    try
                    {
                        //   var v= VehicleLookUpEdit.value as Vehicle;
                        //foreach (Form f in Application.OpenForms)
                        //{
                        //    if (f.Name == "EditFrm")
                        //    {
                        //        f.Dispose();
                        //        f.Close();
                        //        break;
                        //    }
                        //}

                        var row = tileView1.GetFocusedRow() as Order;
                        _context.Dispose();
                        _context = new DataContext();
                        EditFrm fofo = new EditFrm(row.ID, SenderUser.ID, _context);
                        fofo.ShowDialog();

                    }
                    catch (Exception ee)
                    {

                    }


                };
                #endregion




                #region intilize Wating Timer
                WaitBike = new Timer();
                WaitBike.Interval = 5000;
                WaitBike.Tick += (Sender, e) =>
                {
                    if (TimerOrder?.Count > 0)
                    {
                        foreach (var item in TimerOrder)
                        {
                            var total = DateTime.Now.TimeOfDay;
                          //  item.Counter++;
                         
                            if (item.Time <= total && item.order.Status == (int)Status.InProgress && !(alerted.Contains(item.ID)))
                            {
                                //if (item.Counter % 2 == 0)
                                //{
                                    FinishSound.Play();
                                    alerted.Add(item.ID);
                                    alertControl1.Show(this, ": تنبيه ", item.order.Details + ": إن الطلبية \n" + "\n يجب أن تكون قد وصلت");

                                //}

                            }

                        }
                    }

                };
                WaitBike.Start();



                Wait = new Timer();
                Wait.Interval = 5000;

                Wait.Tick += (Sender, E) =>
                {
                    foreach (var item in TimerWating)
                    {
                        //var t = new TimeSpan(0, 45,0);
                        var total = DateTime.Now.TimeOfDay;
                        TimeSpan dev = total - item.Time;
                        if (item.Time <= total && item.WithTimer && item.Status == (int)Status.Waiting)
                        {
                            bool isAlert = false;
                            if(dev < new TimeSpan(0, 15, 0) && !(t1.Contains(item.ID)))
                            {
                                t1.Add(item.ID);
                                isAlert = true;
                            }
                            else if(dev < new TimeSpan(0, 30, 0) && !(t2.Contains(item.ID)))
                            {
                                t2.Add(item.ID);
                                isAlert = true;
                            }
                            else if (dev < new TimeSpan(0, 45, 0) && !(t3.Contains(item.ID)))
                            {
                                t3.Add(item.ID);
                                isAlert = true;
                            }

                            if (isAlert)
                            {
                                _context.Dispose();
                                _context = new DataContext();
                                var orderRadey = _context?.Orders?.SingleOrDefault(s => s.ID == item.ID);
                                orderRadey.Status = (int)Status.Seen;
                                _context.SaveChanges();
                                alertControl1.Show(this, "يجب إرسال الطلب ", item.Details);
                                tileView1.RefreshData();
                            }
                            
                        }
                    }
                };
                Wait.Start();
                #endregion

                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                _context = new DataContext();


            }
         
        }


        /// <summary>
        /// Load Grid 2 (Send Grid) Data
        /// </summary>
        void LoadSendGrid()
        {
            _context.Dispose();
            _context = new DataContext();
            var SendOrder = _context.Orders?.Include("Customer")?.Include("Employee")?.Include("Vehicle").Where(S => S.Status == (int)Status.InProgress).Select(
                s => new SendOrder { ID = s.ID, Details = s.Details, CustomerName = s.Customer.Name, EmployeeName = s.Employee.Name, CustomerPhone=s.CustomerPhone, Earn = s.Earn, Location = s.Location, StartTime = s.StartTime, Status = s.Status, Timer = s.Timer }
                ).ToList();


            gridControl2.DataSource = SendOrder;
            count2 = SendOrder.Count();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(1000);
                    DataContext DB = new DataContext();
                    var ISNewdata = DB?.Orders?.Include("Customer")?.Include("Employee")?.Include("Vehicle")?.Where(S => S.Status == (int)Status.Created || S.Updated == 1).Any();
                    var ss = DB?.Orders?.ToList()?.Count();
                 
                    if ((bool)ISNewdata||ss!=count1+count2)
                    {
                         UpData = DB?.Orders?.Include("Customer")?.Where(S => S.Status == (int)Status.Created||S.Status==(int)Status.Seen || S.Status == (int)Status.Waiting ).ToList();
                        foreach (var item in UpData)
                        {
                            if (item.Time > DateTime.Now.TimeOfDay && item.WithTimer)
                            {
                                item.Status = (int)Status.Waiting;
                            }
                            else
                            {
                                item.Status = (int)Status.Seen;
                            }
                           if(! TimerWating.Any(s => s.ID == item.ID))
                            {
                                TimerWating.Add(item);
                            }
                            if (item.Updated == 1)
                            {
                                BeginInvoke(new MethodInvoker(delegate () {
                                    UpdateSound.Play();
                                    AlertInfo info = new AlertInfo(item.Details + ": تم تعديل الطلب \n", item.CustomerName + ": اسم الزبون  \n");
                                    alertControl1.Show(this, info);
                                }));
                                item.Updated = 2;
                                //tileView1_ItemCustomize(tileView1, new TileViewItemCustomizeEventArgs(new TileViewItem()));
                             //   ShowAlert(item.Details + ": تم تعديل الطلب", item.Customer.Name = ": اسم الزبون ");
                                System.Threading.Thread.Sleep(5000);
                            }
                        }
                        try
                        {
                            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { gridControl1.DataSource = UpData; });

                        }
                        catch { }
                        DB.SaveChangesAsync();
                    }

                     
                    //backgroundWorker1.RunWorkerAsync();
                }
            }


        }
    

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //TestDataContext DB = new TestDataContext();
            //var data = DB?.Tests?.Where(S => S.Status > 0);
            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { gridControl1.DataSource = UpData; });
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SenderUser = null;
            frmLogIn fofo = new frmLogIn();
            fofo.ShowDialog();
            this.Close();
            
           
          
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        void ColorTile(TileViewItem e)
        {
            if (e != null)
            {
                TimeSpan time = (TimeSpan)tileView1.GetRowCellValue(e.RowHandle, "Time") + new TimeSpan(0, 45, 0);
                if ((int)tileView1.GetRowCellValue(e.RowHandle, "Status") == (int)Status.Waiting)
                {
                    e.Elements[3].Appearance.Normal.BackColor = Color.Red;
                    e.Elements[8].Text = time.ToString();
                }
                else if ((int)tileView1.GetRowCellValue(e.RowHandle, "Status") == (int)Status.Seen)
                {
                    e.Elements[3].Appearance.Normal.BackColor = Color.Blue;
                    e.Elements[8].Text = "الطلب الآن";
                }
                int Updated = (int)tileView1.GetRowCellValue(e.RowHandle, "Updated");
                if (Updated == 1 || Updated == 2)
                {
                    e.Elements[3].Appearance.Normal.BackColor = Color.Black;
                    if(time <= DateTime.Now.TimeOfDay)
                    {
                        e.Elements[8].Text = time.ToString();
                    }
                    else
                    {
                        e.Elements[8].Text = "الطلب الآن";
                    }
                }


            }
     
          
        }

        private void tileView1_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {
            ColorTile(e.Item);
        }
    }
    public class TimerOrder
    {
        public Guid ID { get; set; }
        public Order order { get; set; }
        public TimeSpan? Time { get; set; }
        public bool IsNew { get; set; }
        public int Counter { get; set; } = 0;
    }
    public class SendOrder
    {
        public Guid ID { get; set; }
        public string CustomerPhone { get; set; }
        public string Details { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public decimal? Earn { get; set; }
        public string Location { get; set; }
        public DateTime? StartTime { get; set; }
        public int Status { get; set; }
        public int? Timer { get; set; }
    }
    public class Message
    {
        public Message()
        {
        
        }
        public string Caption { get; set; }
        public string Text { get; set; }
        public Image Image { get; set; }
    }
}