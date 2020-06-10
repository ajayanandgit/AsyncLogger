using System;

namespace Logging
{
    public class ConsoleLogListener : ILogListener
    {
        public void Log(LogMessage message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
