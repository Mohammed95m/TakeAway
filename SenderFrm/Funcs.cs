using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.Classes.MyFunction
{
    class Funcs
    {
        /// <summary>
        /// Validate Email isn't Contain any Symbol
        /// </summary>
        /// <param name="e"></param>
        public static void validateEmail(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '*':
                case '$':
                case '%':
                case '/':

                case '!':
                case '#':
                case '^':
                case '&':
                case '(':
                case ')':
                case '+':
                case '[':
                case ']':
                case '{':
                case '}':
                case (char)Keys.Space:

                    MessageBox.Show("Please Don't Use Any Symbol", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; break;
                    ;
                default:
                    e.Handled = false; break;
                    {
                    }
            }
        }
        public static void checkSpace(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("Please Don't Use Space", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        public static void numberOnly(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '.':
                case (char)Keys.Back:
                    e.Handled = false; break;

                    ;
                default:
                    MessageBox.Show("Please Use Numbers Only", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; break;
                    {
                    }
            }
        }


        public static string selectPathAvatar()
        {
            string targetpath;
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            of.Filter = "PNG IM|*.png|JPG Images|*.jpg";
            DialogResult reso = of.ShowDialog();
            if (reso == DialogResult.OK)
            {
                targetpath = Path.GetFullPath(of.FileName);
                return targetpath;
            }
            return null;
        }
        public static bool confirmPassword(string p ,string confirm)
        {
            if (confirm != p)
            {
                MessageBox.Show("Password does not match");
                return false;
            }
            return true;
        }
    }
}

