using System;
using System.Threading;

namespace Logging
{
    public sealed class LogMessage
    {
        public readonly DateTime Timestamp;
        public readonly string ThreadId;
        public readonly string Message;
        public LogLevel Level { get; set; }

        public LogMessage(LogLevel level, string message)
        {
            Timestamp = DateTime.UtcNow;
            var thread = Thread.CurrentThread;
            ThreadId = string.IsNullOrEmpty(thread.Name) ? thread.ManagedThreadId.ToString() : thread.Name;
            Level = level;
            Message = message;
        }

        public override string ToString()
        {
            return string.Format("{0:yyyy/MM/dd HH:mm:ss.fff} {1} {2} {3}", 
                Timestamp, ThreadId, Level, Message);
        }
    }
}
