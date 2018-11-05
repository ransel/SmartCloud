using System.Collections.Generic;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using SmartCloud.Services.Interfaces;

namespace SmartCloud.Services
{
    public class LoggingService : ILoggingService
    {
        private readonly TelemetryClient _telemetryClient;

        public LoggingService(TelemetryClient telemetryClient)
        {
            _telemetryClient = telemetryClient;
        }

        public void LogInfo(string message)
        {
            TrackTrace(message, SeverityLevel.Information, null);
        }

        public void LogInfo(string message, IDictionary<string, string> properties)
        {
            TrackTrace(message, SeverityLevel.Information, properties);
        }

        public void LogWarning(string message)
        {
            TrackTrace(message, SeverityLevel.Warning, null);
        }

        public void LogWarning(string message, IDictionary<string, string> properties)
        {
            TrackTrace(message, SeverityLevel.Warning, properties);
        }

        public void LogError(string message)
        {
            TrackTrace(message, SeverityLevel.Error, null);
        }

        public void LogError(string message, IDictionary<string, string> properties)
        {
            TrackTrace(message, SeverityLevel.Error, properties);
        }

        public void LogCritical(string message)
        {
            TrackTrace(message, SeverityLevel.Critical, null);
        }

        public void LogCritical(string message, IDictionary<string, string> properties)
        {
            TrackTrace(message, SeverityLevel.Critical, properties);
        }

        private void TrackTrace(string message, SeverityLevel severity, IDictionary<string, string> properties)
        {
            if (properties != null)
            {
                _telemetryClient.TrackTrace(message, severity, properties);
            }
            else
            {
                _telemetryClient.TrackTrace(message, severity);
            }
        }
    }
}