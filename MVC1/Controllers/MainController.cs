using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class MainController : Controller
    {
        static List<ParticipantViewModel> participantList = new List<ParticipantViewModel>();
        
        // GET: Main
        public ActionResult Index()
        {

            return View();
            //return View(participantList);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
    }
   
}