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

namespace Admin
{
    public partial class CustomerGrid : DevExpress.XtraEditors.XtraForm
    {
        public CustomerGrid()
        {
            InitializeComponent();
            //DataContext.ConnectionString = "Data Source=localhost;Initial Catalog=TakeAwayDB2;Integrated Security=True";
                using (DataContext DB = new DataContext())
                {
                    var orders = DB?.Customers?.ToList();
                    gridControl1.DataSource = orders;
                }
            }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                Guid ID = Guid.Parse(id);
                try
                {
                    using (DataContext DB = new DataContext())
                    {
                        var finOrder = DB?.Customers?.SingleOrDefault(s => s.ID == ID);
                        DB.Customers.Remove(finOrder);
                        DB.SaveChanges();
                        MessageBox.Show("تمت العملية بنجاح");
                    }
                }
                catch (Exception aa)
                {
                    MessageBox.Show("حدث خطأ ");
                }

            }
        }
    }
}