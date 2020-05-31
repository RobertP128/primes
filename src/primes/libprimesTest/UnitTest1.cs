using System;
using Xunit;
using libprimes;

namespace libprimesTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0,false,1)]
        [InlineData(1, false,1)]
        [InlineData(2, true,1)]
        [InlineData(3, true,1)]
        [InlineData(4, false,2)]
        [InlineData(5, true,1)]
        [InlineData(6, false,2)]
        public void Test1(int n , bool isPrime,int firstFactorExpected)
        {
            Prime pr = new Prime();
            bool result= pr.IsPrime(n,out int firstFactor);

            Assert.Equal(isPrime,result);
            Assert.Equal(firstFactorExpected, firstFactor);

        }
    }
}
