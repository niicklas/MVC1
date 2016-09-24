using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class ParticipantController : Controller
    {
        static List<ParticipantViewModel> participantList = new List<ParticipantViewModel>();

        public ActionResult Index()
        {
            return View(participantList);
        }

        [HttpGet] 
        public ActionResult Create()
        {
            ParticipantListViewModel participantListViewModel = new ParticipantListViewModel();

            participantListViewModel.ParticipantList = participantList;
            ParticipantCreateViewModel model = new ParticipantCreateViewModel
            {
                Participant = new ParticipantViewModel(),
                ParticipantList = participantListViewModel
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(ParticipantCreateViewModel _model)
        {

            if (participantList.Count > 0)
            {
                _model.Participant.Id = participantList.Max(x => x.Id) + 1;
            }
            else
            {
                _model.Participant.Id = 1;

            }

            participantList.Add(_model.Participant);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Modify(ParticipantViewModel _model)
        {
            //var _model2 = new ParticipantCreateViewModel
            //{
            //    Participant = _model
            //};

            return View(_model);
        }

        [HttpPost]
        [ActionName("Modify")]
        public ActionResult Modify_Post(ParticipantViewModel _model, string save, string delete)
        {
            var tmpProduct = participantList.Find(x => x.Id == _model.Id);
            if (save != null)
            {
                tmpProduct.Name = _model.Name;
                tmpProduct.Birthday = _model.Birthday;
                tmpProduct.Team = _model.Team;
            }
            else if (delete != null)
            {
                participantList.Remove(tmpProduct);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Order()
        {
            return View(participantList);
        }

        public PartialViewResult ParticipantList()
        {
            return PartialView("ParticipantListPartial", participantList);
        }


    }

}