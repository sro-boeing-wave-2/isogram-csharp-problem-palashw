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
            Assert.Equal(1, isogram.Check_isogram("palish"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(0, isogram.Check_isogram("palash"));
        }
    }
}
