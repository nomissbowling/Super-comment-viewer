namespace super_comment_viewer.model.api
{
    public class LiveApi
    {
        public static string GetMovieIdApi(string userId)
        {
            return $"https://frontendapi.twitcasting.tv/users/{userId}/latest-movie";
        }
        public const string GET_WEBSOCKET_URL_API = "https://twitcasting.tv/eventpubsuburl.php";
    } 
}
