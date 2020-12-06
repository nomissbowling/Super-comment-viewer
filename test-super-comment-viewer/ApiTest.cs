using NUnit.Framework;
using super_comment_viewer.model.api;
using System;
using System.Collections.Generic;
using System.Text;

namespace super_comment_viewer_test
{
    class ApiTest
    {
        [Test]
        public void MovieIdApiTest()
        {
            var userId = "fox_uver";
            var actual = LiveApi.GetMovieIdApi(userId);
            var expect = $"https://frontendapi.twitcasting.tv/users/{userId}/latest-movie";
            Assert.AreEqual(expect, actual);
        }
    }
}
