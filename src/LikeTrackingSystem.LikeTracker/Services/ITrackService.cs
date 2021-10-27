using LikeTrackingSystem.Framework.Messaging;
using LikeTrackingSystem.LikeTracker.Messaging;
using LikeTrackingSystem.LikeTracker.Repository;

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

    /// <inheritdoc/>
    public class TrackService : ITrackService
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMessagingBoard _messagingBoard;

        /// <summary>
        /// Constructs a new TrackService with injected dependencies
        /// </summary>
        /// <param name="likeRepository"></param>
        /// <param name="messagingBoard"></param>
        public TrackService(ILikeRepository likeRepository, IMessagingBoard messagingBoard)
        {
            _likeRepository = likeRepository;
            _messagingBoard = messagingBoard;
        }

        /// <inheritdoc/>
        public void UserLikedArticle(string articleId, string userId)
        {
            _likeRepository.AddUserLike(articleId, userId);
            _messagingBoard.Publish(new ArticleLikedMessage(articleId, userId));
        }
    }
}
