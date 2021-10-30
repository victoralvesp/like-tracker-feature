namespace LikeTrackingSystem.LikeCounter.Repository
{
    /// <summary>
    /// Repository for like counters.
    /// </summary>
    public interface ILikeCountRepository
    {
        /// <summary>
        /// Gets the like count for the specified article.
        /// </summary>
        /// <param name="articleId">Article's UUID </param>
        int LikeCount(string articleId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        int AtomicIncrement(string articleId);
    }

}
