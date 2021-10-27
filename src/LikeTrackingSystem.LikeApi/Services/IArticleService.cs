using LikeTrackingSystem.Framework.Messaging;
using LikeTrackingSystem.LikeApi.Messaging;

namespace LikeTrackingSystem.LikeApi.Services
{
    /// <summary>
    /// Provides methods for working with articles.
    /// </summary>
    public interface IArticleService
    {
        /// <summary>
        /// Informs the service that the user with the specified <paramref name="userId"/> has liked the article with the specified <paramref name="articleId"/>.
        /// </summary>
        /// <param name="articleId">The Article UUID Identifier </param>
        /// <param name="userId">The User UUID Identifier</param>
        void LikeArticle(string articleId, string userId);
    }

    /// <inheritdoc/>
    public class ArticleService : IArticleService
    {

        private readonly IMessagingBoard _messagingBoard;

        /// <summary>
        /// Constructor with injected dependencies for the <see cref="ArticleService"/>.
        /// </summary>
        /// <param name="messagingBoard"></param>
        public ArticleService(IMessagingBoard messagingBoard)
        {
            _messagingBoard = messagingBoard;
        }

        /// <inheritdoc/>
        public void LikeArticle(string articleId, string userId)
        {
            var likeArticleMessage = new LikeArticleMessage(articleId, userId);
            _messagingBoard.Publish(likeArticleMessage);
        }
    }
}
