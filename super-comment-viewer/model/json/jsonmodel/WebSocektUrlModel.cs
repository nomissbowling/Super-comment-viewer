using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace super_comment_viewer.model.json.jsonmodel
{
    /// <summary>
    /// WebSocketのURLを格納するJsonモデル
    /// </summary>
    public class WebSocektUrlModel
    {
        [JsonInclude]
        public string url;
    }
}
