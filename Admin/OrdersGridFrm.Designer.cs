namespace Admin
{
    partial class OrdersGridFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersGridFrm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DetailsColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerNameColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EarnColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeNaameColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CallUserNameColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SenderUserNameColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VehicleNumberColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartTimeColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndTimeColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.countTxt = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(571, 294);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DetailsColumn1,
            this.CustomerNameColumn1,
            this.EarnColumn1,
            this.EmployeeNaameColumn1,
            this.CallUserNameColumn1,
            this.SenderUserNameColumn1,
            this.VehicleNumberColumn1,
            this.DateColumn1,
            this.StartTimeColumn1,
            this.EndTimeColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.row_click);
            // 
            // DetailsColumn1
            // 
            this.DetailsColumn1.Caption = "تفاصيل الطلب";
            this.DetailsColumn1.FieldName = "Details";
            this.DetailsColumn1.Name = "DetailsColumn1";
            this.DetailsColumn1.Visible = true;
            this.DetailsColumn1.VisibleIndex = 3;
            // 
            // CustomerNameColumn1
            // 
            this.CustomerNameColumn1.Caption = "الزبون";
            this.CustomerNameColumn1.FieldName = "CustomerName";
            this.CustomerNameColumn1.Name = "CustomerNameColumn1";
            this.CustomerNameColumn1.Visible = true;
            this.CustomerNameColumn1.VisibleIndex = 1;
            // 
            // EarnColumn1
            // 
            this.EarnColumn1.Caption = "الربح";
            this.EarnColumn1.FieldName = "Earn";
            this.EarnColumn1.Name = "EarnColumn1";
            this.EarnColumn1.Visible = true;
            this.EarnColumn1.VisibleIndex = 4;
            // 
            // EmployeeNaameColumn1
            // 
            this.EmployeeNaameColumn1.Caption = "الموظف";
            this.EmployeeNaameColumn1.FieldName = "EmployeeNaame";
            this.EmployeeNaameColumn1.Name = "EmployeeNaameColumn1";
            this.EmployeeNaameColumn1.Visible = true;
            this.EmployeeNaameColumn1.VisibleIndex = 5;
            // 
            // CallUserNameColumn1
            // 
            this.CallUserNameColumn1.Caption = "موظف الاتصال";
            this.CallUserNameColumn1.FieldName = "CallUserName";
            this.CallUserNameColumn1.Name = "CallUserNameColumn1";
            this.CallUserNameColumn1.Visible = true;
            this.CallUserNameColumn1.VisibleIndex = 0;
            // 
            // SenderUserNameColumn1
            // 
            this.SenderUserNameColumn1.Caption = "موظف الإرسال";
            this.SenderUserNameColumn1.FieldName = "SenderUserName";
            this.SenderUserNameColumn1.Name = "SenderUserNameColumn1";
            this.SenderUserNameColumn1.Visible = true;
            this.SenderUserNameColumn1.VisibleIndex = 7;
            // 
            // VehicleNumberColumn1
            // 
            this.VehicleNumberColumn1.Caption = "الدراجة";
            this.VehicleNumberColumn1.FieldName = "VehicleNumber";
            this.VehicleNumberColumn1.Name = "VehicleNumberColumn1";
            this.VehicleNumberColumn1.Visible = true;
            this.VehicleNumberColumn1.VisibleIndex = 9;
            // 
            // DateColumn1
            // 
            this.DateColumn1.Caption = "التاريخ";
            this.DateColumn1.FieldName = "Date";
            this.DateColumn1.Name = "DateColumn1";
            this.DateColumn1.Visible = true;
            this.DateColumn1.VisibleIndex = 2;
            // 
            // StartTimeColumn1
            // 
            this.StartTimeColumn1.Caption = "تاريخ البدء";
            this.StartTimeColumn1.FieldName = "StartTime";
            this.StartTimeColumn1.Name = "StartTimeColumn1";
            this.StartTimeColumn1.Visible = true;
            this.StartTimeColumn1.VisibleIndex = 8;
            // 
            // EndTimeColumn1
            // 
            this.EndTimeColumn1.Caption = "وقت الانتهاء";
            this.EndTimeColumn1.FieldName = "EndTime";
            this.EndTimeColumn1.Name = "EndTimeColumn1";
            this.EndTimeColumn1.Visible = true;
            this.EndTimeColumn1.VisibleIndex = 6;
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.countTxt});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 5;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowCategoryInCaption = false;
            this.ribbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.Size = new System.Drawing.Size(595, 49);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "تعديل";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "حذف";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.countTxt);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 49);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(595, 318);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(595, 318);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(575, 298);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // countTxt
            // 
            this.countTxt.Caption = "عدد كل الطلبيات: 50";
            this.countTxt.Id = 4;
            this.countTxt.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.countTxt.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.countTxt.ItemAppearance.Normal.Options.UseFont = true;
            this.countTxt.ItemAppearance.Normal.Options.UseForeColor = true;
            this.countTxt.Name = "countTxt";
            this.countTxt.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // OrdersGridFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 367);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl2);
            this.Name = "OrdersGridFrm";
            this.Text = "كل العمليات";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn DetailsColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerNameColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn EarnColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeNaameColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn CallUserNameColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn SenderUserNameColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn VehicleNumberColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn DateColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn StartTimeColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn EndTimeColumn1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarStaticItem countTxt;
    }
}