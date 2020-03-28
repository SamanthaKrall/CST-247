using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Activity2Part1.Models
{
    public class UserModel
    {
        [Required]
        [DisplayName("Name")]
        [StringLength(20, MinimumLength =4)]
        [DefaultValue("")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Password")]
        [StringLength(20, MinimumLength =4)]
        [DefaultValue("")]
        public string Password { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public UserModel(string Name, string Password, string Email, string Phone)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.Phone = Phone;
        }

        public UserModel()
        {

        }
    }
}