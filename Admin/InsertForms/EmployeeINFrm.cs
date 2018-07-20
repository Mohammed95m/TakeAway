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
    public partial class EmployeeINFrm : DevExpress.XtraEditors.XtraForm
    {
        string Connection = "";
        public static event UpGrid UpdateGridIN;
        public EmployeeINFrm( string con)
        {
            InitializeComponent();
            Connection = con;
            using (DataContext Db = new DataContext())
            {
                lookUpEdit1.Properties.DataSource = Db.Vehicles.ToList();
                lookUpEdit1.Properties.ValueMember = "ID";
                lookUpEdit1.Properties.DisplayMember = "Number";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name");
                lookUpEdit1.Properties.Columns.Add(col);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Data.Data.Employee Emp = new Data.Data.Employee {
                Name = NameTxt.Text,
                LastName = LastNameTxt.Text,
                Salary = decimal.Parse(String.IsNullOrEmpty(SalaryTxt.Text) ? "00" : SalaryTxt.Text),
                Address = LocationTxt.Text,
                Phone = PhoneTxt.Text,
                Date = DateTime.Now,
                IsBike=IsBikeChx.Checked,
                VehicleID=(Guid)lookUpEdit1?.EditValue
                
            };


            DataContext.ConnectionString = Connection;
            try
            {
                using (DataContext Db = new DataContext())
                {
                    Db.Employees.Add(Emp);
                    Db.SaveChanges();
                    UpdateGridIN();
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