using System;
using System.ComponentModel.DataAnnotations;

namespace WebGalaxy.Models
{
    public class BriefModel
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "* Заполните пожалуйста поле.")]
        [StringLength(20, ErrorMessage = "* Поле {0} должно быть больше {2} и меньше {1} символов.", MinimumLength = 4)]
        public String Name { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "* Заполните пожалуйста поле.")]
        [StringLength(20, ErrorMessage = "* Поле {0} должно быть больше {2} и меньше {1} символов.", MinimumLength = 4)]
        public String Phone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "* Заполните пожалуйста поле.")]
        [StringLength(30, ErrorMessage = "* Поле {0} должно быть больше {2} и меньше {1} символов.", MinimumLength = 4)]
        [EmailAddress(ErrorMessage = "Не правильный email")]
        public String Email { get; set; }

        //[Display(Name = "Отзыв")]
        //[Required(ErrorMessage = "* Заполните пожалуйста поле.")]
        //[StringLength(500, ErrorMessage = "* Поле {0} должно быть больше {2} и меньше {1} символов.", MinimumLength = 10)]
        public String Message { get; set; }

        [Display(Name = "О компании")]
        [Required(ErrorMessage = "* Заполните пожалуйста поле.")]
        [StringLength(500, ErrorMessage = "* Поле {0} должно быть больше {2} и меньше {1} символов.", MinimumLength = 10)]
        public String AboutCompany { get; set; }

        [Display(Name = "Примеры сайтов")]
        [Required(ErrorMessage = "* Заполните пожалуйста поле.")]
        [StringLength(500, ErrorMessage = "* Поле {0} должно быть больше {2} и меньше {1} символов.", MinimumLength = 10)]
        public String SiteExamples { get; set; }

        [Display(Name = "Список языков")]
        [Required(ErrorMessage = "* Заполните пожалуйста поле.")]
        public String Languages { get; set; }

        [Display(Name = "Сроки реализации")]
        [Required(ErrorMessage = "* Заполните пожалуйста поле.")]
        public String RealizationDates { get; set; }

        public Boolean Promo { get; set; }
        public Boolean Corporative { get; set; }
        public Boolean Shop { get; set; }
        public Boolean Blog { get; set; }
        public Boolean Cutaway { get; set; }
    }
}