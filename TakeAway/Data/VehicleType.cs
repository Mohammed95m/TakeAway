using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TakeAway
{
    public class VehicleType
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public string type { get; set; }
        [InverseProperty("VehicleType")]
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
