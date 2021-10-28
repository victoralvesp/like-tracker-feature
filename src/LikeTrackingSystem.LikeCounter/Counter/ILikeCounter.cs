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
        /// Number of likes for the article.
        /// </summary>
        /// <param name="articleEvent">Article event</param>
        /// <returns>Current count of likes for article</returns>
        int CountLikes(ArticleLikeEvent articleEvent);
    }
}
