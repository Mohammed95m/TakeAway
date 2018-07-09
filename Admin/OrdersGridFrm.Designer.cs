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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(595, 367);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // OrdersGridFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 367);
            this.Controls.Add(this.gridControl1);
            this.Name = "OrdersGridFrm";
            this.Text = "OrdersGridFrm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

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
    }
}