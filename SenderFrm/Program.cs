using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using TakeAway;
using ChatApp.Forms;

namespace SenderFrm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            MessageBoxManager.Yes = "تم التوصيل";
            MessageBoxManager.No = "تعديل  ";
            MessageBoxManager.Register();
            Application.Run(new frmLogIn());
        }
    }
}
