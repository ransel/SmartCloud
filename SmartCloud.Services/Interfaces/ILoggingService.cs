using System.Collections.Generic;

namespace SmartCloud.Services.Interfaces
{
    public interface ILoggingService
    {
        void LogInfo(string message);
        void LogInfo(string message, IDictionary<string, string> properties);
        void LogWarning(string message);
        void LogWarning(string message, IDictionary<string, string> properties);
        void LogError(string message);
        void LogError(string message, IDictionary<string, string> properties);
        void LogCritical(string message);
        void LogCritical(string message, IDictionary<string, string> properties);
    }
}