using CheeseMVC.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddUserViewModel
    {
        [Display(Name ="Email Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="User Name")]
        [Required]
        [Range(6,25)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(25)]
        [MinLength(6)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public void Add()
        {
            User user = new User { Email = this.Email, Password = this.Password, UserName = this.UserName };
            UserData.Add(user);
        }
    }
}
