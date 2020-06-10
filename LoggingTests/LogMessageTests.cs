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
    public class LogMessageTests
    {
        [Test()]
        public void LogMessageTest()
        {
            Assert.IsNotNull(new LogMessage(LogLevel.Debug, "test"));
        }

        [Test()]
        public void ToStringTest()
        {
            Assert.IsNotNull(new LogMessage(LogLevel.Debug, "test").ToString());
        }
    }
}
