using System.Threading.Tasks;
using LikeTrackingSystem.LikeApi.Options;
using Microsoft.Extensions.Options;
using RestSharp;

namespace LikeTrackingSystem.LikeApi.Services
{
    /// <inheritdoc/>
    public class LikeCounterService : ILikeCounterService
    {
        string _counterServiceUrl;
        private RestClient _httpClient;

        /// <summary>
        /// Creates a new instance of <see cref="LikeCounterService"/>
        /// </summary>
        /// <param name="options"></param>
        public LikeCounterService(IOptions<CounterServiceConfig> options)
        {
            _counterServiceUrl = options.Value.Url;
            _httpClient = new RestClient(_counterServiceUrl);
        }


        /// <inheritdoc/>
        public int? GetLikesFor(string articleId)
        {
            var apiPath = $"/articles/{articleId}/likes";
            var request = new RestRequest(apiPath, Method.GET);

            var response = _httpClient.Get<int>(request);

            if (!response.IsSuccessful)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return null;
                }
                else
                {
                    throw new System.Exception($"Error while getting likes for article {articleId}");
                }
            }

            return response.Data;
        }
    }
}
