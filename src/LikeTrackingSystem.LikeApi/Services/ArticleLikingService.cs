using LikeTrackingSystem.Framework.Messaging;
using LikeTrackingSystem.LikeApi.Messaging;

namespace LikeTrackingSystem.LikeApi.Services
{
    /// <inheritdoc/>
    public class ArticleLikingService : IArticleLikingService
    {

        private readonly IMessagingBoard _messagingBoard;


        /// <summary>
        /// Constructor with injected dependencies for the <see cref="ArticleLikingService"/>.
        /// </summary>
        /// <param name="messagingBoard"></param>
        public ArticleLikingService(IMessagingBoard messagingBoard)
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
