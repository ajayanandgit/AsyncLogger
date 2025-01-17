namespace Logging
{
    public static class LoggerExtensions
    {
        public static void LogDebug(this ILogger logger, string message)
        {
            logger.Log(new LogMessage(LogLevel.Debug, message));
        }

        public static void LogVerbose(this ILogger logger, string message)
        {
            logger.Log(new LogMessage(LogLevel.Verbose, message));
        }

        public static void LogInformation(this ILogger logger, string message)
        {
            logger.Log(new LogMessage(LogLevel.Information, message));
        }

        public static void LogWarning(this ILogger logger, string message)
        {
            logger.Log(new LogMessage(LogLevel.Warning, message));
        }

        public static void LogError(this ILogger logger, string message)
        {
            logger.Log(new LogMessage(LogLevel.Error, message));
        }

        public static void LogCritical(this ILogger logger, string message)
        {
            logger.Log(new LogMessage(LogLevel.Critical, message));
        }
    }
}