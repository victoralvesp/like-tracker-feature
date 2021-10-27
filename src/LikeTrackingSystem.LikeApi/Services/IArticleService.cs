namespace LikeTrackingSystem.LikeApi.Services
{
    /// <summary>
    /// Provides methods for working with articles.
    /// </summary>
    public interface IArticleService
    {
        void LikeArticle(string articleId, string userId);
    }
}