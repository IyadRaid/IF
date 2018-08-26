using IF.Domain.BL;
using IF.Domain.Dto;
using IF.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Unity.Attributes;

namespace IF.Web.Controllers
{
    public class HomeController : Controller
    {
        private IEventRepository _event;

        public HomeController(IEventRepository @event)
        {
            _event = @event;
        }
        public ActionResult Index()
        {
            //standard data
            var url = "http://debaser.se/debaser/api/?";
            var param = "version=2&method=getevents&venue=medis&from=20100101&to=20110201&format=json";

            var events = MappEvent(url, param);


            return View(events);
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult Index(Eventspresentationmodel @event)
        {
            string url = string.Empty;
            string param = string.Empty;
            //Build url
            BuildUrl(@event, out url, out param);

            var events = MappEvent(url, param);

            return View(events);
        }
        private Eventspresentationmodel MappEvent(string url, string param)
        {
            var obj = _event.GetEvents(url, param);
            var events = new Eventspresentationmodel();

            if (obj != null)
                obj.ForEach(e => events.Events.Add(new EventViewModel()
                {
                    Event = e.Event,
                    EventDate = e.EventDate,
                    EventStatus = e.EventStatus,
                    EventUrl = e.EventUrl,
                    ImageUrl = e.ImageUrl
                }));

            return events;
        }
        private void BuildUrl(Eventspresentationmodel @event, out string url, out string param)
        {
            url = "http://debaser.se/debaser/api/?";
            param = $"version=2&method=getevents&venue={@event.EventId}&from={@event.fromDate}&to={@event.ToDate}&format=json";
        }
    }
}