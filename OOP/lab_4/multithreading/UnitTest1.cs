using System;
using Xunit;
using System.Threading;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            EventLoopTest test = new EventLoopTest();
            test.names = new string[] { "Foo", "Foo2", "exit" };
            test.indexRead = 0;
            test.indexWrite = 0;

            test.Threadmain();

            Assert.Equal(3, test.indexWrite);
            Assert.Equal(3, test.indexRead);
        }
    }

    public class EventLoopTest : EventLoop
    {
        public string[] names;
        public int indexRead = 0;
        public int indexWrite = 0;

        public override string ReadLine()
        {
            Thread.Sleep(100);
            return names[indexRead++];
        }

        public override void WriteLine(string str)
        {
            indexWrite++;
        }
    }
}
