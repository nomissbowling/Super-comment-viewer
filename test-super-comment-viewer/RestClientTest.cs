using Moq;
using NUnit.Framework;
using super_comment_viewer.model.rest;
using System.Reflection;
using System.Threading.Tasks;

namespace super_comment_viewer_test
{
    public class Tests
    {
        private TwicasRestBuilder _builder;

        [SetUp]
        public void Setup()
        {
            var userId = "nana_fujisawa";
            _builder = new TwicasRestBuilder(userId);
        }

        [Test]
        public async Task GetMovieIdTest()
        {

            var info = _builder.GetType();
            var method = info.GetMethod("FetchMovieId", BindingFlags.NonPublic | BindingFlags.Instance);
            var actual = await (Task<int>)method.Invoke(_builder, new object[] { });
            var expect = 655119167;
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public async Task FetchWebSocketUrlTest()
        {
            var client = await new TwicasRestBuilder("oujityama").Build();
            var actual = await client.FetchWebSocketUrlAsync();
            var expect = "wss://s202218134036.twitcasting.tv/event.pubsub/v1/streams/655114241/events?token=NjU1MTE0MjQx:::1607299719:74586439152952eb";
            Assert.AreEqual(expect, actual);

        }
        


    }
}