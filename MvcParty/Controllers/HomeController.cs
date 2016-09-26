using MvcParty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcParty.Helpers;

namespace MvcParty.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "MVC Party";
            ViewBag.Greeting = DateTime.Now.Hour > 12 ? "Good afternoon" : "Good morning";
            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse response)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var model = new GuestResponse();
            string extensionUse = model.GetUserInfo();

            return View("Thanks", response);
        }
    }
}