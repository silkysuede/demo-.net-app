using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppFromScratch.Models;
namespace AppFromScratch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.CurrentDate = DateTime.Now;
            return View();
        }
        [HttpGet]
        public ActionResult SignupForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignupForm(UserResponses userResponse)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", userResponse);
            }
            else { return View(); }
            
        }
    }
}