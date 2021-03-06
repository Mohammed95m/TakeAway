﻿using System;
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
            //DataContext.ConnectionString = "Data Source=localhost;Initial Catalog=TakeAwayDB2;Integrated Security=True";
                using (DataContext DB = new DataContext())
                {
                    var orders = DB?.FinishedOrders?.ToList();
                    gridControl1.DataSource = orders;
                    countTxt.Caption = "عدد كل الطلبيات: " + orders.Count;
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
                        var finOrder = DB?.FinishedOrders?.SingleOrDefault(s => s.ID == ID);
                        DB.FinishedOrders.Remove(finOrder);
                        DB.SaveChanges();
                        var orders = DB?.FinishedOrders?.ToList();
                        gridControl1.DataSource = orders;
                        countTxt.Caption = "عدد كل الطلبيات: " + orders.Count;
                        MessageBox.Show("تمت العملية بنجاح");
                    }
                }
                catch (Exception aa)
                {
                    MessageBox.Show("حدث خطأ ");
                }

            }
        }

        private void إَ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                Guid ID = Guid.Parse(id);
                UpdateForms.OrdersUpdateXFrom frm = new UpdateForms.OrdersUpdateXFrom(ID);
                frm.FormClosed += (s, a) =>
                {
                    using (DataContext DB = new DataContext())
                    {
                        var orders = DB?.FinishedOrders?.ToList();
                        gridControl1.DataSource = orders;
                        countTxt.Caption = "عدد كل الطلبيات: " + orders.Count;
                    }
                };
                frm.ShowDialog();
            }
            catch (Exception)
            {


            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            Guid ID = Guid.Parse(id);
            try
            {
                using (DataContext DB = new DataContext())
                {
                    var finOrder = DB?.FinishedOrders?.SingleOrDefault(s => s.ID == ID);
                    DB.FinishedOrders.Remove(finOrder);
                    DB.SaveChanges();
                    var orders = DB?.FinishedOrders?.ToList();
                    gridControl1.DataSource = orders;
                    countTxt.Caption = "عدد كل الطلبيات: " + orders.Count;
                    MessageBox.Show("تمت العملية بنجاح");
                }
            }
            catch (Exception aa)
            {
                MessageBox.Show("حدث خطأ ");
            }
        }

        private void row_click(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //try
            //{
            //    var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            //    Guid ID = Guid.Parse(id);
            //    UpdateForms.OrdersUpdateXFrom frm = new UpdateForms.OrdersUpdateXFrom(ID);
            //    frm.FormClosed += (s, a) =>
            //    {
            //        using (DataContext DB = new DataContext())
            //        {
            //            var orders = DB?.FinishedOrders?.ToList();
            //            gridControl1.DataSource = orders;
            //        }
            //    };
            //    frm.ShowDialog();
            //}
            //catch (Exception v)
            //{

            //    MessageBox.Show("حدث خطأ");
            //}
        }
    }
}