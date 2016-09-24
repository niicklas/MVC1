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

        //[HttpGet] //Är default
        //public ActionResult Create()
        //{
        //    Participant model = new Participant();
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult Create(Participant _model)
        //{
        //    if (participantList.Count>0)
        //    {
        //        _model.Id = participantList.Max(x => x.Id) + 1;
        //    }
        //    else
        //    {
        //        _model.Id = 1;

        //    }

        //    participantList.Add(_model);
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public ActionResult Modify(Participant _model)
        //{ 
        //    return View(_model);
        //}

        //[HttpPost]
        //[ActionName("Modify")]
        //public ActionResult Modify_Post(Participant _model, string save, string delete)
        //{
        //    var tmpProduct = participantList.Find(x => x.Id == _model.Id);
        //    if (save!=null)
        //    {
        //        tmpProduct.Name = _model.Name;
        //        tmpProduct.Birthday = _model.Birthday;
        //        tmpProduct.Team = _model.Team;
        //    }
        //    else if (delete!=null)
        //    {
        //        participantList.Remove(tmpProduct);
        //    }
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Order()
        //{
        //    return View(participantList);
        //}
            
    }
   
}