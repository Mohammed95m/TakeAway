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
    public partial class BikeFrm : DevExpress.XtraEditors.XtraForm
    {
        string con = "Data Source=localhost;Initial Catalog=TakeAwayDB2;Integrated Security=True";
        public BikeFrm( string connection)
        {
            InitializeComponent();
            con = connection;
            DataContext.ConnectionString = con;
            DataContext DB = new DataContext();
            gridControl1.DataSource = DB.Vehicles.ToList();
            //gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;


            BikeUpfrm.UpdateGridUP += () => {
                gridControl1.DataSource = DB.Vehicles.ToList();
            };
            BikeInfrm.UpdateGridIN+=() => {
                gridControl1.DataSource = DB.Vehicles.ToList();
            };


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void إَ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            BikeInfrm fofo = new BikeInfrm(con);
            fofo.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                BikeUpfrm fofo = new BikeUpfrm(Guid.Parse(id), con);
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
                    var emp = DB?.Vehicles?.SingleOrDefault(s => s.ID == ID);
                    DB.Vehicles.Remove(emp);
                    DB.SaveChanges();
                    gridControl1.DataSource = DB.Vehicles.ToList();
                }
                    
            }
            catch (Exception g)
            {

    
            }
        

        }
    }
}