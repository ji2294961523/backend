using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GukeController : Controller
    {
        // GET: Guke
        public ActionResult Index()
        {
            string greeting;
            //获取当前时间
            DateTime dt = DateTime.Now;
            //获取当前小时数
            int hour = dt.Hour;
            if (hour < 12)
            {
                greeting = "上午好";
            }
            else
            {
                greeting = "下午好";
            }

            ViewBag.greeting = greeting;
            Customer emp = new Customer();
            emp.CustomerName = "无敌";
            emp.Address = "D区16栋";
            //ViewData["Employee"] = emp;
            ViewBag.Customer = emp;
            return View("Index", emp);
        }
    }
}