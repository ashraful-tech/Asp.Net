using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFp.Models;
using EFp.Models.Database;

namespace EFp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Create()
        {
            return View(new Student());
        }
        
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                Models.Database.Student db = new Models.Database.Student();

                db.Database.Add(s);
                db.SaveChanges();

                
            }
            return View(s);
        }
        
        public ActionResult Update()
        {
            return View();
        }
        
        public ActionResult Delete()
        {
            return View();
        }
    }
}