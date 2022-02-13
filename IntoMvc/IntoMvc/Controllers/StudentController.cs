using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntoMvc.Models;
using IntoMvc.Models.Database;


namespace IntoMvc.Controllers
{
    public class StudentController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Submit()
        {
            return View(new List<Student>());
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
                StudentEntities db = new StudentEntities();
                db.Students.Add(s);
                db.SaveChanges();
                return RedirectToAction("Submit");
            }
            return View();
        }



       
    }
}