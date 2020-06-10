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
    public class ConsoleLogListenerTests
    {
        [Test()]
        public void LogTest()
        {
            var logger = new ConsoleLogListener();
            Assert.DoesNotThrow(() => logger.Log(new LogMessage(LogLevel.Debug, "test")));

        }
    }
}
