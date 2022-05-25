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
        public int Id { get; init; }

        [Display(Name = "ИД ЛС")]
        public string AccountId
        {
            get => Id.ToString().PadLeft(10, '0');
        }

        [Display(Name = "ФИО собственника")]
        [Required(ErrorMessage = "Необходимо указать Фамилию Имя Отчество")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Длина строки должна составлять минимум 3 символа, максимум 100 символов.")]
        public string FullName { get; set; }
        [Display(Name = "Город")]
        [Required(ErrorMessage = "Необходимо указать город")]
        public string Locality { get; set; }

        [Display(Name = "Улица")]
        [Required(ErrorMessage = "Необходимо указать улицу")]
        public string Street { get; set; }
        [Display(Name = "Дом")]
        //[RegularExpression(@"/[0-9]{1,3}[0-9абвгде\/]{1,4}/i$", ErrorMessage = "Номер дома не может быть отрицательным, может содержать копус или литеру.")]
        [Required(ErrorMessage = "Необходимо указать номер дома")]
        public string Building { get; set; }
        [Display(Name = "Номер квартиры")]
        [Required(ErrorMessage = "Необходимо указать номер квартиры")]
        public int ApartmentNumber { get; set; }
        [Display(Name = "Площадь, м\xB2")]
        [Required(ErrorMessage = "Необходимо указать площадь, в м\xB2.")]
        [RegularExpression(@"^[1-9]+(\.[0-9]{1,2})$", ErrorMessage = "Число от 1 до 1000 с сотыми долями. Разделитель - точка.")]

        public string Area { get; set; }
        [Display(Name = "Количество проживающих")]
        [Range(0,100,ErrorMessage ="Количество проживающих должно быть больше нуля и не должно превышать сто человек.")]
        [Required(ErrorMessage = "Необходимо указать количество проживающих")]
        public int ResidentsNumber { get; set; }

        [Display(Name = "Дата Открытия")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTimeOffset OpeningDate { get; init; }
        
        [Display(Name = "Дата Закрытия")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTimeOffset? ClosingDate { get; set; }
        public int IsActive { get; set; }

        [NotMapped]
        [Display(Name = "Адрес")]
        public string Address
        {
            get => $"г.{Locality}, ул.{Street}, дом{Building}, кв{ApartmentNumber}";
        }

        public Account()
        {
            IsActive = 1;
            this.OpeningDate = DateTime.Now.Date;
        }
    }
}
