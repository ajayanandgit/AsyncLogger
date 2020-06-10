using System;
using System.Collections.Concurrent;

namespace Logging
{
    public class LoggerFactory : ILoggerFactory
    {
        private readonly BlockingCollection<LogMessage> _pendingMessages;
        private readonly ConcurrentDictionary<Type, ILogger> _loggersCache = new ConcurrentDictionary<Type, ILogger>();
        
        public LoggerFactory(BlockingCollection<LogMessage> pendingMessages)
        {
            _pendingMessages = pendingMessages;
        }

        public ILogger For(Type loggerFor)
        {
            return _loggersCache.GetOrAdd(loggerFor, new AsyncLogger(_pendingMessages, loggerFor));
        }
    }
}
