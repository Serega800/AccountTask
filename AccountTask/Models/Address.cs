using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccountTask.Models
{
    public class Address : Account
    {
        public string Locality { get; set; }
        public string Street { get; set; }
        public int Building { get; set; }
        public string Case { get; set; }
        public int ApartmentNumber { get; set; }
        [Required] 
        public double Area { get; set; }
        [Required] 
        public int ResidentsCount { get; set; }
        public string GetAddress()
        {
            var address = new StringBuilder();

            PropertyInfo[] properties = typeof(Address).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (!string.IsNullOrEmpty(property.ToString()))
                {                    
                    address.AppendJoin(",", property.ToString());
                }
            }
            return address.ToString();
        }        
    }
}
