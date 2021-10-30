using System.Threading.Tasks;
using LikeTrackingSystem.LikeApi.Models;
using LikeTrackingSystem.LikeApi.Options;
using Microsoft.Extensions.Options;
using RestSharp;

namespace LikeTrackingSystem.LikeApi.Services
{
    /// <inheritdoc/>
    public class LikeTrackingService : ILikeTrackingService
    {
        string _trackingServiceUrl;
        private RestClient _httpClient;

        /// <summary>
        /// Creates a new instance of <see cref="LikeTrackingService"/>
        /// </summary>
        /// <param name="options"></param>
        public LikeTrackingService(IOptions<TrackingServiceConfig> options)
        {
            _trackingServiceUrl = options.Value.Url;
            _httpClient = new RestClient(_trackingServiceUrl);
        }


        /// <inheritdoc/>
        public UserLikedArticle? HasUserLiked(string articleId, string userId)
        {
            var apiPath = $"/users/{userId}/articles/{articleId}/likes";
            var request = new RestRequest(apiPath, Method.GET);
            var response = _httpClient.Get<UserLikedArticle>(request);

            if (!response.IsSuccessful)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return null;
                }
                else
                {
                    throw new System.Exception($"Error while getting likes for article {articleId} and user {userId}");
                }
            }
            
            return response.Data;
        }
    }
}
