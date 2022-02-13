using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntoMvc.Models
{
    public class Student
    {
        [Required]
        public String Name { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public String Dept { get; set; }
        [Required]
        public String BGrp { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public DateTime Dob { get; set; }
    }
}