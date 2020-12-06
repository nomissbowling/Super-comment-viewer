using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace super_comment_viewer.model.rest
{
    public interface IRestClient
    {
        /// <summary>
        /// WebSocketのURLを取得
        /// </summary>
        /// <returns>WebSocketのURL</returns>
        public Task<string> FetchWebSocketUrlAsync();
    }
}
