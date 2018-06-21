namespace Admin
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalaryColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddressColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.إَ = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(553, 365);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NameColumn,
            this.LastNameColumn,
            this.SalaryColumn,
            this.PhoneColumn,
            this.AddressColumn,
            this.ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // NameColumn
            // 
            this.NameColumn.Caption = "الاسم";
            this.NameColumn.FieldName = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Visible = true;
            this.NameColumn.VisibleIndex = 0;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Caption = "الكنية";
            this.LastNameColumn.FieldName = "LastName";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.Visible = true;
            this.LastNameColumn.VisibleIndex = 1;
            // 
            // SalaryColumn
            // 
            this.SalaryColumn.Caption = "الراتب";
            this.SalaryColumn.FieldName = "Salary";
            this.SalaryColumn.Name = "SalaryColumn";
            this.SalaryColumn.Visible = true;
            this.SalaryColumn.VisibleIndex = 2;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.Caption = "الرقم";
            this.PhoneColumn.FieldName = "Phone";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.Visible = true;
            this.PhoneColumn.VisibleIndex = 3;
            // 
            // AddressColumn
            // 
            this.AddressColumn.Caption = "العنوان";
            this.AddressColumn.FieldName = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.Visible = true;
            this.AddressColumn.VisibleIndex = 4;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.إَ,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(553, 52);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.إَ);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // إَ
            // 
            this.إَ.Caption = "إضافة ";
            this.إَ.Glyph = ((System.Drawing.Image)(resources.GetObject("إَ.Glyph")));
            this.إَ.Id = 1;
            this.إَ.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("إَ.LargeGlyph")));
            this.إَ.Name = "إَ";
            this.إَ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.إَ_ItemClick);
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
            // ID
            // 
            this.ID.Caption = "gridColumn1";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 365);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LastNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SalaryColumn;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneColumn;
        private DevExpress.XtraGrid.Columns.GridColumn AddressColumn;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem إَ;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
    }
}