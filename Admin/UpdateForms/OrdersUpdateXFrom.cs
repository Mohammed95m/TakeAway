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

namespace Admin.UpdateForms
{
    public partial class OrdersUpdateXFrom : DevExpress.XtraEditors.XtraForm
    {
        Guid id;
        List<Vehicle> vehList;
        List<Data.Data.Employee> empList;
        //List<SenderUser> senList;
        //List<CallUser> callList;
        List<Customer> cusList;

        public OrdersUpdateXFrom(Guid id)
        {
            this.id = id;
            InitializeComponent();
            using (DataContext Db = new DataContext())
            {
                vehList = Db?.Vehicles?.ToList();
                empList = Db?.Employees?.ToList();
                //senList = Db?.SenderUsers?.ToList();
                //callList = Db?.CallUsers?.ToList();
                cusList = Db?.Customers?.ToList();

                EmpLook.Properties.DataSource = empList;
                VehicleLook.Properties.DataSource = vehList;
                //SenderEmpLook.Properties.DataSource = senList;
                //CallEmpLook.Properties.DataSource = callList;
                CustomerLook.Properties.DataSource = cusList;

                EmpLook.Properties.ValueMember = "ID";
                VehicleLook.Properties.ValueMember = "ID";
                //SenderEmpLook.Properties.ValueMember = "ID";
                //CallEmpLook.Properties.ValueMember = "ID";
                CustomerLook.Properties.ValueMember = "ID";

                EmpLook.Properties.DisplayMember = "Name";
                VehicleLook.Properties.DisplayMember = "Number";
                //SenderEmpLook.Properties.DisplayMember = "Username";
                //CallEmpLook.Properties.DisplayMember = "Username";
                CustomerLook.Properties.DisplayMember = "Name";

                DevExpress.XtraEditors.Controls.LookUpColumnInfo nameCol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name");
                DevExpress.XtraEditors.Controls.LookUpColumnInfo numberCol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number");
                DevExpress.XtraEditors.Controls.LookUpColumnInfo usernameCol = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Username");

                EmpLook.Properties.Columns.Add(nameCol);
                CustomerLook.Properties.Columns.Add(nameCol);
                //SenderEmpLook.Properties.Columns.Add(usernameCol);
                //CallEmpLook.Properties.Columns.Add(usernameCol);
                VehicleLook.Properties.Columns.Add(numberCol);


                var order = Db?.FinishedOrders?.SingleOrDefault(s => s.ID == id);
                EarnTxt.Text = order.Earn.ToString();
                OrderTxt.Text = order.Details.ToString();
                LocationTxt.Text = order.Location.ToString();

                EmpLook.EditValue = order.EmployeeID;
                CustomerLook.EditValue = order.CustomerID;
                VehicleLook.EditValue = order.VehicleID;
                //SenderEmpLook.EditValue = order.SenderUserID;
                //CallEmpLook.EditValue = order.CallUserID;

            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            using (DataContext coco = new DataContext())
            {

                try
                {
                    var order = coco.FinishedOrders.SingleOrDefault(s => s.ID == id);

                    order.Earn = decimal.Parse((!string.IsNullOrEmpty(EarnTxt.Text) ? RemovePoint(EarnTxt.Text) : "0"));
                    order.Details = OrderTxt.Text;
                    order.Location = LocationTxt.Text;
                    order.VehicleID = (Guid)VehicleLook.EditValue;
                    order.EmployeeID = (Guid)EmpLook.EditValue;
                    order.VehicleNumber = coco.Vehicles.SingleOrDefault(s => s.ID == (Guid)VehicleLook.EditValue).Number;
                    order.EmployeeNaame = coco.Employees.SingleOrDefault(s => s.ID == (Guid)EmpLook.EditValue).Name;
                    order.CustomerID = (Guid) CustomerLook.EditValue;
                    order.CustomerName = coco.Customers.SingleOrDefault(s => s.ID == (Guid)CustomerLook.EditValue).Name;

                    var IsSave = await coco.SaveChangesAsync();
                    coco.SaveChanges();
                    if (IsSave > 0)
                    {
                        this.Close();
                    }

                    else
                        MessageBox.Show("حدث تضارب أعد المحاولة");

                }
                catch (Exception ex)
                {

                }
            }
        }

        public string RemovePoint(string s)
        {

            int index = s.IndexOf(".");
            if (index > 0)
                s = s.Substring(0, index);
            return s;
        }
    }
}