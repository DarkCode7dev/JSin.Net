using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using Newtonsoft.Json;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Getstudent()
        {
            Student std = new Student()
            {
                Id =1,
                Email = "email@gmail.com",
                Name = "Dark Dev"
            };

            var json = JsonConvert.SerializeObject(std);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}
