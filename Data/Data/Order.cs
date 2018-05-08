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

        public string Location { get; set; }

        public int Status { get; set; }

        public decimal? Earn { get; set; }

        public int? Timer { get; set; }

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
        public Guid? EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

        [NotMapped]
        public string CustomerName /*{ get; set; }*/
        {
            get
            {
                using (DataContext _context = new DataContext())
                {
                    return _context.Customers.SingleOrDefault(s => s.ID == CustomerID).Name;

                }
            }
        }
        [NotMapped]
        public string EmployeeName /*{ get; set; }*/
        {
            get
            {
                using (DataContext _context = new DataContext())
                {
                    return _context.Employees.SingleOrDefault(s => s.ID == EmployeeID).Name;

                }
            }
        }
        public Guid? CallUserID { get; set; }
        [ForeignKey("CallUserID")]
        public CallUser CallUser { get; set; }

        public Guid? SenderUserID { get; set; }
        [ForeignKey("SenderUserID")]
        public SenderUser SenderUser { get; set; }


    }
}
