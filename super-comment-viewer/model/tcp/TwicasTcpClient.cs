using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace super_comment_viewer.model.tcp
{
    public class TwicasTcpClient : ILiveTcpClient
    {
        private ClientWebSocket _webSocket;

        private const int MESSAGE_BUFFER_SIZE = 256;

        public TwicasTcpClient()
        {
            _webSocket = new ClientWebSocket();
        }

        public async Task<bool> StartConnectServerAsync(string webSocketUrl)
        {
            await _webSocket.ConnectAsync(new Uri(webSocketUrl), CancellationToken.None);
            return _webSocket.State == WebSocketState.Open;    
        }



        public void close()
        {
            throw new NotImplementedException();
        }

        public async IAsyncEnumerable<string> ReceiveCommentAsync()
        {
            while(_webSocket.State == WebSocketState.Open)
            {
                var buff = new ArraySegment<byte>(new byte[MESSAGE_BUFFER_SIZE]);
                var response = await _webSocket.ReceiveAsync(buff, CancellationToken.None);
                yield return new UTF8Encoding().GetString(buff.Take(response.Count).ToArray());
            }
        }

    }
}
