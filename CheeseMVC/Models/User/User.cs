using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models.User
{
    public class User
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [MaxLength(25)]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [MaxLength(25)]
        public string Password { get; set; }
    }
}
