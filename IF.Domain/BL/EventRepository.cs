using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IF.Domain.Dto;
using IF.Domain.Utils;
using Newtonsoft.Json;

namespace IF.Domain.BL
{
    public class EventRepository : IEventRepository
    {
        private IApiRequest _request;
      

        public EventRepository(IApiRequest request)
        {
            _request = request;
       
        }

        public List<EventDto> GetEvents(string url, string param)
        {
            var eventDataList = new List<EventDto>();
            var response = _request.GetRequest(url, param);

            eventDataList = JsonConvert.DeserializeObject<List<EventDto>>(response);          

            return eventDataList;
        }
    }
}
