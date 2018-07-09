namespace Admin
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.SenderUserbtn = new DevExpress.XtraNavBar.NavBarItem();
            this.CallUserbtn = new DevExpress.XtraNavBar.NavBarItem();
            this.AdminUserbtn = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.SenderUserbtn,
            this.CallUserbtn,
            this.AdminUserbtn,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4});
            this.navBarControl1.Location = new System.Drawing.Point(456, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 197;
            this.navBarControl1.Size = new System.Drawing.Size(197, 412);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Caption = "الإضافة ";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.SenderUserbtn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.CallUserbtn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.AdminUserbtn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.navBarItem1.Appearance.Options.UseFont = true;
            this.navBarItem1.Caption = "الموظفين";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // SenderUserbtn
            // 
            this.SenderUserbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SenderUserbtn.Appearance.Options.UseFont = true;
            this.SenderUserbtn.Caption = "مستخدمي الإرسال";
            this.SenderUserbtn.Name = "SenderUserbtn";
            this.SenderUserbtn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.SenderUserbtn_LinkClicked);
            // 
            // CallUserbtn
            // 
            this.CallUserbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CallUserbtn.Appearance.Options.UseFont = true;
            this.CallUserbtn.Caption = "مستخدمي الاتصال";
            this.CallUserbtn.Name = "CallUserbtn";
            this.CallUserbtn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.CallUserbtn_LinkClicked);
            // 
            // AdminUserbtn
            // 
            this.AdminUserbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AdminUserbtn.Appearance.Options.UseFont = true;
            this.AdminUserbtn.Caption = "المدير";
            this.AdminUserbtn.Name = "AdminUserbtn";
            this.AdminUserbtn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.AdminUserbtn_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.navBarItem4.Appearance.Options.UseFont = true;
            this.navBarItem4.Caption = "الدراجات";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.Caption = "التحليل";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.navBarItem2.Appearance.Options.UseFont = true;
            this.navBarItem2.Caption = "الأرباح و عدد الطلبات";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.navBarItem3.Appearance.Options.UseFont = true;
            this.navBarItem3.Caption = "كل الطلبيات";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 412);
            this.Controls.Add(this.navBarControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "الإدارة";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem SenderUserbtn;
        private DevExpress.XtraNavBar.NavBarItem CallUserbtn;
        private DevExpress.XtraNavBar.NavBarItem AdminUserbtn;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
    }
}

