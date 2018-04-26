using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TakeAway
{
   public class Customer: Base
    {

        public string Name { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }
        [InverseProperty("Customer")]
        public ICollection<FinishedOrder> FinishedOrders { get; set; }
    }
}
