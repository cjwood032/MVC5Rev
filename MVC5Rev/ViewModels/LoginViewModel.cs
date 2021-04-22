using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVC5Rev.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Name can't be blank")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }
    }
}