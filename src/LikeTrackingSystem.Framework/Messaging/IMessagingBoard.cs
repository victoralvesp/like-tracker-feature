namespace LikeTrackingSystem.Framework.Messaging
{
    /// <summary>
    /// A messaging board is a place where messages can be posted and received.
    /// </summary>
    public interface IMessagingBoard
    {
        /// <summary>
        /// Posts a message to the board.
        /// </summary>
        /// <param name="message">The posted message</param>
        void Publish(IMessage message);
    }
}
