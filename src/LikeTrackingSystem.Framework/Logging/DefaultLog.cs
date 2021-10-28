using System;
using System.Collections.Generic;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace LikeTrackingSystem.Framework.Logging
{
    /// <inheritdoc/>
    public class DefaultLog : ILogBook
    {
        private ILogger _logger = Serilog.Log.ForContext(Log.LOG_ID, Guid.NewGuid().ToString("n"));

        /// <inheritdoc/>
        public void AddContext(ILogEventEnricher enricher)
        => _logger.ForContext(enricher);

        /// <inheritdoc/>
        public void AddContext(IEnumerable<ILogEventEnricher> enrichers)
        => _logger = _logger.ForContext(enrichers);

        /// <inheritdoc/>
        public void AddContext(string propertyName, object value, bool destructureObjects = false)
        => _logger = _logger.ForContext(propertyName, value, destructureObjects);

        /// <inheritdoc/>
        public void Write(LogEvent logEvent) => _logger.Write(logEvent);
        
    }
}
