using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data.Data;

namespace Data.Data
{
    public class Order: Base
    {
        public TimeSpan Time { get; set; }
        public string Details { get; set; }
        public string CustomerPhone { get; set; }
        public string Location { get; set; }

        public int Status { get; set; }
        public int? Updated { get; set; } = 0;

        public decimal? Earn { get; set; }

        public bool WithTimer { get; set; }

        public int? Timer { get; set; }
        public TimeSpan? BikeTime { get; set; }

        public double? Longtude { get; set; }

        public double? Latitude { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public Guid? VehicleID { get; set; }
        [ForeignKey("VehicleID")]
        public Vehicle Vehicle { get; set; }

        public Guid CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        public string CustomerName { get; set; }
        public Guid? EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

        public Guid? CallUserID { get; set; }
        [ForeignKey("CallUserID")]
        public CallUser CallUser { get; set; }

        public Guid? SenderUserID { get; set; }
        [ForeignKey("SenderUserID")]
        public SenderUser SenderUser { get; set; }


    }
}
