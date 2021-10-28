using System.Collections.Generic;

namespace LikeTrackingSystem.LikeCounter.Repository
{
    /// <summary>
    /// Repository for like events.
    /// </summary>
    public interface ILikeEventRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ArticleLikeEvent> NewEvents();
    }
}
