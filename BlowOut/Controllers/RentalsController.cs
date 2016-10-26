using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RentalNew()
        {
            return View();
        }
        public ActionResult RentalUsed()
        {
            return View();
        }
       
       
        

        public ActionResult details(string name, string type)
        {
           
            if(name == "Trumpet")
            {
                ViewBag.instrumentName = "Trumpet";
                ViewBag.description = "";
                ViewBag.filepath = "/Content/img/trumpet.jpg";
                ViewBag.type = type;              

                if(type == "new")
                {
                    ViewBag.price = "$55 Dollars";
                }

                if (type == "used")
                {
                    ViewBag.price = "$25 Dollars";
                }
            }
            if (name == "Trombone")
            {
                ViewBag.instrumentName = "Trombone";
                ViewBag.description = "";
                ViewBag.filepath = "/Content/img/trombone-1.jpg";
                ViewBag.type = type; 

                if (type == "new")
                {
                    ViewBag.price = "$60 Dollars";
                }

                if (type == "used")
                {
                    ViewBag.price = "$35 Dollars";
                }
            }
            if (name == "Tuba")
            {
                ViewBag.instrumentName = "Tuba";
                ViewBag.description = "";
                ViewBag.filepath = "/Content/img/tuba.jpg";
                ViewBag.type = type; 

                if (type == "new")
                {
                    ViewBag.price = "$70 Dollars";
                }

                if (type == "used")
                {
                    ViewBag.price = "$50 Dollars";
                }
            }
            if (name == "Flute")
            {
                ViewBag.instrumentName = "Flute";
                ViewBag.description = "";
                ViewBag.filepath = "/Content/img/flute.jpg";
                ViewBag.type = type; 

                if (type == "new")
                {
                    ViewBag.price = "$40 Dollars";
                }

                if (type == "used")
                {
                    ViewBag.price = "$25 Dollars";
                }
            }
            if (name == "Clarinet")
            {
                ViewBag.instrumentName = "Clarinet";
                ViewBag.description = "";
                ViewBag.filepath = "/Content/img/clarinet.jpg";
                ViewBag.type = type;

                if (type == "new")
                {
                    ViewBag.price = "$35 Dollars";
                }

                if (type == "used")
                {
                    ViewBag.price = "$27 Dollars";
                }

            }
                if (name == "Saxophone")
                {
                    ViewBag.instrumentName = "Saxophone";
                    ViewBag.description = "";
                    ViewBag.filepath = "/Content/img/saxohphone.jpg";
                    ViewBag.type = type; 

                    if (type == "new")
                    {
                        ViewBag.price = "$42 Dollars";
                    }

                    if (type == "used")
                    {
                        ViewBag.price = "$30 Dollars";
                    }
                
            }
            
            
            return View();
        }

    }
}