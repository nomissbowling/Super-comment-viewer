using super_comment_viewer.model.json.jsonmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace super_comment_viewer.model
{
    public class JsonParser
    {
        private string _json;

        public JsonParser(string json)
        {
            this._json = json;
        }

        public UserMovieInfoModel ConvertToUserMovieInfoModel()
        {
            return JsonSerializer.Deserialize<UserMovieInfoModel>(_json);

        }

        public WebSocektUrlModel convertToWebSocketUrl()
        {
            return JsonSerializer.Deserialize<WebSocektUrlModel>(_json);
        }
    }
}
