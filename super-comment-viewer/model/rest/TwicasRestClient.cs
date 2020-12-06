using super_comment_viewer.model.api;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace super_comment_viewer.model.rest
{
    public class TwicasRestClient : IRestClient
    {
        private int _movieId;

        public TwicasRestClient(int movieId)
        {
            _movieId = movieId;
        }


        public async Task<string> FetchWebSocketUrlAsync()
        {
            var response = await RunPostWebSocektUrl();
            var parser = new JsonParser(response);
            return parser.convertToWebSocketUrl().url;
        }

        private async Task<string> RunPostWebSocektUrl()
        {
            var client = HTTPCLIENT.INSTANCE;
            var body = new Dictionary<string, string>() {
                { "movie_id" , this._movieId.ToString()}
            };

            return await client.PostWrapAsync(LiveApi.GET_WEBSOCKET_URL_API, body);
            

        }

    }
}
