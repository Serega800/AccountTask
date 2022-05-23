using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AccountTask.Models
{
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public long Id { get; private set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public Address PropertyAddress { get; set; }
        [Required]
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; private set; }    }
    //public class Account
    //{
    //    public int Id { get; set; }
    //    public string Manufacturer { get; set; }
    //    public string Name { get; set; }
    //    public int Capacity { get; set; }
    //}
}
