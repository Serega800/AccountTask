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

        [Display(Name = "Номер Лицевого Счёта")]
        public string AccountId         
        {
            get => Id.ToString().PadLeft(10, '0');                           
        }        

        [Display(Name ="ФИО собственника")]
        public string FullName { get; set; }
        [Display(Name = "Населённый пункт")]
        public string Locality { get; set; }
        [Display(Name = "Улица")]
        public string Street { get; set; }
        [Display(Name = "Дом")]
        public string Building { get; set; }
        [Display(Name = "Квартира")]
        public int ApartmentNumber { get; set; }
    }
}
