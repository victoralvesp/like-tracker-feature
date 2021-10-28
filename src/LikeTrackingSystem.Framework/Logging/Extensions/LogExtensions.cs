using System;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;

namespace LikeTrackingSystem.Framework.Logging.Extensions
{
    public static class LogExtensions
    {
        public static HostBuilderContext ConfigureLogging(this HostBuilderContext hostContext, LoggerConfiguration loggerConfiguration, ITextFormatter? formatter = null, Func<LogEvent, bool>? filter = null)
        {
            filter ??= (_) => false;
            if (hostContext == null)
            {
                throw new ArgumentNullException(nameof(hostContext));
            }
            {
                if (hostContext is null)
                {
                    throw new ArgumentNullException(nameof(hostContext));
                }

                if (loggerConfiguration is null)
                {
                    throw new ArgumentNullException(nameof(loggerConfiguration));
                }

                if (!Enum.TryParse(hostContext.Configuration["Application:LogLevel"], out LogEventLevel minimumLevel))
                {
                    minimumLevel = LogEventLevel.Information;

                }

                var logLevelSwitch = new LoggingLevelSwitch(minimumLevel);
                loggerConfiguration
                    .MinimumLevel.ControlledBy(logLevelSwitch)
                    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                    .Enrich.FromLogContext()
                    .Enrich.WithDemystifiedStackTraces()
                    .WriteTo.Console(formatter ?? new DefaultTextFormatter())
                    .Filter.ByExcluding(filter);

            }

            return hostContext;
        }
    }
}
