using NUnit.Framework;
using super_comment_viewer.model;
using super_comment_viewer.model.json.jsonmodel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace super_comment_viewer_test
{
    class JsonParserTest
    {
        [Test]
        public void ConvertMovieInfoModel()
        {
            var expect = new UserMovieInfoModel()
            {
                movie = new Movie { id = 655105178, is_on_live = false},
                update_interval_sec = 0,
            };
            var actual = new JsonParser("{\"update_interval_sec\":4,\"movie\":{\"id\":655105178,\"is_on_live\":true}}").ConvertToUserMovieInfoModel();
            TestContext.WriteLine(actual);
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ConvertToWebSocektUrlModel()
        {
            var expect = "wss://s202218175203.twitcasting.tv/event.pubsub/v1/streams/655114241/events?token=NjU1MTE0MjQx:::1607291978:ca50913e4ee75503";
            var json = @"{""url"": ""wss://s202218175203.twitcasting.tv/event.pubsub/v1/streams/655114241/events?token=NjU1MTE0MjQx:::1607291978:ca50913e4ee75503""}";
            var actual = new JsonParser(json).convertToWebSocketUrl();
            Assert.AreEqual(expect, actual.url);
        }
    }
}
