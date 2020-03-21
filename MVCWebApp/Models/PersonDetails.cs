using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class PersonDetails
    {
        [Range(50, 300, ErrorMessage = "Invalid value for Height")]
        [Required(ErrorMessage = "Please enter Height in CM")]
        public double Height { get; set; }

        [Range(1, 500, ErrorMessage = "Invalid value for Weight")]
        [Required(ErrorMessage = "Please enter Weight in KG")]
        public double Weight { get; set; }
        public double BMI { get; set; }
    }
}