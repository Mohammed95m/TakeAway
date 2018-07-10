using Data.Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        string connection = "";
        public Form1(string con )
        {
            InitializeComponent();
            connection = con;
        }
        internal void ShowChild(DevExpress.XtraEditors.XtraForm frm)
        {
            string[] allowDuplicatedForm = new string[] { "frmClient" };
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in this.xtraTabbedMdiManager1.Pages)
            {
                XtraForm opendFrm = page.MdiChild as XtraForm;
                if (allowDuplicatedForm.Contains(frm.Name))
                {
                    if (opendFrm.Text == frm.Text)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        frm.Dispose();
                        return;
                    }
                }
                else
                {
                    if (opendFrm.Name == frm.Name)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        frm.Dispose();
                        return;
                    }
                }
            }
            frm.MdiParent = this;
            frm.Show();
        }
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowChild(new Employee(connection));
        }

        private void SenderUserbtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowChild(new SenderUserfrm(connection));
        }


        private void AdminUserbtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowChild(new AdminUserfrm(connection));
        }

        private void CallUserbtn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowChild(new CallUserfrm(connection));
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowChild(new analysisfrm());
           
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowChild(new OrdersGridFrm());
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowChild(new BikeFrm(connection));
           
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShowChild(new CustomerGrid());

        }
    }
}
