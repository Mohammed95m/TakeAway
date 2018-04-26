namespace TakeAway
{
    partial class XtraForm1
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
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.VehicleColumn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.VehicleLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.StatusColumn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.DetailsColumn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.LocationColumn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.EarnColumn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.TimerColumn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.StartTimeColumn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.EndTimeColmn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.CustomerIDColumn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.EmployeeColumn = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleColumn
            // 
            this.VehicleColumn.Caption = "VehicleColumn";
            this.VehicleColumn.ColumnEdit = this.VehicleLookUpEdit;
            this.VehicleColumn.FieldName = "VehicleID";
            this.VehicleColumn.Name = "VehicleColumn";
            this.VehicleColumn.Visible = true;
            this.VehicleColumn.VisibleIndex = 6;
            // 
            // VehicleLookUpEdit
            // 
            this.VehicleLookUpEdit.AutoHeight = false;
            this.VehicleLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VehicleLookUpEdit.Name = "VehicleLookUpEdit";
            // 
            // StatusColumn
            // 
            this.StatusColumn.Caption = "Status";
            this.StatusColumn.FieldName = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Visible = true;
            this.StatusColumn.VisibleIndex = 10;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1123, 544);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1117, 516);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.VehicleLookUpEdit,
            this.repositoryItemComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(1117, 516);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DetailsColumn,
            this.LocationColumn,
            this.EarnColumn,
            this.TimerColumn,
            this.StartTimeColumn,
            this.EndTimeColmn,
            this.VehicleColumn,
            this.CustomerIDColumn,
            this.EmployeeColumn,
            this.tileViewColumn1,
            this.StatusColumn});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            tileViewItemElement1.Column = this.VehicleColumn;
            tileViewItemElement1.Text = "VehicleColumn";
            tileViewItemElement2.Column = this.StatusColumn;
            tileViewItemElement2.Text = "StatusColumn";
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            // 
            // DetailsColumn
            // 
            this.DetailsColumn.Caption = "gridColumn1";
            this.DetailsColumn.FieldName = "Details";
            this.DetailsColumn.Name = "DetailsColumn";
            this.DetailsColumn.Visible = true;
            this.DetailsColumn.VisibleIndex = 0;
            // 
            // LocationColumn
            // 
            this.LocationColumn.Caption = "gridColumn1";
            this.LocationColumn.FieldName = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.Visible = true;
            this.LocationColumn.VisibleIndex = 1;
            // 
            // EarnColumn
            // 
            this.EarnColumn.Caption = "gridColumn1";
            this.EarnColumn.FieldName = "Earn";
            this.EarnColumn.Name = "EarnColumn";
            this.EarnColumn.Visible = true;
            this.EarnColumn.VisibleIndex = 2;
            // 
            // TimerColumn
            // 
            this.TimerColumn.Caption = "gridColumn1";
            this.TimerColumn.FieldName = "Timer";
            this.TimerColumn.Name = "TimerColumn";
            this.TimerColumn.Visible = true;
            this.TimerColumn.VisibleIndex = 3;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.Caption = "gridColumn1";
            this.StartTimeColumn.FieldName = "StartTime";
            this.StartTimeColumn.Name = "StartTimeColumn";
            this.StartTimeColumn.Visible = true;
            this.StartTimeColumn.VisibleIndex = 4;
            // 
            // EndTimeColmn
            // 
            this.EndTimeColmn.Caption = "gridColumn1";
            this.EndTimeColmn.FieldName = "EndTime";
            this.EndTimeColmn.Name = "EndTimeColmn";
            this.EndTimeColmn.Visible = true;
            this.EndTimeColmn.VisibleIndex = 5;
            // 
            // CustomerIDColumn
            // 
            this.CustomerIDColumn.Caption = "gridColumn1";
            this.CustomerIDColumn.FieldName = "Customer";
            this.CustomerIDColumn.Name = "CustomerIDColumn";
            this.CustomerIDColumn.Visible = true;
            this.CustomerIDColumn.VisibleIndex = 7;
            // 
            // EmployeeColumn
            // 
            this.EmployeeColumn.Caption = "tileViewColumn1";
            this.EmployeeColumn.FieldName = "Employee";
            this.EmployeeColumn.Name = "EmployeeColumn";
            this.EmployeeColumn.Visible = true;
            this.EmployeeColumn.VisibleIndex = 8;
            // 
            // tileViewColumn1
            // 
            this.tileViewColumn1.Caption = "tileViewColumn1";
            this.tileViewColumn1.Name = "tileViewColumn1";
            this.tileViewColumn1.Visible = true;
            this.tileViewColumn1.VisibleIndex = 9;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1117, 516);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 544);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.VehicleLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn DetailsColumn;
        private DevExpress.XtraGrid.Columns.TileViewColumn LocationColumn;
        private DevExpress.XtraGrid.Columns.TileViewColumn EarnColumn;
        private DevExpress.XtraGrid.Columns.TileViewColumn TimerColumn;
        private DevExpress.XtraGrid.Columns.TileViewColumn StartTimeColumn;
        private DevExpress.XtraGrid.Columns.TileViewColumn EndTimeColmn;
        private DevExpress.XtraGrid.Columns.TileViewColumn VehicleColumn;
        private DevExpress.XtraGrid.Columns.TileViewColumn CustomerIDColumn;
        private DevExpress.XtraGrid.Columns.TileViewColumn EmployeeColumn;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit VehicleLookUpEdit;
        private DevExpress.XtraGrid.Columns.TileViewColumn StatusColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}