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
    public partial class BikeUpfrm : DevExpress.XtraEditors.XtraForm
    {
        public static event UpGrid UpdateGridUP;
        string Connection = "";
        Guid ID;
        public static event UpGrid UpdateGridIN;
        public BikeUpfrm(Guid id, string con)
        {
            InitializeComponent();
            Connection = con;
            ID = id;
            DataContext.ConnectionString = Connection;
            using (DataContext Db = new DataContext())
            {
                var Emp = Db?.Vehicles?.SingleOrDefault(s => s.ID == ID);
                NameTxt.Text = Emp.Number.ToString();
                IsAvalibleChx.Checked = Emp.IsAvailable;
            //EmployeeLUE.Properties.DataSource = Db.Employees;
            //    EmployeeLUE.Properties.ValueMember = "ID";
            //    EmployeeLUE.Properties.DisplayMember = "Name";
            //    DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name");
            //    EmployeeLUE.EditValue = Emp.EmployeeID;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTxt.Text))
            {
                MessageBox.Show("يجب عليك إدخال رقم الدراجة");
            }
            else
            {
                try
                {
                    using (DataContext Db = new DataContext())
                    {
                        var Emp = Db?.Vehicles?.SingleOrDefault(s => s.ID == ID);
                        Emp.Number = int.Parse(NameTxt.Text);
                        Emp.IsAvailable = IsAvalibleChx.Checked;
                        //Emp.EmployeeID = (Guid)EmployeeLUE.EditValue;
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
}