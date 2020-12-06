using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace super_comment_viewer.model.rest
{
    public enum HTTPCLIENT
    {
        INSTANCE, 
    }
    public static class HttpClientWrapper
    {
        public static async Task<string> GetWrapAsync(this HTTPCLIENT client, string request)
        {
            HttpResponseMessage response;
            using(var http = new HttpClient())
            {
                response =  await http.GetAsync(request);
            }
            return await response.Content.ReadAsStringAsync();
        }
        
        public static async Task<string> PostWrapAsync(this HTTPCLIENT client, string reqeust, Dictionary<string, string> body)
        {
            HttpResponseMessage response;
            var content = new FormUrlEncodedContent(body);

            using(var http = new HttpClient())
            {
                response = await http.PostAsync(reqeust, content);
            }
            return await response.Content.ReadAsStringAsync();        }
    }

   
}
