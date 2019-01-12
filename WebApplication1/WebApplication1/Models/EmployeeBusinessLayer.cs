using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataAccessLayer;


namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployeeList()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employee.ToList();

            //List<Employee> employee = new List<Employee>();
            //Employee emp = new Employee();
            //emp.Name = "无敌";
            //emp.Salary = 20000;
            //employee.Add(emp);

            //emp = new Employee();
            //emp.Name = "热狗";
            //emp.Salary = 15000;
            //employee.Add(emp);

            //emp = new Employee();
            //emp.Name = "真香";
            //emp.Salary = 1000;
            //employee.Add(emp);
            //return employee;

        }
    }
}