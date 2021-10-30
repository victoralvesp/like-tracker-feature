using System.Collections.Generic;
using LikeTrackingSystem.Framework.Logging;
using LikeTrackingSystem.LikeCounter.Repository;

namespace LikeTrackingSystem.LikeCounter.Counter
{
    /// <summary>
    /// Counts article likes.
    /// </summary>
    public interface ILikeCounter
    {
        /// <summary>
        /// Number of likes for the article.
        /// </summary>
        /// <param name="articleEvent">Article event</param>
        /// <returns>Current count of likes for article</returns>
        int CountLikes(ArticleLikeEvent articleEvent);
    }

    /// <inheritdoc />
    public class SimpleLikeCounter : ILikeCounter
    {
        private readonly ILikeEventRepository _likeEventRepository;
        private readonly ILogBook _log;
        private readonly ILikeCountRepository _likeRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLikeCounter"/> class with injected dependencies
        /// </summary>
        /// <param name="likeRepository"></param>
        /// <param name="likeEventRepository"></param>
        public SimpleLikeCounter(ILikeCountRepository likeRepository, ILikeEventRepository likeEventRepository, ILogBook? log =null)
        {
            _likeEventRepository = likeEventRepository;
            _likeRepository = likeRepository;
            _log = log ?? Log.Null;
        }

        /// <inheritdoc />
        public int CountLikes(ArticleLikeEvent articleEvent)
        {
            _log.WithArticle(articleEvent.ArticleId)
                .Information("Counting likes for article");

            var likes = _likeRepository.LikeCount(articleEvent.ArticleId);
            var eventAdded = _likeEventRepository.AddEvent(articleEvent);
            if (eventAdded)
            {
                try
                {
                    _log.Information("New like found");
                    likes = _likeRepository.AtomicIncrement(articleEvent.ArticleId);
                }
                catch (System.Exception ex)
                {
                    _log.Error("Error ocurred when counting likes", ex);
                }
            }

            return likes;
        }
    }
}
