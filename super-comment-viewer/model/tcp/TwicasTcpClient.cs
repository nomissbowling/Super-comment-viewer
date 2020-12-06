using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace super_comment_viewer.model.tcp
{
    public class TwicasTcpClient : ILiveTcpClient
    {
        void ILiveTcpClient.close()
        {
            throw new NotImplementedException();
        }

        Task<string> ILiveTcpClient.ReceiveCommentAsync()
        {
            throw new NotImplementedException();
        }

        Task ILiveTcpClient.StartConnectServerAsync()
        {
            throw new NotImplementedException();
        }
    }
}
