using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntoMvc.Models
{
    public class Student
    {

        public String Name { get; set; }
    
        public int Id { get; set; }
   
        public String Dept { get; set; }
    
        public String BGrp { get; set; }
    }
}