using System.Collections.Generic;
using LikeTrackingSystem.LikeCounter.Repository;

namespace LikeTrackingSystem.LikeCounter.Counter
{
    /// <summary>
    /// Counts article likes.
    /// </summary>
    public interface ILikeCounter
    {
        /// <summary>
        /// Increases the number of likes for the article.
        /// </summary>
        /// <param name="articleEvent">Article event</param>
        /// <returns>Current count of likes for article</returns>
        int CountLike(ArticleLikeEvent articleEvent);

        /// <summary>
        /// Gets the number of likes for the article.
        /// </summary>
        /// <param name="articleId">Article's UUID</param>
        /// <returns>Current count of likes for article</returns>
        int? LikesFor(string articleId);

    }
}
