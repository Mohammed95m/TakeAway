using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway
{
    public class Vehicle:Base
    {
        public Guid? VehicleTypeID { get; set; }
        [ForeignKey("VehicleTypeID")]
        public VehicleType VehicleType { get; set; }
        public int? Number { get; set; }
        public double? Longtude { get; set; }
        public double?   Latitude { get; set; }
        public bool IsAvailable { get; set; }
        [InverseProperty("Vehicle")]
        public ICollection<FinishedOrder> FinishedOrders { get; set; }

    }
}