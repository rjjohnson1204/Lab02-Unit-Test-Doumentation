using System;
using Xunit;
using unit_test;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Addition()
        {
            Assert.Equal(300, (int)Program.Deposit(200, 100));
        }
    }
}
