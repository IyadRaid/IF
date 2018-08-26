using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF.Domain.Utils
{
    public interface IApiRequest
    {
        string GetRequest(string apiUrl,string apiParam);
    }
}
