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
    public partial class SenderUserInfrm : DevExpress.XtraEditors.XtraForm
    {
        string Connection = "";
        public static event UpGrid UpdateGridIN;
        public SenderUserInfrm(string con)
        {
            InitializeComponent();
            Connection = con;
            DataContext.ConnectionString = Connection;
            using (DataContext Db = new DataContext())
            {
                EmployeeLUE.Properties.DataSource = Db.Employees.ToList();
                EmployeeLUE.Properties.ValueMember = "ID";
                EmployeeLUE.Properties.DisplayMember = "Name";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name");
                EmployeeLUE.Properties.Columns.Add(col);
            }
         //   (Guid)EmployeeLUE.EditValue;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
          
            try
            {
                Data.Data.SenderUser Emp = new Data.Data.SenderUser
                {
                    Username = NameTxt.Text,
                    Password = PasswordTxt.Text,
                    EmployeeID = (Guid)EmployeeLUE.EditValue,
                    Date = DateTime.Now
                };

                using (DataContext Db = new DataContext())
                {
                    Db.SenderUsers.Add(Emp);
                    Db.SaveChanges();
                    UpdateGridIN();
                    this.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(" تأكد من المدخلات أو من اتصالك بالسيرفر");
            }
          

        }
    }
}