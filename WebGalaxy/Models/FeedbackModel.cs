using System;
using System.ComponentModel.DataAnnotations;

namespace WebGalaxy.Models
{
    public class FeedbackModel
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "* Поле {0} должно быть установлено.")]
        [StringLength(20, ErrorMessage = "* Поле {0} должно быть больше {2} и меньше {1} символов.", MinimumLength = 4)]
        public String Name { get; set; }

        [Display(Name = "Компания")]
        [Required(ErrorMessage = "* Поле {0} должно быть установлено.")]
        [StringLength(10, ErrorMessage = "* Поле {0} должно быть больше {2} и меньше {1} символов.", MinimumLength = 4)]
        public String Company { get; set; }
        
        [Display(Name = "Отзыв")]
        [Required(ErrorMessage = "* Поле {0} должно быть установлено.")]
        [StringLength(500, ErrorMessage = "* Поле {0} должно быть больше {2} и меньше {1} символов.", MinimumLength = 10)]
        public String Message { get; set; }
    }
}