namespace LikeTrackingSystem.LikeApi.Options
{
    /// <summary>
    /// Defines options for the Counter service.
    /// </summary>
    public class CounterServiceConfig
    {
        /// <summary>
        /// Section on appsettings
        /// </summary>
        public const string SECTION = "Counter";

        /// <summary>
        /// Service Url
        /// </summary>
        /// <value></value>
        public string Url { get; set; } = "http://localhost:8080/";
    }
}
