using System;

namespace LikeTrackingSystem.Framework.Logging
{
    public static class Log
    {
        public const string LOG_ID = "log";
        public const string ARTICLE = "art";

        public static ILogBook Null = new NullLog();

        public static ILogBook WithArticle(this ILogBook log, string articleId)
        {
            log.AddContext(ARTICLE, articleId);
            return log;
        }

        public static void Error(this ILogBook logBook, string message, Exception? exception = null)
            => logBook.Error(message, exception);
        public static void Debug(this ILogBook logBook, string message) => logBook.Debug(message);
        public static void Information(this ILogBook logBook, string message) => logBook.Information(message);
        public static void Warning(this ILogBook logBook, string message) => logBook.Warning(message);
        public static void Verbose(this ILogBook logBook, string message) => logBook.Verbose(message);
        
    }
}
