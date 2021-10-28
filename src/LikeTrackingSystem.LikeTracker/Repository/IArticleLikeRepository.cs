namespace LikeTrackingSystem.LikeTracker.Repository
{
    /// <summary>
    /// Like information repository
    /// /// </summary>
    public interface IArticleLikeRepository
    {
        /// <summary>
        /// Adds the user defined by the <paramref name="userId"/> to the list of likes for the specified <paramref name="articleId"/>.
        /// </summary>
        /// <param name="articleId"></param>
        /// <param name="userId"></param>
        void AddUserLike(string articleId, string userId);
    }
}
