using System;
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
using Data.Enums;

namespace SenderFrm
{
    public delegate void UpGrid();
    public partial class EditFrm : DevExpress.XtraEditors.XtraForm
    {
        public static event UpGrid UpdateGrid;
        Order MainOrder;
        public EditFrm(Guid OrderID)
        {
            InitializeComponent();
         using ( DataContext coco = new DataContext())
            {
                MainOrder = coco?.Orders?.SingleOrDefault(s => s.ID == OrderID);
                VehicleLookUpEdit.Properties.DataSource = coco?.Vehicles?.ToList();
                VehicleLookUpEdit.Properties.ValueMember = "ID";
                VehicleLookUpEdit.Properties.DisplayMember = "Number";
               EmployeeLookUpEdit.Properties.DataSource = coco?.Employees?.ToList();
               EmployeeLookUpEdit.Properties.ValueMember = "ID";
               EmployeeLookUpEdit.Properties.DisplayMember = "Name";
            }
        }

        private void EditFrm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VehicleLookUpEdit.EditValue.ToString());
            using (DataContext coco = new DataContext())
            {
                MainOrder.VehicleID = (Guid)VehicleLookUpEdit.EditValue;
                MainOrder.EmployeeID = (Guid)EmployeeLookUpEdit.EditValue;
                MainOrder.Timer = int.Parse(string.IsNullOrEmpty(textEdit1.Text) ? "0" : textEdit1.Text);
                MainOrder.Status = (int)Status.InProgress;
                MainOrder.StartTime = DateTime.Now;
                coco.SaveChanges();
                UpdateGrid();
            }
            }
    }
}