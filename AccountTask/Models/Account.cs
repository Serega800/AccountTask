﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountTask.Models
{    
    public class Account
    {
        public int Id { get; set; }

        [Display(Name ="ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Населённый пункт")]
        public string Locality { get; set; }
        [Display(Name = "Квартира")]
        public int ApartmentNumber { get; set; }
    }
}
