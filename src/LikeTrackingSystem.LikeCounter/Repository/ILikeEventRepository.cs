using System.Collections.Generic;

namespace LikeTrackingSystem.LikeCounter.Repository
{
    /// <summary>
    /// Repository for like events.
    /// </summary>
    public interface ILikeEventRepository
    {
        /// <summary>
        /// Counts the event as a new like.
        /// </summary>
        /// <param name="articleEvent"></param>
        /// <returns>True if the article was added; false if it already existed</returns>
        bool AddEvent(ArticleLikeEvent articleEvent);
    }
}
