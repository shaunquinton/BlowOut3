using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.greeting = "Please call Support at <u><strong>801-555-1212</strong></u>. Thank you!";
            return View();
        }

        public ActionResult email(String name, String email)
        {
            ViewBag.email = "Thank you " + name + ". We will send you an email at "+ email; 
            return View();
        } 
    }
}