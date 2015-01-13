using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Title = "Online Booking System & Reservation Software";
            ViewBag.Description = "Free Online Booking Software and System for Small Business";  
            return View();
        }


        public ActionResult BestGymnasticsSoftware(String Id)
        {
            ViewBag.Title = "Gymnastics Software System Online";
            ViewBag.Description = "Gymnastics Software System for Small Business";
            if (String.IsNullOrEmpty(Id))
                return View("Gymnastics");
            else{
                    switch (Id)
                    {
                        case "reviews":
                             ViewBag.Title = "Gymnastics Software Reviews";
                            ViewBag.Description = "Gymnastics Software Reviews for Small Business Owners";
                            break;

                        case "pricing":
                            ViewBag.Title = "Free Gymnastics Software System Online";
                            ViewBag.Description = "Free Online Gymnastics software for your small business";
                            break;

                    }
                }
            return View("Gym-"+Id);
        }

        public ActionResult BestDanceStudioSoftware(String Id)
        {
            ViewBag.Title = "Dance Studio Software Online Booking";
            ViewBag.Description = "Dance Studio Software System for Small Business";
            if (String.IsNullOrEmpty(Id))
                return View("DanceStudio");
            else
            {
                switch (Id)
                {
                    case "reviews":
                        ViewBag.Title = "Dance Studio Software Reviews";
                        ViewBag.Description = "Dance Studio Software Reviews for Small Business Owners";
                        break;

                    case "pricing":
                        ViewBag.Title = "Free Dance Studio Software System Online";
                        ViewBag.Description = "Free Online Dance Studio software for your small business";
                        break;

                }
            }
            return View("DanceStudio-" + Id);
        }

        public ActionResult ClassBookingSoftware(String Id)
        {
            ViewBag.Title = "Online Class Booking Software";
            ViewBag.Description = "Class Registration Software System for Small Business";
            if (String.IsNullOrEmpty(Id))
                return View("Classes");
            else
            {
                switch (Id)
                {
                    case "reviews":
                        ViewBag.Title = "Class Registration Software Reviews";
                        ViewBag.Description = "Class Registration Software for Small Business Owners";
                        break;

                    case "pricing":
                        ViewBag.Title = "Free Class Registration Software System Online";
                        ViewBag.Description = "Free Online Class Registration software for your small business";
                        break;

                }
            }
            return View("Classes-" + Id);
        }

        public ActionResult CampSoftware(String Id)
        {
            ViewBag.Title = "Camp Registration Software";
            ViewBag.Description = "Camp Software System for Small Business";
            if (String.IsNullOrEmpty(Id))
                return View("Camps");
            return View("Camps-" + Id);
        }

    }
}
