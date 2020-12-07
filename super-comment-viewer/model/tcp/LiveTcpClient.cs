using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace super_comment_viewer.model.tcp
{
    public interface ILiveTcpClient
    {
        /// <summary>
        /// コメントサーバーに接続を試みる
        /// </summary>
        public Task<bool> StartConnectServerAsync(string webSocketUrl);

        /// <summary>
        /// コメントを非同期に取得する
        /// </summary>
        /// <returns>コメント</returns>
        public IAsyncEnumerable<string> ReceiveCommentAsync();

        /// <summary>
        /// サーバー接続を終了する
        /// </summary>
        public void close();
    }
}
