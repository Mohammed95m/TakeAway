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
    public partial class AdminUserfrm : DevExpress.XtraEditors.XtraForm
    {
        string con = "Data Source=localhost;Initial Catalog=ldjks;Integrated Security=True";
        public AdminUserfrm( string connection)
        {
            InitializeComponent();
            con = connection;
            DataContext.ConnectionString = con;
            DataContext DB = new DataContext();
            gridControl1.DataSource = DB.AdminUsers.Include("Employee").Select(x=>new {x.ID,x.Username,x.Password,x.Date }).ToList();
            //gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;


            AdminUserInfrm.UpdateGridIN += () => {
                gridControl1.DataSource = DB.AdminUsers.Select(x => new { x.ID, x.Username, x.Password, x.Date }).ToList();
            };
            AdminUserUpfrm.UpdateGridUP +=() => {
                gridControl1.DataSource = DB.AdminUsers.Select(x => new { x.ID, x.Username, x.Password, x.Date }).ToList();
            };


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void إَ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            AdminUserInfrm fofo = new AdminUserInfrm(con);
            fofo.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                AdminUserUpfrm fofo = new AdminUserUpfrm(Guid.Parse(id), con);
                fofo.ShowDialog();
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
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
                    var emp = DB?.AdminUsers?.SingleOrDefault(s => s.ID == ID);
                    DB.AdminUsers.Remove(emp);
                    DB.SaveChanges();
                    gridControl1.DataSource = DB.AdminUsers.Select(x => new { x.ID, x.Username, x.Password, x.Date }).ToList(); ;
                }
                    
            }
            catch (Exception g)
            {

    
            }
        

        }
    }
}