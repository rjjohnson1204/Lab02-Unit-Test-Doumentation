using System;
using unit_test;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //Testing of deposit method
        [Fact]
        public void Addition1()
        {   // test to see if 200 + 100 = 300
            Assert.Equal(300, (int)Program.Deposit(200, 100));
        }

        [Fact]
        public void Addition2()
        { //test if 1000 + 234 = 1234
            Assert.Equal(1234, (int)Program.Deposit(1000, 234));
        }

        [Fact]
        public void Addition3()
        { //test if 369 + 234 = 603
            Assert.Equal(603, (int)Program.Deposit(369, 234));
        }



        //Testing of withdraw method
        [Fact]
        public void Subtraction1()
        {   // test to see if 200 - 100 = 100
            Assert.Equal(100, (int)Program.Withdrawl(200, 100));
        }

        [Fact]
        public void Subtraction2()
        { //test if 1000 - 234 = 1234
            Assert.Equal(766, (int)Program.Withdrawl(1000, 234));
        }

        [Fact]
        public void Subtraction3()
        { //test if 1000 - 1000 = 0
            Assert.Equal(0, (int)Program.Withdrawl(1000, 1000));
        }
    }

}