using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Comicfy.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Емail адреса")]
        [Required(ErrorMessage = "Мора да ја внесете вашата email адреса")]
        public string EmailAddress { get; set; }
        [Display(Name = "Лозинка")]
        [Required(ErrorMessage = "Мора да ја внесете вашата лозинка")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
