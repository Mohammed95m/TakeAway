using System;
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

namespace TakeAway
{
  
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
      
        List<Order> UpData = new List<Order>();
        public SenderUser SenderUser { get; set; }
        List<TimerOrder> TimerOrder = new List<TimerOrder>();
        List<Order> TimerWating = new List<Order>();


        public XtraForm1(SenderUser user)
        {
            InitializeComponent();
         
            //   lau.DataController.AllowIEnumerableDetails = true;
            SenderUser = user;
               DataContext _context = new DataContext();
            
            var order = _context.Orders?.Include("Customer")?.Include("Employee")?.Include("Vehicle").Where(S=>S.Status==(int)Status.Created|| S.Status == (int)Status.Seen || S.Status == (int)Status.Waiting).ToList();
            foreach (var item in order)
            {
                 if (item.Time > DateTime.Now.TimeOfDay)
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
           gridControl1.DataSource = order;
            var SendOrder = _context.Orders?.Include("Customer")?.Include("Employee")?.Include("Vehicle").Where(S => S.Status == (int)Status.InProgress).Select(
                s => new SendOrder { ID = s.ID, Details = s.Details, CustomerName = s.Customer.Name, EmployeeName = s.Employee.Name, Earn = s.Earn,Location= s.Location,StartTime=s.StartTime,Status= s.Status,Timer= s.Timer}
                
                ).ToList();
            gridControl2.DataSource = SendOrder;
            //DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number");
            //VehicleLookUpEdit.Columns.Add(col);
            #region coments code
            //var Vehicle = 
            //    (from c in _context.Vehicles
            //     select new Combo() { Text =c , Value = (int)c.Number }).ToList();

            //repositoryItemComboBox1.DisplayMember = "Text";
            //repositoryItemComboBox1.ValueMember = "Value";
            //foreach (var item in Sectors)
            //{
            //    comboBox1.Items.Add(item);
            //}

            //VehicleLookUpEdit.EditValueChanged += (e, a) =>
            //{

            //    MessageBox.Show(((Guid)cardView1.ActiveEditor.EditValue).ToString());
            //};
            //gridControl1.DataSource = order;
            //gridControl2.DataSource = SendOrder;

            //cardView1.CustomDrawFilterPanel += (a, b) => {
            //    Color color1 = Color.FromArgb(40, 170, 225);
            //    Color color2 = Color.FromArgb(35, 80, 160);
            //    Brush brush = b.Cache.GetGradientBrush(b.Bounds, color1, color2, LinearGradientMode.Horizontal);
            //    b.Appearance.Options.UseBackColor = true;
            //    b.Appearance.Options.UseBorderColor = true;
            //    b.Appearance.BackColor = Color.Red;
            //    b.Appearance.BackColor2 = Color.Red;
            //    b.Appearance.BorderColor = Color.Red;
            //    b.Appearance.ForeColor = Color.Red;
            //    b.Cache.FillRectangle(brush, b.Bounds);
            //    b.Appearance.DrawString(b.Cache, "", b.Bounds);


            //};
            //cardView1.CustomDrawCardCaption += (x, y) =>
            //{
            //    y.Appearance.Options.UseBackColor = true;
            //    y.Appearance.Options.UseBorderColor = true;
            //    y.Appearance.BackColor = Color.Red;
            //    y.Appearance.BackColor2 = Color.Red;
            //    y.Appearance.BorderColor = Color.Red;
            //};
            //cardView1.CustomCardStyle += (sender, e) =>
            //{
            //    var row = layoutView1.GetFocusedRow() as Order;
            //    Bitmap Bmp = new Bitmap(50, 50);
            //    using (Graphics gfx = Graphics.FromImage(Bmp))
            //    using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 0, 0)))
            //    {
            //        gfx.FillRectangle(brush, 0, 0, 50, 50);
            //    }
            //    e.Appearance.Image = Bmp;
            //};
            // };
            //        layoutView1.ItemCustomize += (sender, e) =>
            //                {
            //                    var row = tileView1.GetFocusedRow() as Order;
            //        Bitmap Bmp = new Bitmap(50, 50);
            //                    using (Graphics gfx = Graphics.FromImage(Bmp))
            //                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 0, 0)))
            //                    {
            //                        gfx.FillRectangle(brush, 0, 0, 50, 50);
            //                    }
            //e.Item.BackgroundImage = Bmp;


            //                };
            #endregion
            #region this event work after set employee $  Vehicle
            EditFrm.UpdateGrid += (o) =>
            {
                SendOrder = _context.Orders?.Include("Customer")?.Include("Employee")?.Include("Vehicle").Where(S => S.Status == (int)Status.InProgress).Select(
                s => new SendOrder { ID = s.ID, Details = s.Details, CustomerName = s.Customer.Name, EmployeeName = s.Employee.Name, Earn = s.Earn,Location = s.Location,StartTime = s.StartTime,Status = s.Status,Timer = s.Timer}
                ).ToList();
                gridControl2.DataSource = SendOrder;
                TimerOrder.Add(new TakeAway.TimerOrder { order = o, Time = o.Timer*60,IsNew=true });
              var  ord = _context?.Orders?.Where(S => S.Status == (int)Status.Created || S.Status == (int)Status.Seen || S.Status == (int)Status.Waiting).ToList();
                gridControl1.DataSource = ord;

            };
            #endregion
            #region Finish click Event
            FinishBtn.Click += (sender, e) =>
            {
                var row = cardView2.GetFocusedRow() as SendOrder;


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
              var  SendOrder2 = _context.Orders?.Include("Customer")?.Include("Employee")?.Include("Vehicle").Where(S => S.Status == (int)Status.InProgress).Select(
               s => new SendOrder { ID = s.ID, Details = s.Details, CustomerName = s.Customer.Name, EmployeeName = s.Employee.Name, Earn = s.Earn, Location = s.Location, StartTime = s.StartTime, Status = s.Status, Timer = s.Timer }
               ).ToList();
                gridControl2.DataSource = SendOrder2;
            };
            #endregion
            #region send click Event
            SendButtonEdit.Click += (Sender, e) => {

                try
                {
                //   var v= VehicleLookUpEdit.value as Vehicle;
                    var row = cardView1.GetFocusedRow() as Order;
                    EditFrm fofo = new EditFrm(row.ID, SenderUser.ID);
                    fofo.ShowDialog();

                }
                catch (Exception ee)
                {


                }


            };
            #endregion

            #region set Status Color
            cardView1.CustomDrawCardField += (sender, e) => {
                if (e.Column.FieldName != "Status") return;
                // The brush to fill the cell background.
                if (e.Column.FieldName == "Status" && int.Parse(e.CellValue.ToString()) == (int)Status.Waiting)
                {
                    Color color1 = Color.FromArgb(232, 42, 25);
                    Color color2 = Color.FromArgb(204, 71, 59);
                    Brush brush = e.Cache.GetGradientBrush(e.Bounds, color1, color2, LinearGradientMode.Horizontal);
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Bold);
                    e.Cache.FillRectangle(brush, e.Bounds);
                    e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds);
                    // Prevent default painting.
                    e.Handled = true;
                }
                else
                {
                    Color color1 = Color.FromArgb(33, 188, 41);
                    Color color2 = Color.FromArgb(21, 119, 26);
                    Brush brush = e.Cache.GetGradientBrush(e.Bounds, color1, color2, LinearGradientMode.Horizontal);
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Bold);
                    e.Cache.FillRectangle(brush, e.Bounds);
                    e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds);
                    // Prevent default painting.
                    e.Handled = true;
                }
            };
            #endregion
            #region intilize alert timer
            Timer toto = new Timer();
            toto.Interval = 1000;
            toto.Tick += (sender, e) =>
            {
                if(TimerOrder.Count>0)
                foreach (var item in TimerOrder)
                {
                    if(item.Time==0)
                    {
                        var emp = _context.Employees.SingleOrDefault(s => s.ID == item.order.EmployeeID);
                        alertControl1.Show(this, "هذا الموظف يجب أن يكون قد وصل", emp.Name);
                        TimerOrder.Remove(item);
                        continue;
                        //var order2 = _context.Orders.SingleOrDefault(s => s.ID == item.order.ID);
                        //_context.SaveChanges();
                    }
                    item.Time--;
                }
            };
            toto.Start();
            #endregion
            #region intilize Wating Timer
            Timer Wait = new Timer();
            Wait.Interval = 60000;
            Wait.Tick += (Sender, e) =>
            {
                foreach (var item in TimerWating)
                {
                    var t = new TimeSpan(0, 30, 0);
                    var total = DateTime.Now.TimeOfDay + t;
                    if (item.Time <= total)
                    {
                        var orderRadey = _context?.Orders?.SingleOrDefault(s => s.ID == item.ID);
                        orderRadey.Status = (int)Status.Seen;
                        _context.SaveChanges();
                        alertControl1.Show(this, "حان وقت ارسال الطلب", item.Details);
                    }
                }
            };
            Wait.Start();
            #endregion
            backgroundWorker1.RunWorkerAsync();
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
                    var ISNewdata = DB?.Orders?.Include("Customer")?.Include("Employee")?.Include("Vehicle")?.Where(S => S.Status == 0).Any();

                    if ((bool)ISNewdata)
                    {
                         UpData = DB?.Orders?.Where(S => S.Status == (int)Status.Created||S.Status==(int)Status.Seen || S.Status == (int)Status.Waiting).ToList();
                        foreach (var item in UpData)
                        {
                            if (item.Time > DateTime.Now.TimeOfDay)
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
                        }
                        //gridControl1.DataSource = UpData;
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { gridControl1.DataSource = UpData; });
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
            fofo.Show();
          
        }
    }
    public class TimerOrder
    {
        public Order order { get; set; }
        public int? Time { get; set; }
        public bool IsNew { get; set; }
    }
    public class SendOrder
    {
        public Guid ID { get; set; }
        public string Details { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public decimal? Earn { get; set; }
        public string Location { get; set; }
        public DateTime? StartTime { get; set; }
        public int Status { get; set; }
        public int? Timer { get; set; }
    }
}