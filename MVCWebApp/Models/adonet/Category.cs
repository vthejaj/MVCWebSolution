using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models.adonet
{
    public class Category
    {
        [MinLength(2, ErrorMessage = "Minimum Lenght is 2")]
        [Required(ErrorMessage = "Code is Missing!")]
        public string Code { get; set; }

        [MinLength(5,ErrorMessage ="Minimum lenght is 5")]
        [Required(ErrorMessage ="Description is missing!")]
        public string Description { get; set; }

    }
}