using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.Data;

namespace TakeAway
{
    public class FinishedOrder :Base
    {
        public string Details { get; set; }

        public string Location { get; set; }
        public decimal? Earn { get; set; }

        public double? Longtude { get; set; }
        public double? Latitude { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public Guid? VehicleID { get; set; }
        [ForeignKey("VehicleID")]
        public Vehicle Vehicle { get; set; }
        public int? VehicleNumber { get { return Vehicle.Number; } }

        public Guid CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        public string CustomerName { get; set; }

        public Guid? EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        public string EmployeeNaame { get; set; }
        public Guid? CallUserID { get; set; }
        [ForeignKey("CallUserID")]
        public CallUser CallUser { get; set; }

        public Guid? SenderUserID { get; set; }
        [ForeignKey("SenderUserID")]
        public SenderUser SenderUser { get; set; }

        public string CallUserName { get; set; }
        public string SenderUserName { get; set; }
    }
}
