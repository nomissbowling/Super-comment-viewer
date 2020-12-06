using super_comment_viewer.model.api;
using System.Threading.Tasks;

namespace super_comment_viewer.model.rest
{
    public class TwicasRestBuilder
    {
        private string _userId;
        public TwicasRestBuilder(string userId)
        {
            _userId = userId;
      
        }

        public async Task<TwicasRestClient> Build()
        {
            var movieId = await FetchMovieId();
            return new TwicasRestClient(movieId);
        }

        private async Task<int> FetchMovieId()
        {
            var wrapHttpClient = HTTPCLIENT.INSTANCE;
            var response = await wrapHttpClient.GetWrapAsync(LiveApi.GetMovieIdApi(this._userId));
            var model = new JsonParser(response).ConvertToUserMovieInfoModel();
     
            return model.movie.id;
        }

        
    }
}
