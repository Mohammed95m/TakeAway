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

namespace TakeAway
{
  
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        class Combo
        {
            public Vehicle Text { get; set; }
            public int Value { get; set; }
        }
        public XtraForm1()
        {
            InitializeComponent();
         //   lau.DataController.AllowIEnumerableDetails = true;

            DataContext _context = new DataContext();
            var order = _context.Orders.ToList();
            var o = order.FirstOrDefault();
            VehicleLookUpEdit.DataSource = _context.Vehicles.ToList();
            VehicleLookUpEdit.ValueMember = "ID";
            VehicleLookUpEdit.DisplayMember = "Number";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number");
            VehicleLookUpEdit.Columns.Add(col);
            //var Vehicle = 
            //    (from c in _context.Vehicles
            //     select new Combo() { Text =c , Value = (int)c.Number }).ToList();

            //repositoryItemComboBox1.DisplayMember = "Text";
            //repositoryItemComboBox1.ValueMember = "Value";
            //foreach (var item in Sectors)
            //{
            //    comboBox1.Items.Add(item);
            //}
            VehicleLookUpEdit.EditValueChanged += (e, a) =>
            {

                MessageBox.Show(VehicleLookUpEdit.ValueMember);
            };
          gridControl1.DataSource = order;
            //cardView1.CustomCardStyle += (sender, e) =>
            //{
            //    var row = layoutView1.GetFocusedRow() as Order;
            //    Bitmap Bmp = new Bitmap(50, 50);
            //    using (Graphics gfx = Graphics.FromImage(Bmp))
            //    using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 0, 0)))
            //    {
            //        gfx.FillRectangle(brush, 0, 0, 50, 50);
            //    }
            //    e.Appearance.Image = Bmp;
            //};
            //};
            // layoutView1.ItemCustomize += (sender, e) =>
            //{
            //    var row = tileView1.GetFocusedRow() as Order;
            //    Bitmap Bmp = new Bitmap(50, 50);
            //    using (Graphics gfx = Graphics.FromImage(Bmp))
            //    using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 0, 0)))
            //    {
            //        gfx.FillRectangle(brush, 0, 0, 50, 50);
            //    }
            //    e.Item.BackgroundImage = Bmp;


            //};
        }
    }
}