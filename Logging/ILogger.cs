using System;

namespace Logging
{
    public interface ILogger
    {
        void Log(LogMessage log);
        
        bool IsEnabled(LogLevel logLevel);
    }
}
