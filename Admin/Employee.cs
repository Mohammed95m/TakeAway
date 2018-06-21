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
using Data;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using Admin.InsertForms;

namespace Admin
{
    public partial class Employee : DevExpress.XtraEditors.XtraForm
    {
        string con = "Data Source=localhost;Initial Catalog=TakeAwayDB2;Integrated Security=True";
        public Employee( string connection)
        {
            InitializeComponent();
            con = connection;
            DataContext.ConnectionString = con;
            DataContext DB = new DataContext();
            gridControl1.DataSource = DB.Employees.ToList();
            //gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;


            EmployeeUPFrm.UpdateGridUP += () => {
                gridControl1.DataSource = DB.Employees.ToList();
            };
            EmployeeINFrm.UpdateGridIN+=() => {
                gridControl1.DataSource = DB.Employees.ToList();
            };


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void إَ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            EmployeeINFrm fofo = new EmployeeINFrm(con);
            fofo.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                EmployeeUPFrm fofo = new EmployeeUPFrm(Guid.Parse(id), con);
                fofo.ShowDialog();
            }
            catch (Exception)
            {

       
            }
          
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (DataContext DB = new DataContext())
                {
                    var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                    Guid ID = Guid.Parse(id);
                    var emp = DB?.Employees?.SingleOrDefault(s => s.ID == ID);
                    DB.Employees.Remove(emp);
                    DB.SaveChanges();
                    gridControl1.DataSource = DB.Employees.ToList();
                }
                    
            }
            catch (Exception g)
            {

    
            }
        

        }
    }
}