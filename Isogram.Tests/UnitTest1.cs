using System;
using Xunit;
using isogram_csharp_problem;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, isogram.Check_isogram(""));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(1, isogram.Check_isogram("isogram"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(0, isogram.Check_isogram("eleven"));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(1, isogram.Check_isogram("subdermatoglyphic"));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(1, isogram.Check_isogram("Alphabet"));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(1, isogram.Check_isogram("thumbscrew-japingly"));
        }

        [Fact]
        public void Test7()
        {
            Assert.Equal(0, isogram.Check_isogram("six-year-old"));
        }

        [Fact]
        public void Test8()
        {
            Assert.Equal(0, isogram.Check_isogram("vin diesel"));
        }
    }
}
