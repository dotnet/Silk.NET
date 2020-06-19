using System;
using AutoFixture;
using Silk.NET.Maths;
using Xunit;
using FluentAssertions;


namespace Silk.Net.Maths.Tests
{
    public class ByteScalarTests : UnsignedScalarTests<byte> { }
    public class SByteScalarTests : SignedScalarTests<sbyte> { }
    public class UShortScalarTests : UnsignedScalarTests<ushort> { }
    public class ShortScalarTests : SignedScalarTests<short> { }
    public class UIntScalarTests : UnsignedScalarTests<uint> { }
    public class IntScalarTests : SignedScalarTests<int> { }
    public class ULongScalarTests : UnsignedScalarTests<ulong> { }
    public class LongScalarTests : SignedScalarTests<long> { }

    public class HalfScalarTests : SignedScalarTests<Half>
    {
        [Fact]
        public Half PositiveInfinityDoesNotThrow()
        {
            return Scalar<Half>.PositiveInfinity;
        }
        [Fact]
        public Half NegativeInfinityDoesNotThrow()
        {
            return Scalar<Half>.NegativeInfinity;
        }
    }
    public class FloatScalarTests : SignedScalarTests<float> 
    {
        [Fact]
        public float PositiveInfinityDoesNotThrow()
        {
            return Scalar<float>.PositiveInfinity;
        }
        [Fact]
        public float NegativeInfinityDoesNotThrow()
        {
            return Scalar<float>.NegativeInfinity;
        }
    }
    public class DoubleScalarTests : SignedScalarTests<double>  
    {
        [Fact]
        public double PositiveInfinityDoesNotThrow()
        {
            return Scalar<double>.PositiveInfinity;
        }
        [Fact]
        public double NegativeInfinityDoesNotThrow()
        {
            return Scalar<double>.NegativeInfinity;
        }
    }

    public abstract class SignedScalarTests<T> : UnsignedScalarTests<T>
        where T : unmanaged, IFormattable
    {
        [Theory]
        [InlineData(1, -1)]
        [InlineData(-1, 1)]
        public void Negate(T value, T expected)
        {
            Scalar<T>.Negate(value).Should().Be(expected);
        }
    }

    public abstract class UnsignedScalarTests<T>
        where T : unmanaged, IFormattable
    {
        [Theory]
        [InlineData(1, 1, 2)]
        public void Add(T a, T b, T expected)
        {
            Scalar<T>.Add(a, b).Should().Be(expected);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        public void Subtract(T a, T b, T expected)
        {
            Scalar<T>.Subtract(a, b).Should().Be(expected);
        }

        [Theory]
        [InlineData(3, 3, 9)]
        public void Multiply(T a, T b, T expected)
        {
            Scalar<T>.Multiply(a, b).Should().Be(expected);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        public void Divide(T a, T b, T expected)
        {
            Scalar<T>.Divide(a, b).Should().Be(expected);
        }

        [Theory]
        [InlineData(9, 3)]
        public void SquareRoot(T value, T expected)
        {
            Scalar<T>.SquareRoot(value).Should().Be(expected);
        }

        [Theory]
        [InlineData(6, 3, 3)]
        [InlineData(0, 3, 0)]
        public void Min(T a, T b, T expected)
        {
            Scalar<T>.Min(a, b).Should().Be(expected);
        }

        [Theory]
        [InlineData(6, 3, 6)]
        [InlineData(0, 3, 3)]
        public void Max(T a, T b, T expected)
        {
            Scalar<T>.Max(a, b).Should().Be(expected);
        }


        [Theory]
        [InlineData(6, 3, true)]
        [InlineData(0, 3, false)]
        public void Larger(T a, T b, bool expected)
        {
            Scalar<T>.Larger(a, b).Should().Be(expected);
        }


        [Theory]
        [InlineData(6, 3, false)]
        [InlineData(0, 3, true)]
        public void Smaller(T a, T b, bool expected)
        {
            Scalar<T>.Smaller(a, b).Should().Be(expected);
        }


        [Theory]
        [InlineData(6, 3, true)]
        [InlineData(0, 3, false)]
        [InlineData(6, 6, true)]
        public void LargerEquals(T a, T b, bool expected)
        {
            Scalar<T>.LargerEquals(a, b).Should().Be(expected);
        }


        [Theory]
        [InlineData(6, 3, false)]
        [InlineData(0, 3, true)]
        [InlineData(6, 6, true)]
        public void SmallerEquals(T a, T b, bool expected)
        {
            Scalar<T>.SmallerEquals(a, b).Should().Be(expected);
        }

        [Theory]
        [InlineData(0, 2, 3, 2)]
        [InlineData(3, 1, 5, 3)]
        [InlineData(9, 0, 5, 5)]
        public void Clamp(T a, T b, T c, T expected)
        {
            Scalar<T>.Clamp(a, b, c).Should().Be(expected);
        }


        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(8, 1, false)]
        public void Equal(T a, T b, bool expected)
        {
            Scalar<T>.Equal(a, b).Should().Be(expected);
        }
        
        [Fact]
        public void ThrowIndexOutOfRangeThrows()
        {
            Assert.Throws<IndexOutOfRangeException>(Scalar<T>.ThrowIndexOutOfRange);
        }
        
        [Fact]
        public void ThrowVectorTTooSmall()
        {
            Assert.Throws<NotSupportedException>(Scalar<T>.ThrowVectorTTooSmall);
        }
        
        [Fact]
        public void ThrowNotSupportedByUnderlying()
        {
            Assert.Throws<NotSupportedException>(Scalar<T>.ThrowNotSupportedByUnderlying);
        }

        [Fact]
        public void DoesNotThrowForUnsupportedBaseType()
        {
            Scalar<T>.ThrowForUnsupportedBaseType();
        }

        [Fact]
        public T OneDoesNotThrow()
        {
            return Scalar<T>.One;
        }
        
        [Fact]
        public T TwoDoesNotThrow()
        {
            return Scalar<T>.Two;
        }
    }

    public class ScalarNotSupportedTests
    {
        // DateTime is struct, IFormattable, and will never used

        [Fact]
        public void Add()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Add(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }


        [Fact]
        public void Clamp()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
            (
                () => Scalar<DateTime>.Clamp
                    (fixture.Create<DateTime>(), fixture.Create<DateTime>(), fixture.Create<DateTime>())
            );
        }

        [Fact]
        public void Divide()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Divide(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }


        [Fact]
        public void Equal()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Equal(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Larger()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Larger(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void LargerEquals()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.LargerEquals(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Max()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Max(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }


        [Fact]
        public void Min()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Min(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Multiply()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Multiply(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Negate()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Negate(fixture.Create<DateTime>()));
        }

        [Fact]
        public void Smaller()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Smaller(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }


        [Fact]
        public void SmallerEquals()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.SmallerEquals(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Subtract()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar<DateTime>.Subtract(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }
    }
}
