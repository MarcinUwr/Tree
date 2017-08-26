using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Tree.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name="Username")]
        public string Username { get; set; }

        [Required]

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Wprowadzone hasła muszą być identyczne!"),MinLength(6, ErrorMessage = "Hasło musi składać się z conajmniej 6 znaków!")]
        public string ConfirmPassword { get; set; }
    }
}