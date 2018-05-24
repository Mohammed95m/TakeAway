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
using SenderFrm;
using TakeAway;

namespace SenderFrm
{
    public partial class ServerFrm : DevExpress.XtraEditors.XtraForm
    {
        public ServerFrm()
        {
            InitializeComponent();
            string conn = Settings1.Default.Connection;
            if (string.IsNullOrEmpty(conn))
            {
                textEdit1.EditValue = Data.Data.DataContext.ConnectionString;
            }
            else
            {
                textEdit1.EditValue = Settings1.Default.Connection;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Settings1.Default.Connection = textEdit1.Text;
            Data.Data.DataContext.ConnectionString = textEdit1.Text;
            this.Close();
        }
    }
}