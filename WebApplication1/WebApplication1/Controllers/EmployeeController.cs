using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModels;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeListViewModel empListModel = new EmployeeListViewModel();
            empListModel.Employess  = getEmpVmList();
            empListModel.Greeting = getGreeting();
            empListModel.UserName = getUserName();
            return View(empListModel);
        }
        public ActionResult AddNew()
        {
            return View("CreateEmployee");
           
        }
        [NonAction]
        List<EmployeeViewModel> getEmpVmList()
        {
            //实例化员工信息业务层
            EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
            //员工原始数据列表，获取来自业务层的数据
            var listEmp = empBL.GetEmployeeList();
            //员工原始数据加工后的视图数据列表，当前状态是空的
            var listEmpVm = new List<EmployeeViewModel>();
            //通过循环遍历员工原始数据数组，将数据一个一个的转换，并加入listEmpVm
            foreach (var item in listEmp)
            {
                EmployeeViewModel empVmObj = new EmployeeViewModel();
                empVmObj.EmployeeName = item.Name;
                empVmObj.EmployeeSalary = item.Salary.ToString("C");
                if (item.Salary > 10000)
                {
                    empVmObj.SalaryGrade = "jbkjnj";
                }
                else
                {
                    empVmObj.SalaryGrade = "hkjjl";
                }
                listEmpVm.Add(empVmObj);
            }
            return listEmpVm;
        }
        [NonAction]
        string getGreeting()
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
            return greeting;
        }
        string getUserName()
        {
            string userName = "无敌";
            return userName;
        }
    }
}