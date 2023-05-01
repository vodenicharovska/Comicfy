using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Comicfy.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Име и презиме")]
        [Required(ErrorMessage = "Мора да внесете ваше име и презиме")]
        public string FullName { get; set; }

        [Display(Name = "Емail адреса")]
        [Required(ErrorMessage = "Мора да ја внесете вашата email адреса")]
        public string EmailAddress { get; set; }

        [Display(Name = "Лозинка")]
        [Required(ErrorMessage = "Мора да ја внесете вашата лозинка")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Потврди лозинка")]
        [Required(ErrorMessage = "Мора да ја внесете вашата лозинка")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Лозинките не се совпаѓаат")]
        public string ConfirmPassword { get; set; }
    }
}
