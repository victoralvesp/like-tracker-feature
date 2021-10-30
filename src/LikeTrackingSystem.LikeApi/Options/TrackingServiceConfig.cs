namespace LikeTrackingSystem.LikeApi.Options
{
    /// <summary>
    /// Defines options for the tracking service.
    /// </summary>
    public class TrackingServiceConfig
    {
        /// <summary>
        /// Section on appsettings
        /// </summary>
        public const string SECTION = "Tracking";

        /// <summary>
        /// Service Url
        /// </summary>
        /// <value></value>
        public string Url { get; set; } = "http://localhost:8100/";
    }
}
