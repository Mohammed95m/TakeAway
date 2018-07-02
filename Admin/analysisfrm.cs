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
    public partial class analysisfrm : DevExpress.XtraEditors.XtraForm
    {
        public analysisfrm()
        {
            InitializeComponent();
        }

        private void AnalysisBtn_Click(object sender, EventArgs e)
        {
         //   DataContext.ConnectionString = "Data Source=localhost;Initial Catalog=TakeAwayDB2;Integrated Security=True";
            using (DataContext DB = new DataContext())
            {
                List<FinishedOrder> Orders;
                if (OnlyDayChx.Checked == true)
                {
                    Orders  = DB?.FinishedOrders?.Include("Vehicle")?.Include("Employee")?.Where(s => s.Date.Day==frmoDate.DateTime.Day&&s.Date.Month==frmoDate.DateTime.Month
                    &&s.Date.Year==frmoDate.DateTime.Year).ToList();
                }
                else
                {
                    Orders = DB?.FinishedOrders?.Include("Vehicle")?.Include("Employee")?.Where(s => s.Date >= frmoDate.DateTime && s.Date <= ToDate.DateTime).ToList();
                }
                var earn = Orders.Sum(s => s.Earn);
                var Count = Orders.Count();
                var ordersEMP = Orders.GroupBy(s => s.Employee.Name,(key,value)=>new {الموظف=key,عدد_الطلبيات=value.Count()});
                var ordersVic = Orders.GroupBy(s => s.Vehicle.Number, (key, value) => new { الدراجة = key, عدد_الطلبيات = value.Count() });
                EmployeeGrid.DataSource = ordersEMP;
                BikeGrid.DataSource = ordersVic;
                EarnLbl.Text = earn.ToString();
                NumOrderLbl.Text = Count.ToString();

            }
                
        }

        private void OnlyDayChx_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlyDayChx.Checked == true)
                ToDate.Enabled = false;
            else
            {
                ToDate.Enabled = true;
            }
        }
    }
}