using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IF.Web.Models
{
    public class EventViewModel
    {
        public string EventDate { get; set; }
        public string EventStatus { get; set; }
        public string Event { get; set; }
        public string ImageUrl { get; set; }
        public string EventUrl { get; set; }
    }
}