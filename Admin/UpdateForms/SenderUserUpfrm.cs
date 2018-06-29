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
    public partial class SenderUserUpfrm : DevExpress.XtraEditors.XtraForm
    {
        public static event UpGrid UpdateGridUP;
        string Connection = "";
        Guid ID;
        public static event UpGrid UpdateGridIN;
        public SenderUserUpfrm(Guid id, string con)
        {
            InitializeComponent();
            Connection = con;
            ID = id;
            DataContext.ConnectionString = Connection;
            using (DataContext Db = new DataContext())
            {
                var Emp = Db?.SenderUsers?.Include("Employee")?.SingleOrDefault(s => s.ID == ID);
                NameTxt.Text = Emp.Username;
                PasswordTxt.Text = Emp.Password;
              EmployeeLUE.Properties.DataSource = Db.Employees.ToList();
                EmployeeLUE.Properties.ValueMember = "ID";
                EmployeeLUE.Properties.DisplayMember = "Name";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name");
                EmployeeLUE.Properties.Columns.Add(col);
                EmployeeLUE.EditValue = Emp.EmployeeID;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataContext Db = new DataContext())
                {
                    var Emp = Db?.SenderUsers?.SingleOrDefault(s => s.ID == ID);
                    Emp.Username = NameTxt.Text;
                    Emp.Password = PasswordTxt.Text;
                    Emp.EmployeeID = (Guid)EmployeeLUE.EditValue;
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