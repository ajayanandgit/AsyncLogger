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
    public class LoggerFactoryTests
    {
        [Test()]
        public void LoggerFactoryTest()
        {
            Assert.IsNotNull(new LoggerFactory(new System.Collections.Concurrent.BlockingCollection<LogMessage>()));
        }

        [Test()]
        public void ForTest()
        {
            var factory = new LoggerFactory(new System.Collections.Concurrent.BlockingCollection<LogMessage>());
            Assert.IsNotNull(factory.For(typeof(LoggerFactoryTests)));
        }
    }
}
