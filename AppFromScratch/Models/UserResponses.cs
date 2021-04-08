using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AppFromScratch.Models
{
    public class UserResponses
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        public string Phone { get; set; }
        public bool Affiliation { get; set; }
        [Required(ErrorMessage = "Please enter your Age.")]
        public string Age { get; set; }

    }
}