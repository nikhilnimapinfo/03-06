using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public String EmployeeAdd(int id)
        {
            string data = string.Empty;
            if (id == 1)
            {
                data = "in Id 1";
            }
            if (id == 2)
            {
                data = "in Id 2";
            }
            else
            {
                return "Not Valid";
            }
            return
                "";  
        }
        public String EmployeeData(int id, string dept)
        {

            return "id = "+id+ " "+ "dept = "+dept;
        
        }
    }
}