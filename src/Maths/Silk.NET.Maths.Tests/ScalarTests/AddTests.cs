// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Xunit;

namespace Silk.NET.Maths.Tests.ScalarTests
{
    public sealed class AddTests
    {
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(byte.MinValue, byte.MaxValue, 1)]
        public void Byte(byte expected, byte a, byte b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(-2, -1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(-1, -2, 1)]
        [InlineData(sbyte.MinValue, sbyte.MaxValue, 1)]
        public void SByte(sbyte expected, sbyte a, sbyte b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(ushort.MinValue, ushort.MaxValue, 1)]
        public void UShort(ushort expected, ushort a, ushort b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(-2, -1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(-1, -2, 1)]
        [InlineData(short.MinValue, short.MaxValue, 1)]
        public void Short(short expected, short a, short b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(uint.MinValue, uint.MaxValue, 1)]
        public void UInt(uint expected, uint a, uint b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(-2, -1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(-1, -2, 1)]
        [InlineData(int.MinValue, int.MaxValue, 1)]
        public void Int(int expected, int a, int b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(ulong.MinValue, ulong.MaxValue, 1)]
        public void ULong(ulong expected, ulong a, ulong b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(-2, -1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(-1, -2, 1)]
        [InlineData(long.MinValue, long.MaxValue, 1)]
        public void Long(long expected, long a, long b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }

#if HALF_TESTS
        [Theory]
        [InlineData(2f, 1f, 1f)]
        [InlineData(-2f, -1f, -1f)]
        [InlineData(0f, -1f, 1f)]
        [InlineData(-1f, -2f, 1f)]
        [InlineData(float.NaN, float.NaN, 1)]
        public void Half(Half expected, Half a, Half b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
#endif
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(-2, -1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(-1, -2, 1)]
        [InlineData(float.NaN, float.NaN, 1)]
        public void Float(float expected, float a, float b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(-2, -1, -1)]
        [InlineData(0, -1, 1)]
        [InlineData(-1, -2, 1)]
        [InlineData(double.NaN, double.NaN, 1)]
        public void Double(double expected, double a, double b)
        {
            var actual = Scalar.Add(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
