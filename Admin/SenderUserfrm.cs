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
    public partial class SenderUserfrm : DevExpress.XtraEditors.XtraForm
    {
        string con = "Data Source=localhost;Initial Catalog=TakeAwayDB2;Integrated Security=True";
    public SenderUserfrm( string connection)
        {
            InitializeComponent();
            con = connection;
            DataContext.ConnectionString = con;
            DataContext DB = new DataContext();
            var data = DB.SenderUsers.Include("Employee").Select(x => new { ID=x.ID, x.Username, x.Password, Employee = x.Employee.Name, x.Date }).ToList();
            gridControl1.DataSource = data;
            //gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;


            SenderUserUpfrm.UpdateGridUP += () => {
                gridControl1.DataSource = DB.SenderUsers.Include("Employee").Select(x => new { ID= x.ID, x.Username, x.Password, Employee = x.Employee.Name, x.Date }).ToList();
            };
            SenderUserInfrm.UpdateGridIN+=() => {
                gridControl1.DataSource = DB.SenderUsers.Include("Employee").Select(x => new { ID= x.ID, x.Username, x.Password, Employee = x.Employee.Name, x.Date }).ToList();
            };


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void إَ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            SenderUserInfrm fofo = new SenderUserInfrm(con);
            fofo.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                SenderUserUpfrm fofo = new SenderUserUpfrm(Guid.Parse(id), con);
                fofo.ShowDialog();
            }
            catch (Exception ee)
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
                    var emp = DB?.SenderUsers?.SingleOrDefault(s => s.ID == ID);
                    DB.SenderUsers.Remove(emp);
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