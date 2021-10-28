using System.Collections.Generic;
using System.IO;
using System.Text;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;
using Serilog.Sinks.SystemConsole.Themes;

namespace LikeTrackingSystem.Framework.Logging
{
    /// <summary>
    /// Defines a log that can receive contextual information
    /// </summary>
    public interface ILogBook : ILogger
    {
        /// <summary>
        /// Enrich the log with the provided property
        /// </summary>
        /// <param name="enricher"></param>
        void AddContext(ILogEventEnricher enricher);

        /// <summary>
        /// Enrich the log with the provided property enrichers
        /// </summary>
        /// <param name="enricher"></param>
        void AddContext(IEnumerable<ILogEventEnricher> enrichers);

        /// <summary>
        /// Enriches log events with the specified property
        /// </summary>
        /// <param name="propertyName">Property's name. Must be non-empty</param>
        /// <param name="value">Property's value.</param>
        /// <param name="destructureObjects">If true, the value will be serialized as a structured object if possible; if false, the object will be recorded as a scalar or simple array</param>
        void AddContext(string propertyName, object value, bool destructureObjects = false);

    }

    internal class DefaultTextFormatter : ITextFormatter
    {
        public void Format(LogEvent logEvent, TextWriter output)
        {
            var theme = AnsiConsoleTheme.Code;
            var logStringBuilder = new StringBuilder();
            foreach (var property in logEvent.Properties)
            {
                if (property.Value is not null)
                {
                    var key = property.Key[..3].ToLower();
                    logStringBuilder.Append($" [{key}:{property.Value}");
                }
            }
            theme.Set(output, getStyle(logEvent.Level));
            if (logEvent.Exception != null)
            {
                theme.Set(output, ConsoleThemeStyle.SecondaryText);
                output.Write(logEvent.Exception);
            }
            theme.Reset(output);

            static ConsoleThemeStyle getStyle(LogEventLevel level)
            => level switch
            {
                LogEventLevel.Verbose => ConsoleThemeStyle.LevelVerbose,
                LogEventLevel.Debug => ConsoleThemeStyle.LevelDebug,
                LogEventLevel.Information => ConsoleThemeStyle.LevelInformation,
                LogEventLevel.Warning => ConsoleThemeStyle.LevelWarning,
                LogEventLevel.Error => ConsoleThemeStyle.LevelError,
                LogEventLevel.Fatal => ConsoleThemeStyle.LevelFatal,
                _ => ConsoleThemeStyle.Null
            };
        }
    }
}
