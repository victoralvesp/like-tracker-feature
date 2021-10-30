using System.Threading.Tasks;
using LikeTrackingSystem.LikeApi.Models;
using Microsoft.Extensions.Configuration;

namespace LikeTrackingSystem.LikeApi.Services
{
    /// <summary>
    /// Requests like tracking information about an article and a user
    /// </summary>
    public interface ILikeTrackingService
    {
        /// <summary>
        /// Checks if the user has liked the article
        /// </summary>
        /// <param name="articleId"></param>
        /// <param name="userId"></param>
        /// <returns>Information about likes from user</returns>
        UserLikedArticle? HasUserLiked(string articleId, string userId);
    }
}
