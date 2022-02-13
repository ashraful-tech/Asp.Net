using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntoMvc.Models
{
    public class Person
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public DateTime Dob { get; set; }
        public String Email { get; set; }
    }
}