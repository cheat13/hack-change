using System;
using Xunit;
using Change.lib;

namespace Change.test
{
    public class ChangeTest
    {
        [Fact]
        public void calculate()
        {
            var sut = new CalculateChanges();
            var result = sut.calculate(1000, 650);
            Assert.Equal(350, result.Change);
        }

        [Fact]
        public void Change1000()
        {
            var sut = new CalculateChanges();
            var result = sut.Banks;
            Assert.Equal(new int[] { 1000, 500, 100, 50, 20, 5, 1 }, result);
        }

        [Theory]
        [InlineData(2999,1000,1999,1,1,4,1,2,1,4)]
        [InlineData(3124,1000,2124,2,0,1,0,1,0,4)]
        public void Calculate(int pay,int amount,int expChange,int exp1000,int exp500,int exp100,int exp50,int exp20,int exp5,int exp1 )
        {
            var sut = new CalculateChanges();
            var result = sut.calculate(pay, amount);
            Assert.Equal(expChange, result.Change);
            Assert.Equal(exp1000, result.Thounsand);
            Assert.Equal(exp500, result.FiveHundred);
            Assert.Equal(exp100, result.OneHundred);
            Assert.Equal(exp50, result.Fifty);
            Assert.Equal(exp20, result.Twenty);
            Assert.Equal(exp5, result.Five);
            Assert.Equal(exp1, result.One);
        }

    }
}
