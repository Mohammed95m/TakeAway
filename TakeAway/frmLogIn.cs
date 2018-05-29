using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatApp.Classes.MyFunction;
using DevExpress.XtraEditors;
using ChatApp.Classes;
using Data.Data;
using TakeAway;
using SenderFrm;

namespace ChatApp.Forms
{
    public partial class frmLogIn : DevExpress.XtraEditors.XtraForm
    {
        //ErrorProvider er1 = new ErrorProvider();
        //ErrorProvider er = new ErrorProvider();
        public frmLogIn()
        {
            InitializeComponent();
            Data.Data.DataContext.ConnectionString = Settings1.Default.Connection;
            //using (DataContext con = new DataContext())
            //{
            //    con.Database.CreateIfNotExists();
            //    try
            //    {
            //        var IsUser = con?.CallUsers?.SingleOrDefault(s => s.Username == "admin");
            //        if (IsUser == null)
            //        {
            //            CallUser soso = new CallUser() { Username = "admin", Password = "admin" ,Date=DateTime.Now};
            //            con.CallUsers.Add(soso);
            //            con.SaveChanges();
            //        }
            //    }
            //    catch (Exception e){}
               
           // }

        }

        private void txtEmailLogIN_Validating(object sender, CancelEventArgs e)
        {
            
            //if (string.IsNullOrEmpty(txtEmailLogIN.Text))
            //{
            //    e.Cancel = true;
            //    txtEmailLogIN.Focus();
            //    er.SetError(txtEmailLogIN, "الرجاء ادخال اسم المستخدم");
            //}
            //else
            //{
            //    e.Cancel = false;
            //   er.SetError(txtEmailLogIN, null);

            //}
        }

        private void txtEmailLogIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcs.validateEmail(e);
        }

        private void txtPasswordLogIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcs.checkSpace(e);
        }

        private void txtPasswordLogIN_Validating(object sender, CancelEventArgs e)
        {
           
            //if (txtPasswordLogIN.Text.Length < 8)
            //{
            //    e.Cancel = true;
            //    txtPasswordLogIN.Focus();
            //   er1.SetError(txtPasswordLogIN, "The Password must be greater than Or Equal 8 letters");
            //}
            //else er1.SetError(txtPasswordLogIN, null);
        }

        private void btnLogIN_Click(object sender, EventArgs e)
        {

            string emailUser = txtEmailLogIN.Text;
            using (var mes = new DataContext())
            {
                mes.Database.CreateIfNotExists();
                var logInUser = mes.CallUsers.Where(s => s.Username.ToLower() == emailUser.ToLower()).FirstOrDefault();
                if (logInUser == null)
                {
                    MessageBox.Show("UsernameIncorrect");
                }
                else
                {
                    if (logInUser.Password == txtPasswordLogIN.Text)
                    {
                        this.Hide();
                        Form1 usertChat = new Form1(logInUser);
                        usertChat.ShowDialog();
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("كلمة السر خطأ !");
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPasswordLogIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIN_Click(this, new EventArgs());
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ServerFrm fofo = new ServerFrm();
            fofo.ShowDialog();
        }
    }
}