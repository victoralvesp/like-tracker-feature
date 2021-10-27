namespace LikeTrackingSystem.LikeTracker.Services
{
    /// <summary>
    /// Tracks like information
    /// </summary>
    public interface ITrackService
    {
        void UserLikedArticle(string articleId, string userId);
    }
}
