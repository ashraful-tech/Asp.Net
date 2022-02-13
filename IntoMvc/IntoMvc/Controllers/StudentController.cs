using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntoMvc.Models;


namespace IntoMvc.Controllers
{
    public class StudentController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }
        
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Home", "Product");
            }
            return View(s);
        }



        [HttpPost]
        public ActionResult Submit()
        {
            return View();
        }
    }
}