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

namespace Admin.InsertForms
{
    public delegate void UpGrid();
    public partial class EmployeeUPFrm : DevExpress.XtraEditors.XtraForm
    {
        string Connection = "";
        Guid ID;
        public static event UpGrid UpdateGridUP;
        public EmployeeUPFrm(Guid id, string con)
        {
            InitializeComponent();
            Connection = con;
            ID = id;
            DataContext.ConnectionString = Connection;
            using (DataContext Db = new DataContext())
            {
                lookUpEdit1.Properties.DataSource = Db.Vehicles.ToList();
                lookUpEdit1.Properties.ValueMember = "ID";
                lookUpEdit1.Properties.DisplayMember = "Number";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number");
                lookUpEdit1.Properties.Columns.Add(col);
              
                var Emp = Db?.Employees?.SingleOrDefault(s => s.ID == ID);
                lookUpEdit1.EditValue = Emp?.VehicleID;
                NameTxt.Text = Emp.Name ;
                LastNameTxt.Text= Emp.LastName ;
                SalaryTxt.Text = Emp.Salary.ToString();
                LocationTxt.Text = Emp.Address;
                PhoneTxt.Text = Emp.Phone;
                IsBikeChx.Checked = Emp.IsBike??false;

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          

         
            try
            {
                using (DataContext Db = new DataContext())
                {
                    var Emp = Db?.Employees?.SingleOrDefault(s => s.ID == ID);
                    Emp.Name = NameTxt.Text;
                    Emp.LastName = LastNameTxt.Text;
                    Emp.Salary = decimal.Parse(String.IsNullOrEmpty(SalaryTxt.Text) ? "00" : SalaryTxt.Text);
                    Emp.Address = LocationTxt.Text;
                    Emp.Phone = PhoneTxt.Text;
                    Emp.IsBike = IsBikeChx.Checked;
                    Emp.VehicleID = (Guid)lookUpEdit1?.EditValue;
                    Db.SaveChanges();
                    UpdateGridUP();
                    this.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
          

        }
    }
}