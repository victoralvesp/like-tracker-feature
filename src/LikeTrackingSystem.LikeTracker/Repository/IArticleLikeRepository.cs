using System;
using System.Collections.Generic;

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

        /// <summary>
        /// User Ids of the users who liked the specified <paramref name="articleId"/>.
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        IEnumerable<LikeInfoDto> LikesFor(string articleId);
    }

    /// <summary>
    /// Data transfer object for the like information
    /// </summary>
    public class LikeInfoDto
    {
        /// <summary>
        /// User id of the user who liked the article
        /// </summary>
        /// <value></value>
        public string UserId { get; init; } = string.Empty;

        /// <summary>
        /// The date of the last update
        /// </summary>
        /// <value></value>
        public DateTime UpdateDate { get; init; } = DateTime.Now; 


        /// <summary>
        /// User has liked the article
        /// </summary>
        /// <value></value>
        public bool HasLiked { get; init; }
        
    }
}
