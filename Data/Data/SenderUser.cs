using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
   public class SenderUser :Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid? EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

        [InverseProperty("SenderUser")]
        public ICollection<FinishedOrder> FinishedOrders { get; set; }
    }
}
