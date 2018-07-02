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
    public partial class BikeInfrm : DevExpress.XtraEditors.XtraForm
    {
        string Connection = "";
        public static event UpGrid UpdateGridIN;
        public BikeInfrm(string con)
        {
            InitializeComponent();
            Connection = con;
            DataContext.ConnectionString = Connection;
          
         //   (Guid)EmployeeLUE.EditValue;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTxt.Text))
            {
                MessageBox.Show("يجب عليك إدخال رقم الدراجة");
            }
            else
            {

            }
           

        }
    }
}