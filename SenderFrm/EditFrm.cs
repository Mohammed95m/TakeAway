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
using Data.Data;
using Data.Enums;

namespace SenderFrm
{
    public delegate void UpGrid(Order o);
    public partial class EditFrm : DevExpress.XtraEditors.XtraForm
    {
        public static event UpGrid UpdateGrid;
        Order MainOrder;
        Guid SenderUserID;
        bool isExist = true;

        public EditFrm(Guid OrderID,Guid? UserID)
        {
            InitializeComponent();
            TimeTxt.EditValueChanged += (sender, e) =>
            {
                TimeSpan now = DateTime.Now.TimeOfDay;
                TimeSpan def = TimeTxt.TimeSpan - now;
                afterTimeLbl.Text = "بعد " + def.Hours + " ساعة و " + def.Minutes + "دقيقة";
            };
            SenderUserID =(Guid) UserID;
           // DataContext.ConnectionString = Settings1.Default.Connection;
            DataContext coco = new DataContext();


            List<Vehicle> vList = coco?.Vehicles?.ToList();
            List<Employee> eList = coco?.Employees?.ToList();

            MainOrder = coco?.Orders.Include("Customer")?.SingleOrDefault(s => s.ID == OrderID);
            isExist = MainOrder == null ? false : true;
            if (isExist)
            {
                labelControl4.Text = MainOrder.Details + ": تفاصيل الطلب";
                labelControl3.Text = MainOrder?.Customer?.Name + ": اسم الزبون";
                labelControl2.Text = MainOrder.Location + ": الموقع";
                lookUpEdit2.Properties.DataSource = vList;
                lookUpEdit2.Properties.ValueMember = "ID";
                lookUpEdit2.Properties.DisplayMember = "Number";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number");
                lookUpEdit2.Properties.Columns.Add(col);
                lookUpEdit1.Properties.DataSource = eList;
                lookUpEdit1.Properties.ValueMember = "ID";
                lookUpEdit1.Properties.DisplayMember = "Name";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col2 = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name");
                lookUpEdit1.Properties.Columns.Add(col2);
                lookUpEdit2.EditValue = MainOrder?.VehicleID;
                lookUpEdit1.EditValue = MainOrder?.EmployeeID;
                earnTE.EditValue = MainOrder?.Earn?.ToString();
                TimeTxt.EditValue = MainOrder.BikeTime;
                // textEdit1.EditValue = MainOrder?.Timer;

                if (eList.Count > 0)
                {
                    lookUpEdit1.EditValue = eList[0].ID;
                }
                if (vList.Count > 0)
                {
                    lookUpEdit2.EditValue = vList[0].ID;
                }
            }
            
        }

        private void EditFrm_Load(object sender, EventArgs e)
        {
            if (!isExist)
            {
                MessageBox.Show("الطلب محذوف");
                Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
            using (DataContext coco = new DataContext())
            {
                var order = coco.Orders.SingleOrDefault(s => s.ID == MainOrder.ID);
                order.VehicleID = (Guid)lookUpEdit2.EditValue;
                order.EmployeeID = (Guid)lookUpEdit1.EditValue;
                //       order.Timer = int.Parse(string.IsNullOrEmpty(textEdit1.Text) ? "0" : textEdit1.Text);
                order.BikeTime = ((TimeSpan)TimeTxt.EditValue == new TimeSpan(0, 0, 0, 0)) ? DateTime.Now.TimeOfDay : (TimeSpan)TimeTxt.EditValue;
                order.Status = (int)Status.InProgress;
                order.StartTime = DateTime.Now;
                order.Earn = decimal.Parse((!string.IsNullOrEmpty(earnTE.Text)? RemovePoint(earnTE.Text):"0"));
                order.SenderUserID = SenderUserID;
                coco.SaveChanges();
                UpdateGrid(order);
                this.Close();
            }
            }
        public string RemovePoint(string s)
        {

            int index = s.IndexOf(".");
            if (index > 0)
                s = s.Substring(0, index);
            return s;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
           using(DataContext db = new DataContext())
            {
                if(DialogResult.OK==MessageBox.Show("حذف","هل أنت متأكد من أنك ستحذف هذا الطلب ؟", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    var DelOrder = db.Orders.SingleOrDefault(s => s.ID == MainOrder.ID);
                    db.Orders.Remove(DelOrder);
                    db.SaveChanges();
                    this.Close();
                }
               
            }
      
        }
    }
}