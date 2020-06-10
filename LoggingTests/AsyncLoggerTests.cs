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
    public class AsyncLoggerTests
    {
        [Test()]
        public void AsyncLoggerTest()
        {
            Assert.IsNotNull(new AsyncLogger(new System.Collections.Concurrent.BlockingCollection<LogMessage>(), typeof(AsyncLoggerTests)));
        }

        [Test()]
        public void LogTest()
        {
            var logger = new AsyncLogger(new System.Collections.Concurrent.BlockingCollection<LogMessage>(), typeof(AsyncLoggerTests));            
            Assert.DoesNotThrow(() => logger.LogDebug("test"));
        }

        [Test()]
        public void IsEnabledTest()
        {
            var logger = new AsyncLogger(new System.Collections.Concurrent.BlockingCollection<LogMessage>(), typeof(AsyncLoggerTests));
            Assert.IsTrue(logger.IsEnabled(LogLevel.Debug));
        }
    }
}
