using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace sunrisehospital.Models
{
    public class BookAppointment 


    {

        public int Id { get; set; }

        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Department")]
        public string Department { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Doctor")]
        public string Doctor { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Haveuvisitbefore")]
        public string Haveuvisitbefore { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
        public DateTime Date { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Number")]
        [DataType(DataType.PhoneNumber)]
        public string Number { get; set; }
        [Required(ErrorMessage = ("please enter"))]
        [Display(Name = "Message")]
        public string Message { get; set; }



     


    }
}
