using System;

namespace Logging
{
    public interface ILoggerFactory
    {
        ILogger For(Type loggerFor);
    }
}
