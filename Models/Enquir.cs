using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace sunrisehospital.Models

{
    public class Enquir 

    {
        public int Id { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Name")]
       
        public string Name { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Haveuvisitbefore")]
       
        public string Haveuvisitbefore { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "PhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Subject")]
        
        public string Subject { get; set; }

        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Message")]
       

        public string Message { get; set; }

      



    }
}
