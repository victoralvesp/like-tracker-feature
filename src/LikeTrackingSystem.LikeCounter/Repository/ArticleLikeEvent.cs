namespace LikeTrackingSystem.LikeCounter.Repository
{
    /// <summary>
    /// Represents a like event of an article.
    /// </summary>
    /// <param name="ArticleId">Li</param>
    /// <param name="EventType"></param>
    /// <param name="EventHash"></param>
    /// <returns></returns>
    public record ArticleLikeEvent(string ArticleId, string EventType, string EventHash);
}
