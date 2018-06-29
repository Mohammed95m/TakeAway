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
    public partial class CallUserInfrm : DevExpress.XtraEditors.XtraForm
    {
        string Connection = "";
        public static event UpGrid UpdateGridIN;
        public CallUserInfrm(string con)
        {
            InitializeComponent();
            Connection = con;
            DataContext.ConnectionString = Connection;
            using (DataContext Db = new DataContext())
            {
                EmployeeLUE.Properties.DataSource = Db.Employees;
                EmployeeLUE.Properties.ValueMember = "ID";
                EmployeeLUE.Properties.DisplayMember = "Name";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name");
                EmployeeLUE.Properties.Columns.Add(col);
            }
         //   (Guid)EmployeeLUE.EditValue;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Data.Data.CallUser Emp = new Data.Data.CallUser
            {
                Username = NameTxt.Text,
                Password = PasswordTxt.Text,
                EmployeeID = (Guid)EmployeeLUE.EditValue,
                Date = DateTime.Now
            };
          
            try
            {
                using (DataContext Db = new DataContext())
                {
                    Db.CallUsers.Add(Emp);
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