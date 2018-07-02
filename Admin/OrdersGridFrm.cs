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
    public partial class OrdersGridFrm : DevExpress.XtraEditors.XtraForm
    {
        public OrdersGridFrm()
        {
            InitializeComponent();
            DataContext.ConnectionString = "Data Source=localhost;Initial Catalog=TakeAwayDB2;Integrated Security=True";
            using (DataContext DB = new DataContext())
            {
                var orders = DB?.FinishedOrders?.ToList();
                gridControl1.DataSource = orders;
            }
            }
    }
}