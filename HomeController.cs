using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public string Index() {
            return "Inside Index";
        }

        public string don()
        {
            return "Inside Don";
        }
        public ActionResult data ()
            {

            var Class1 = a();

            return View(Class1);


            }
        public Class1 a()
        {
            return new Class1() {
                Id = 1,
                Name = "Test",
                Addr="Karvenager"

            };
                

                
        
        }
    }
}