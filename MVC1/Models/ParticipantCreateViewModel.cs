using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class ParticipantCreateViewModel
    {
        public ParticipantViewModel Participant { get; set; }

        public ParticipantListViewModel ParticipantList { get; set; }
    }
}