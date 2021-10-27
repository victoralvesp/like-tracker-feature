namespace LikeTrackingSystem.LikeTracker.Services
{
    /// <summary>
    /// Tracks like information
    /// </summary>
    public interface ITrackService
    {
        /// <summary>
        /// Tracks a new like from a user
        /// </summary>
        /// <param name="articleId">Article's UUID Identifier</param>
        /// <param name="userId">User's UUID Identifier</param>
        void UserLikedArticle(string articleId, string userId);
    }
}
