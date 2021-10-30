using System.Threading.Tasks;

namespace LikeTrackingSystem.LikeApi.Services
{
    /// <summary>
    /// Requests the number of likes from the like counter service.
    /// </summary>
    public interface ILikeCounterService
    {
        /// <summary>
        /// Gets the number of likes for the article with the specified <paramref name="articleId"/>.
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns>The like count for the article or null if the article was not found</returns>
        int? GetLikesFor(string articleId);
    }
}
