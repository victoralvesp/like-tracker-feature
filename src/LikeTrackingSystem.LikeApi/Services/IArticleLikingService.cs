namespace LikeTrackingSystem.LikeApi.Services
{

    /// <summary>
    /// Provides methods for working with articles.
    /// </summary>
    public interface IArticleLikingService
    {
        /// <summary>
        /// Informs the service that the user with the specified <paramref name="userId"/> has liked the article with the specified <paramref name="articleId"/>.
        /// </summary>
        /// <param name="articleId">The Article UUID Identifier </param>
        /// <param name="userId">The User UUID Identifier</param>
        void LikeArticle(string articleId, string userId);

        
    }
}
