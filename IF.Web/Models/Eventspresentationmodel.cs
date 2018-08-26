using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IF.Web.Models
{
    public class Eventspresentationmodel
    {
        [Required]
        [Display(Name = "Från (yyyymmdd): ")]
        [DataType(DataType.Date, ErrorMessage = "Du måste ha ett startdatum!")]
        public string fromDate { get; set; }

        [Required]
        [Display(Name = "Till (yyyymmdd): ")]
        [DataType(DataType.Date, ErrorMessage = "Du måste ha ett slutdatum!")]
        public string ToDate { get; set; }

        [Required]
        [Display(Name = "Område: ")]
        public List<SelectListItem> Event { get; set; }
        public string EventId { get; set; }

        public List<EventViewModel> Events { get; set; }


        public Eventspresentationmodel()
        {
            Event = new List<SelectListItem>();
            Events = new List<EventViewModel>();
            Event.Add(new SelectListItem
            {
                Text = "Medis",
                Value = "medis"
            });
            Event.Add(new SelectListItem
            {
                Text = "Strand",
                Value = "strand",
                Selected = true
            });
            Event.Add(new SelectListItem
            {
                Text = "Humlegarden",
                Value = "humlegarden"
            });
        }
    }
 


 
}