using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging;
using NUnit.Framework;
namespace Logging.Tests
{
    [TestFixture()]
    public class LoggerExtensionsTests
    {
        [Test()]
        public void LogDebugTest()
        {
            var logger = new AsyncLogger(new System.Collections.Concurrent.BlockingCollection<LogMessage>(), typeof(AsyncLoggerTests));
            Assert.DoesNotThrow(() => logger.LogDebug("test"));
        }

        [Test()]
        public void LogVerboseTest()
        {
            var logger = new AsyncLogger(new System.Collections.Concurrent.BlockingCollection<LogMessage>(), typeof(AsyncLoggerTests));
            Assert.DoesNotThrow(() => logger.LogVerbose("test"));

        }

        [Test()]
        public void LogInformationTest()
        {
            var logger = new AsyncLogger(new System.Collections.Concurrent.BlockingCollection<LogMessage>(), typeof(AsyncLoggerTests));
            Assert.DoesNotThrow(() => logger.LogInformation("test"));

        }

        [Test()]
        public void LogWarningTest()
        {

            var logger = new AsyncLogger(new System.Collections.Concurrent.BlockingCollection<LogMessage>(), typeof(AsyncLoggerTests));
            Assert.DoesNotThrow(() => logger.LogWarning("test"));
        }

        [Test()]
        public void LogErrorTest()
        {
            var logger = new AsyncLogger(new System.Collections.Concurrent.BlockingCollection<LogMessage>(), typeof(AsyncLoggerTests));
            Assert.DoesNotThrow(() => logger.LogError("test"));

        }

        [Test()]
        public void LogCriticalTest()
        {
            var logger = new AsyncLogger(new System.Collections.Concurrent.BlockingCollection<LogMessage>(), typeof(AsyncLoggerTests));
            Assert.DoesNotThrow(() => logger.LogCritical("test"));

        }
    }
}
