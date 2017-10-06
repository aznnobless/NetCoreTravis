using System;
using Xunit;

namespace MyService.Test
{
    public class MyServiceTest
    {
        private readonly MyService _myService;

        public MyServiceTest()
        {
            _myService = new MyService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf()
        {
            var result = _myService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, _myService.Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(5, _myService.Add(2, 2));            
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(9)]
        public void OddNumberCases(int value)
        {
            Assert.True(_myService.IsOdd(value));
        }

    }
}
