using LikeTrackingSystem.Framework.Messaging;

namespace LikeTrackingSystem.LikeApi.Messaging
{
    /// <summary>
    /// Represents and event of an article being liked.
    /// </summary>
    /// <param name="ArticleId"></param>
    /// <param name="UserId"></param>
    public record LikeArticleMessage(string ArticleId, string UserId) : IMessage
    {
        ///<inheritdoc/>
        public string MessageType => "LikeArticle";
    }
    
}
