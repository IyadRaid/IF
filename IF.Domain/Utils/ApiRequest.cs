using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IF.Domain.Utils
{
    public class ApiRequest : IApiRequest
    {
        public string GetRequest(string apiUrl, string apiParam)
        {
            var json = string.Empty;

            var url = $"{apiUrl}{apiParam}";

            var request = (HttpWebRequest)WebRequest.Create(url.ToLower());
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";
            request.PreAuthenticate = false;

            var response = request.GetResponse() as HttpWebResponse;
            using(Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                json = reader.ReadToEnd();

                json.TrimStart(new char[] {'[' })
                    .TrimEnd(new char[] { ']'});
            }

            return json;
        }
    }
}
