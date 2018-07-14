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
    public partial class EmployeeOrders : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeOrders(Guid emp, bool OnlyDayChx, DateTime? frmoDate, DateTime? ToDate)
        {
            InitializeComponent();

            List<FinishedOrder> Orders;
            using (DataContext DB = new DataContext())
            {
                if (OnlyDayChx == true)
                {
                    Orders = DB?.FinishedOrders?.Include("Vehicle")?.Include("Employee")?.Where(s => s.Date.Day == frmoDate.Value.Day && s.Date.Month == frmoDate.Value.Month
                   && s.Date.Year == frmoDate.Value.Year&& s.EmployeeID==emp).ToList();
                }
                else
                {
                    Orders = DB?.FinishedOrders?
                        .Include("Vehicle")?.Include("Employee")?.Where(s => s.Date >= frmoDate && s.Date <= ToDate && s.EmployeeID == emp).ToList();
                }
            }
            gridControl1.DataSource = Orders;
            EarnLbl.Text = Orders.Sum(s => s.Earn).ToString();
            NumberOrdersLbl.Text = Orders.Count().ToString();
            FromDateLbl.Text = frmoDate.Value.Year + "/" + frmoDate.Value.Month + "/" + frmoDate.Value.Day;
            ToDateLbl.Text = ToDate.Value.Year + "/" + ToDate.Value.Month + "/" + ToDate.Value.Day;
        }
         

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && ( e.Control))
            {
                if (!layoutControl1.IsPrintingAvailable)
                {
                    MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                    return;
                }

                // Open the Preview window.
                layoutControl1.ShowPrintPreview();
            }
            //if (e.KeyCode == Keys.Delete)
            //{
            //    var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            //    Guid ID = Guid.Parse(id);
            //    try
            //    {
            //        using (DataContext DB = new DataContext())
            //        {
            //            var finOrder = DB?.FinishedOrders?.SingleOrDefault(s => s.ID == ID);
            //            DB.FinishedOrders.Remove(finOrder);
            //            DB.SaveChanges();
            //            var orders = DB?.FinishedOrders?.ToList();
            //            gridControl1.DataSource = orders;
            //            MessageBox.Show("تمت العملية بنجاح");
            //        }
            //    }
            //    catch (Exception aa)
            //    {
            //        MessageBox.Show("حدث خطأ ");
            //    }

            //}
        }
    }
}