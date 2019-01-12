using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModels;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
       public  string GetString()//
        {
            return "你好！";
        }
        public Customer getCustomer()
        {
            Customer ct = new Customer();
            ct.CustomerName = "zxzx";
            ct.Address = "awr";
            return ct;
        }
        public ActionResult index()                                                                                                         //这里仅仅是想获得一个视图
        {
            EmployeeViewModel vmEmp = new EmployeeViewModel();
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
            //vmEmp.Greeting = greeting;

            Employee emp = new Employee();
            emp.Name = "无敌";
            emp.Salary = 1000;
            
            //ViewData["Employee"] = emp;
            vmEmp.EmployeeName = emp.Name;
            vmEmp.EmployeeSalary = emp.Salary.ToString("c");
            if(emp.Salary > 1000)
            {
                vmEmp.SalaryGrade = "土豪";
            }
            else
            {
                vmEmp.SalaryGrade = "小职员";
            }
            //vmEmp.UserName = "Admin";
            return View("MyView",vmEmp);










            //EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            //EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            //List<Employee> employees = empBal.GetEmployees();
            //List<EmployeeListViewModel> empViewModel = new List<EmployeeListViewModel>();
        }

    }
}