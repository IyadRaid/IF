using System;
using System.Collections.Generic;
using IF.Domain.BL;
using IF.Domain.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IF.Test
{
    [TestClass]
    public class ApiRequestTest
    {
        [TestMethod]
        public void GetRequest_Should_Return_Json()
        {
            ApiRequest req = new ApiRequest();


            //http://debaser.se/debaser/api/?version=2&method=getevents&venue=medis&from=20100101&to=20100201&format=json
            var url = "http://debaser.se/debaser/api/?";
            var param = "version=2&method=getevents&venue=medis&from=20100101&to=20100201&format=json";
            var json = req.GetRequest(url, param);

        }


        [TestMethod]
        public void ConvertEventToObject()
        {
            //IApiRequest req = new ApiRequest();


            //var url = "http://debaser.se/debaser/api/?";
            //var param = "version=2&method=getevents&venue=medis&from=20100101&to=20110201&format=json";
            //IEventRepository @event = new EventRepository(req, url, param);

            //var events = new List<EventDTO>();
            //events = @event.ConvertJsonToObject();
        }

        [TestMethod]
        public void ConvertEventToObject2()
        {
            //IApiRequest req = new ApiRequest();

            //string venue = "strand";
            //string from = "20180605";
            //string to = "20180704"; 

            //var url = "http://debaser.se/debaser/api/?version=2&method=getevents";
            //var param = $"&venue={venue}&from={from}&to={to}&format=json";
            //IEventRepository @event = new EventRepository(req, url, param);

            //var events = new List<EventDTO>();
            //events = @event.ConvertJsonToObject();
        }
    }
}
