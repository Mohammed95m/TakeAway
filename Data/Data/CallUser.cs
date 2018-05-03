using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Data
{
    public class CallUser:Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid? EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

        [InverseProperty("CallUser")]
        public ICollection<FinishedOrder> FinishedCallOrders { get; set; }
    }
}
