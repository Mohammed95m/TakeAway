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
    public partial class AdminUserInfrm : DevExpress.XtraEditors.XtraForm
    {
        string Connection = "";
        public static event UpGrid UpdateGridIN;
        public AdminUserInfrm(string con)
        {
            InitializeComponent();
            Connection = con;
            DataContext.ConnectionString = Connection;
          
         //   (Guid)EmployeeLUE.EditValue;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Data.Data.AdminUser Emp = new Data.Data.AdminUser
            {
                Username = NameTxt.Text,
                Password = PasswordTxt.Text,
                Date = DateTime.Now
            };
          
            try
            {
                using (DataContext Db = new DataContext())
                {
                    Db.AdminUsers.Add(Emp);
                    Db.SaveChanges();
                    UpdateGridIN();
                    this.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + " f");
            }
          

        }
    }
}