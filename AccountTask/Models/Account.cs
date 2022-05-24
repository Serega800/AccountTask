using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountTask.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Locality { get; set; }
        public int ApartmentNumber { get; set; }
    }
}
