using System;
using LikeTrackingSystem.Framework.Messaging;

namespace LikeTrackingSystem.LikeTracker.Messaging
{
    /// <summary>
    /// Message that a user liked (or removed a like) an article.
    /// </summary>
    /// <param name="ArticleId">Target article</param>
    /// <param name="UserId">User that made the action</param>
    public record ArticleLikedMessage(string ArticleId, string UserId) : IMessage
    {
        /// <inheritdoc/>
        public string MessageType => "ArticleLikedMessage";

        /// <inheritdoc/>
        public long Timestamp { get; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }
}
