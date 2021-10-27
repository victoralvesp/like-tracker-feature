namespace LikeTrackingSystem.Framework.Messaging
{
    public interface IMessagingBoard
    {
        void Publish(IMessage likeArticleMessage);
    }

    public interface IMessage
    {
        /// <summary>
        /// Represents the message type.
        /// </summary>
        /// <value></value>
        string MessageType { get; }
    }
}