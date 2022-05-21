using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acftApplication.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
