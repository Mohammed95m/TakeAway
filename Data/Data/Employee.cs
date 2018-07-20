using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Employee :Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public decimal? Salary { get; set; }
        public string Address { get; set; }
        public bool? IsBike { get; set; }
        public Guid? VehicleID { get; set; }
        [ForeignKey("VehicleID")]
        public Vehicle Vehicle { get; set; }


    }
}
