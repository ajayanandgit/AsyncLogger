using System;
using System.Collections.Concurrent;

namespace Logging
{
    public class AsyncLogger : ILogger
    {
        private readonly BlockingCollection<LogMessage> _pendingMessages;
        private readonly Type _loggerFor;

        public AsyncLogger(BlockingCollection<LogMessage> pendingMessages, Type loggerFor)
        {
            _pendingMessages = pendingMessages;
            _loggerFor = loggerFor;
        }

        public void Log(LogMessage log)
        {
            _pendingMessages.Add(log);
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }
    }
}
