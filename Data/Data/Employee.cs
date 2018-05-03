using System;
using System.Collections.Generic;
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


    }
}
