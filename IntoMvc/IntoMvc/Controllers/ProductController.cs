using IntoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntoMvc.Controllers
{
    public class ProductController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Home()
        {
            /*ViewBag.Name = "Tanvir";
            ViewBag.Id = "12";
            ViewBag.Dob = "12.12.12";

           ViewData["Name"] = "Sabbir";
           ViewData["Id"] = 13;
           ViewData["Dob"] = "12.12.12";*/

            /*string[] names = { "Tanvir", "Shanto", "Pranto" };
            @ViewBag.Name = names;*/

            List<Person> persons = new List<Person>();

            for (int i = 0; i < 100; i++)
            {
                var p = new Person()
                {
                    Id = i+1,
                    Name = "Person"+ (i+1),
                    Dob = DateTime.Today,
                    Email = "imshanto@gmal.com"+(i+1)
                };

                persons.Add(p);
            }


            return View(persons);
        }


    }
}