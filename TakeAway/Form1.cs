using Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Enums;
using ChatApp.Forms;

namespace TakeAway
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Customer MainCustomer { get; set; }
        public Order MainOrder { get; set; }
        public CallUser CallUser { get; set; }
        public Form1(CallUser user)
        {
            InitializeComponent();
            MessageBox.Show("f");
            TimeTxt.EditValueChanged += (sender, e) =>
            {
                TimeSpan now = DateTime.Now.TimeOfDay;
                TimeSpan def = TimeTxt.TimeSpan - now;
                afterTimeLbl.Text = "بعد " + def.Hours + " ساعة و " + def.Minutes + "دقيقة";
            };

            using (DataContext _context = new DataContext())
            {
                gridControl1.DataSource = _context.Orders.Where(s => s.Date.Day == DateTime.Now.Day && s.Date.Year == DateTime.Now.Year && s.Date.Month == DateTime.Now.Month).ToList();
            }
            CallUser = user;
            gridView1.OptionsView.ShowGroupPanel = false;

        }
        /// <summary>
        /// return True while Customer Exist
        /// </summary>
        /// <param name="DataContext"></param>
        ///  <param name="saveBtn">if true dont show messagebox</param>
        /// <returns></returns>
        public bool ChecKCustomer(DataContext _context, bool saveBtn)
        {
            //single
            var Customer = _context?.Customers?.FirstOrDefault(s => s.Phone == CustomerNumberTxt.Text);
            if (Customer != null)
            {
                MainCustomer = Customer;
                CustomerNameTxt.Text = Customer.Name;
                LocationTxt.Text = Customer.Location;
                return true;
            }
            else
            {
                if (!saveBtn)
                    MessageBox.Show("هذا الزبون غير مسجل مسبقا");
                return false;
            }
            ;

        }
        public bool SaveCustomer(DataContext _context)
        {
            try
            {
                Customer NewCust = new Customer
                {
                    Name = CustomerNameTxt.Text,
                    Date = DateTime.Now,
                    Location = LocationTxt.Text,
                    Phone = CustomerNumberTxt.Text
                };
                _context.Customers.Add(NewCust);
                _context.SaveChanges();
                MainCustomer = NewCust;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;

            }


        }

        public bool SaveOrder(DataContext _context)
        {
            try
            {
              //  var Price = int.Parse(PriceTxt.Text);
              //  var time = int.Parse(TimeTxt?.Text ?? "0");
                if (MainOrder != null)
                {
                    //single
                    var Order = _context?.Orders?.FirstOrDefault(s => s.ID == MainOrder.ID);
                    if (Order != null)
                    {
                        Order.Customer = MainCustomer;
                        Order.Details = OrderTxt.Text;
                     //   Order.Earn = Price;
                        Order.Updated = 1;
                        //  Order.Timer = time;
                        Order.Time = TimeTxt.TimeSpan;
                        Order.Date = DateTime.Now;
                        Order.Location = LocationTxt.Text;
                        //if(Order.Time>DateTime.Now.TimeOfDay)
                        //    Order.Status = (int)Status.Waiting;
                        //else
                        //{
                            Order.Status = (int)Status.Created;
                      //  }
                        
                        Order.CallUserID = CallUser.ID;
                        _context.SaveChanges();
                     
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                  
                }
          
          
                else
                {
                    Order NewOrder = new Order
                    {
                        Customer = MainCustomer,
                        Details = OrderTxt.Text,
                        //           CallUser=
              //          Earn = Price
              //   ,
                        //   Timer = time
                        Time = ((TimeSpan)TimeTxt.EditValue == new TimeSpan(0, 0, 0, 0)) ? DateTime.Now.TimeOfDay : (TimeSpan)TimeTxt.EditValue
                 ,
                        Date = DateTime.Now,
                        Location = LocationTxt.Text,
                        Status = (int)Status.Created

                    };
                    _context.Orders.Add(NewOrder);
                    if (NewOrder.Time > DateTime.Now.TimeOfDay)
                        NewOrder.Status = (int)Status.Waiting;
                    else
                    {
                        NewOrder.Status = (int)Status.Created;
                    }
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;

            }

        }


  
        public void RefreshControls(DataContext _context)
        {
            MainOrder = null;
            MainCustomer = null;
            TimeTxt.EditValue = new TimeSpan(0,0,0,0);
          //  PriceTxt.Text = null;
            OrderTxt.Text = null;
            LocationTxt.Text = null;
            CustomerNumberTxt.Text = null;
            CustomerNameTxt.Text = null;
            gridControl1.DataSource = _context.Orders.Where(s => s.Date.Day == DateTime.Now.Day && s.Date.Year == DateTime.Now.Year && s.Date.Month == DateTime.Now.Month).ToList();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (DataContext _context = new DataContext())
            {
                ChecKCustomer(_context, false);
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (DataContext _context = new DataContext())
            {
                bool IsExist = ChecKCustomer(_context, true);
                if (IsExist)
                {
                    bool IsSave = SaveOrder(_context);
                    if (IsSave)
                    {
                        RefreshControls(_context);

                    }
                }
                else
                {
                    bool IsSave = SaveCustomer(_context);
                    if (IsSave)
                    {
                        SaveOrder(_context);
                        RefreshControls(_context);

                    }

                }
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void DeleteBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        public string RemovePoint(string s)
        {
           
            int index = s.IndexOf(".");
            if (index > 0)
                s = s.Substring(0, index);
            return s;
        }
        private void UpdateBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = gridView1.GetFocusedRow() as Order;
            if (row.Status != (int)Status.InProgress)
            {
                using (DataContext _context = new DataContext())
                {
                    Customer cost = _context?.Customers?.FirstOrDefault(S => S.ID == row.CustomerID);
                    CustomerNameTxt.Text = cost?.Name;
                    //single
                    CustomerNumberTxt.Text = cost?.Phone;
                    LocationTxt.Text = row?.Location;
                    OrderTxt.Text = row.Details;
                    
              //      PriceTxt.Text = RemovePoint(row.Earn.ToString());
                    TimeTxt.TimeSpan = row.Time;
                    MainOrder = row;

                }
            }
            else
            {
                 if ( DialogResult.Yes==MessageBox.Show("تنبيه", "هذا الطلب قيد التوصيل هل تريد التعديل عليه ؟ ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    using (DataContext _context = new DataContext())
                    {
                        Customer cost = _context?.Customers?.FirstOrDefault(S => S.ID == row.CustomerID);
                        CustomerNameTxt.Text = cost?.Name;
                        //single
                        CustomerNumberTxt.Text = cost?.Phone;
                        LocationTxt.Text = row?.Location;
                        OrderTxt.Text = row.Details;
                 //       PriceTxt.Text = RemovePoint(row.Earn.ToString());
                        TimeTxt.TimeSpan = row.Time;
                        MainOrder = row;
                    }
                }
            }
           

           
          

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using(DataContext _context = new DataContext())
            {
                RefreshControls(_context);

            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow() as Order;
            if (row.Status != (int)Status.InProgress)
            {
                using (DataContext _context = new DataContext())
                {
                    var ord = _context?.Orders?.SingleOrDefault(s => s.ID == row.ID);
                    _context.Orders.Remove(ord);
                    _context.SaveChanges();
                    RefreshControls(_context);
                }
            }
            else
            {
                MessageBox.Show("إن هذه الطلبية قيد التوصيل لا تملك صلاحيةالتعديل عليها؟");
            }
            }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CallUser = null;
            frmLogIn fofo = new frmLogIn();
            fofo.ShowDialog();
            this.Close();
        }
    }
}
