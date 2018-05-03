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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.VehicleLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.DetailsColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EarnColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TimerColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VehicleColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Send = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SendButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleLookUpEdit
            // 
            this.VehicleLookUpEdit.AutoHeight = false;
            this.VehicleLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VehicleLookUpEdit.Name = "VehicleLookUpEdit";
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
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.VehicleLookUpEdit,
            this.repositoryItemComboBox1,
            this.SendButtonEdit});
            this.gridControl1.Size = new System.Drawing.Size(1117, 516);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Appearance.Card.BackColor = System.Drawing.Color.Red;
            this.cardView1.Appearance.Card.Options.UseBackColor = true;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DetailsColumn,
            this.LocationColumn,
            this.EarnColumn,
            this.TimerColumn,
            this.VehicleColumn,
            this.CustomerColumn,
            this.EmployeeColumn,
            this.StatusColumn,
            this.Send});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // DetailsColumn
            // 
            this.DetailsColumn.Caption = "DetailsColumn";
            this.DetailsColumn.FieldName = "Details";
            this.DetailsColumn.Name = "DetailsColumn";
            this.DetailsColumn.Visible = true;
            this.DetailsColumn.VisibleIndex = 0;
            // 
            // LocationColumn
            // 
            this.LocationColumn.Caption = "LocationColumn";
            this.LocationColumn.FieldName = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.Visible = true;
            this.LocationColumn.VisibleIndex = 1;
            // 
            // EarnColumn
            // 
            this.EarnColumn.Caption = "EarnColumn";
            this.EarnColumn.FieldName = "Earn";
            this.EarnColumn.Name = "EarnColumn";
            this.EarnColumn.Visible = true;
            this.EarnColumn.VisibleIndex = 2;
            // 
            // TimerColumn
            // 
            this.TimerColumn.Caption = "TimerColumn";
            this.TimerColumn.FieldName = "Timer";
            this.TimerColumn.Name = "TimerColumn";
            this.TimerColumn.Visible = true;
            this.TimerColumn.VisibleIndex = 3;
            // 
            // VehicleColumn
            // 
            this.VehicleColumn.Caption = "VehicleColumn";
            this.VehicleColumn.ColumnEdit = this.VehicleLookUpEdit;
            this.VehicleColumn.Name = "VehicleColumn";
            this.VehicleColumn.Visible = true;
            this.VehicleColumn.VisibleIndex = 4;
            // 
            // CustomerColumn
            // 
            this.CustomerColumn.Caption = "CustomerColumn";
            this.CustomerColumn.FieldName = "Customer";
            this.CustomerColumn.Name = "CustomerColumn";
            this.CustomerColumn.Visible = true;
            this.CustomerColumn.VisibleIndex = 5;
            // 
            // EmployeeColumn
            // 
            this.EmployeeColumn.Caption = "EmployeeColumn";
            this.EmployeeColumn.FieldName = "Employee";
            this.EmployeeColumn.Name = "EmployeeColumn";
            this.EmployeeColumn.Visible = true;
            this.EmployeeColumn.VisibleIndex = 6;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Caption = "Status";
            this.StatusColumn.FieldName = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.OptionsColumn.AllowEdit = false;
            this.StatusColumn.OptionsColumn.AllowFocus = false;
            this.StatusColumn.OptionsColumn.ReadOnly = true;
            this.StatusColumn.Visible = true;
            this.StatusColumn.VisibleIndex = 7;
            // 
            // Send
            // 
            this.Send.Caption = "Send";
            this.Send.ColumnEdit = this.SendButtonEdit;
            this.Send.Name = "Send";
            this.Send.Visible = true;
            this.Send.VisibleIndex = 8;
            // 
            // SendButtonEdit
            // 
            serializableAppearanceObject1.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject1.Image")));
            serializableAppearanceObject1.Options.UseImage = true;
            this.SendButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Send", -15, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("SendButtonEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.SendButtonEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.SendButtonEdit.HideSelection = false;
            this.SendButtonEdit.Name = "SendButtonEdit";
            this.SendButtonEdit.ReadOnly = true;
            this.SendButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
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
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit VehicleLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn DetailsColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LocationColumn;
        private DevExpress.XtraGrid.Columns.GridColumn EarnColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TimerColumn;
        private DevExpress.XtraGrid.Columns.GridColumn VehicleColumn;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerColumn;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn StatusColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn Send;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit SendButtonEdit;
    }
}