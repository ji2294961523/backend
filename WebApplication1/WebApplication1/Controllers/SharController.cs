using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SharController : Controller
    {
        // GET: Shar
        public ActionResult Index()
        {
          

            Employee emp = new Employee();
            emp.Name = "无敌";
            emp.Salary = 1000;
            //ViewData["Employee"] = emp; 
            Customer cut = new Customer();
            cut.CustomerName = "无敌";
            cut.Address = "D区16栋";
            ViewBag.Employee = emp;
            return View(cut);
        }
    }
}