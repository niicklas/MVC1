using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class ParticipantViewModel
    {
        public int Id { get; set; }

        [DisplayName("Namn")]
        [Required]
        [RegularExpression(@"^[a-zA-ZåäöÅÄÖ ]{2,40}$", ErrorMessage ="Mellan 2 och 40 bokstäver krävs.")]
        public string Name { get; set; }

        [DisplayName("Födelsedag")]
        [Required]
        [Range(19000000, 20200000, ErrorMessage ="Felaktigt födelsadatum, ange på formeln ÅÅÅÅMMDD")]
        public int Birthday { get; set; }

        [DisplayName("Klubb")]
        [Required]
        [MaxLength(50,ErrorMessage ="För långt klubbnamn")]
        public string Team { get; set; }
    }
}