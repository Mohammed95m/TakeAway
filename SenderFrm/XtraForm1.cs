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
using System.Drawing.Drawing2D;
using Data.Enums;
using Data.Data;
using ChatApp.Forms;

namespace TakeAway
{
  
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        class Combo
        {
            public Vehicle Text { get; set; }
            public int Value { get; set; }
        }
        List<Order> UpData = new List<Order>();
        public SenderUser SenderUser { get; set; }
        public XtraForm1(SenderUser user)
        {
            InitializeComponent();
            //   lau.DataController.AllowIEnumerableDetails = true;
            SenderUser = user;
               DataContext _context = new DataContext();
            var order = _context.Orders.Where(S=>S.Status==(int)Status.Created|| S.Status == (int)Status.Seen).ToList();
            var o = order.FirstOrDefault();
            var c= _context?.Vehicles?.ToList();
            VehicleLookUpEdit.DataSource = c;
            VehicleLookUpEdit.ValueMember = "Vehicle";
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
            SendButtonEdit.Click += (Sender, e) => {

                try
                {
                //   var v= VehicleLookUpEdit.value as Vehicle;
                    var row = cardView1.GetFocusedRow() as Order;
                    MessageBox.Show(row.Details);

                }
                catch (Exception ee)
                {


                }


            };
            //cardView1.CustomDrawFilterPanel += (a, b) => {
            //    Color color1 = Color.FromArgb(40, 170, 225);
            //    Color color2 = Color.FromArgb(35, 80, 160);
            //    Brush brush = b.Cache.GetGradientBrush(b.Bounds, color1, color2, LinearGradientMode.Horizontal);
            //    b.Appearance.Options.UseBackColor = true;
            //    b.Appearance.Options.UseBorderColor = true;
            //    b.Appearance.BackColor = Color.Red;
            //    b.Appearance.BackColor2 = Color.Red;
            //    b.Appearance.BorderColor = Color.Red;
            //    b.Appearance.ForeColor = Color.Red;
            //    b.Cache.FillRectangle(brush, b.Bounds);
            //    b.Appearance.DrawString(b.Cache, "", b.Bounds);


            //};
            //cardView1.CustomDrawCardCaption += (x, y) =>
            //{
            //    y.Appearance.Options.UseBackColor = true;
            //    y.Appearance.Options.UseBorderColor = true;
            //    y.Appearance.BackColor = Color.Red;
            //    y.Appearance.BackColor2 = Color.Red;
            //    y.Appearance.BorderColor = Color.Red;
            //};

            cardView1.CustomDrawEmptyForeground += (sender, e) => { };
            cardView1.CustomDrawCardField += (sender, e) => {
                if (e.Column.FieldName != "Status") return;
                // The brush to fill the cell background.
                Color color1 = Color.FromArgb(40, 170, 225);
                Color color2 = Color.FromArgb(35, 80, 160);
                Brush brush = e.Cache.GetGradientBrush(e.Bounds, color1, color2, LinearGradientMode.Horizontal);
                e.Appearance.ForeColor = Color.White;
                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Bold);
                e.Cache.FillRectangle(brush, e.Bounds);
                e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds);
                // Prevent default painting.
                e.Handled = true;


            };
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
            // };
            //        layoutView1.ItemCustomize += (sender, e) =>
            //                {
            //                    var row = tileView1.GetFocusedRow() as Order;
            //        Bitmap Bmp = new Bitmap(50, 50);
            //                    using (Graphics gfx = Graphics.FromImage(Bmp))
            //                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 0, 0)))
            //                    {
            //                        gfx.FillRectangle(brush, 0, 0, 50, 50);
            //                    }
            //e.Item.BackgroundImage = Bmp;


            //                };
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(1000);
                    DataContext DB = new DataContext();
                    var ISNewdata = DB?.Orders?.Where(S => S.Status == 0).Any();

                    if ((bool)ISNewdata)
                    {
                         UpData = DB?.Orders?.Where(S => S.Status == (int)Status.Created||S.Status==(int)Status.Seen).ToList();
                        foreach (var item in UpData)
                        {
                            item.Status = (int)Status.Seen;
                        }
                        //gridControl1.DataSource = UpData;
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { gridControl1.DataSource = UpData; });
                        DB.SaveChangesAsync();
                    }

                     
                    //backgroundWorker1.RunWorkerAsync();
                }
            }


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //TestDataContext DB = new TestDataContext();
            //var data = DB?.Tests?.Where(S => S.Status > 0);
            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { gridControl1.DataSource = UpData; });
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SenderUser = null;
            frmLogIn fofo = new frmLogIn();
            fofo.Show();
          
        }
    }
}