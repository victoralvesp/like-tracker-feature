namespace LikeTrackingSystem.Framework.Messaging
{
    /// <summary>
    /// A representation of a async communication message that can be sent to a recipient.
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Represents the message type.
        /// </summary>
        /// <value></value>
        string MessageType { get; }
        
        /// <summary>
        /// An Unix Epoch timestamp of when the message was created.
        /// </summary>
        /// <value></value>
        long Timestamp { get; }
    }
}
