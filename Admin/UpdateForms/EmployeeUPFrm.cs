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
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          

            DataContext.ConnectionString = Connection;
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