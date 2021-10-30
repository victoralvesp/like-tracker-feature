using System;
using System.Linq;
using LikeTrackingSystem.Framework.Messaging;
using LikeTrackingSystem.LikeTracker.Messaging;
using LikeTrackingSystem.LikeTracker.Models;
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

        /// <summary>
        /// Checks if user liked the article
        /// </summary>
        /// <param name="articleId">Article's UUID Identifier</param>
        /// <param name="userId">User's UUID Identifier</param>
        UserLikedArticle? GetLikeInfo(string articleId, string userId);
    }

    /// <inheritdoc/>
    public class TrackService : ITrackService
    {
        private readonly IArticleLikeRepository _likeRepository;
        private readonly IMessagingBoard _messagingBoard;

        /// <summary>
        /// Constructs a new TrackService with injected dependencies
        /// </summary>
        /// <param name="likeRepository"></param>
        /// <param name="messagingBoard"></param>
        public TrackService(IArticleLikeRepository likeRepository, IMessagingBoard messagingBoard)
        {
            _likeRepository = likeRepository;
            _messagingBoard = messagingBoard;
        }


        /// <inheritdoc/>
        public UserLikedArticle? GetLikeInfo(string articleId, string userId)
        {
            var userLikeInfo = _likeRepository.LikesFor(articleId).Where(info => info.UserId == userId).FirstOrDefault();

            if (userLikeInfo is null)
            {
                return null;
            }

            return new()
            {
                UserId = Guid.Parse(userId),
                ArticleId = Guid.Parse(articleId),
                HasLiked = userLikeInfo.HasLiked,
                LastUpdate = userLikeInfo.UpdateDate
            };

        }

        /// <inheritdoc/>
        public void UserLikedArticle(string articleId, string userId)
        {
            _likeRepository.AddUserLike(articleId, userId);
            _messagingBoard.Publish(new ArticleLikedMessage(articleId, userId));
        }
    }
}
