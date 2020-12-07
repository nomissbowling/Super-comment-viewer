using NUnit.Framework;
using super_comment_viewer.model.tcp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace test_super_comment_viewer
{
    class TcpClienttTest
    {
        [Test]
        public async Task StartConnectTwicasebSocket()
        {
            var twicasTcp = new TwicasTcpClient();
            var isConnect = await twicasTcp.StartConnectServerAsync("wss://s202218175205.twitcasting.tv/event.pubsub/v1/streams/655148178/events?token=NjU1MTQ4MTc4%3AZWxtMDMyMTExMTQ%3D%3A%3A1607326163%3Ace7fdb3df5d5bcf9&n=795101661d3af755&gift=1");
            var expect = true;
            Assert.AreEqual(expect, isConnect);
        }

        [Test]
        public async Task ReceiveCommentTest()
        {
            var ws = new TwicasTcpClient();
            await ws.StartConnectServerAsync("wss://s202218134038.twitcasting.tv/event.pubsub/v1/streams/655205082/events?token=NjU1MjA1MDgy%3AZWxtMDMyMTExMTQ%3D%3A%3A1607349702%3Ab53efc283b7568af&n=795101661d3af755&gift=1");
       
            var res = await ws.ReceiveCommentAsync().FirstAsync();
            TestContext.WriteLine(res);           
        }
    }
}
