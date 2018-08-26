using IF.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IF.Domain.BL
{
    public interface IEventRepository
    {
        List<EventDto> GetEvents(string url, string param);
        
    }
}
