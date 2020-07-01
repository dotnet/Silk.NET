#region

using System;
using AutoFixture;
using FluentAssertions;
using Silk.NET.Maths;
using Xunit;
using static Silk.NET.Maths.Scalar;

#endregion

namespace Silk.Net.Maths.Tests
{
    public class A
    {
        [Fact]
        public void B()
        {
            var a = Vector4<float>.One;
            Vector4<float>.Multiply(ref a, 2, out var result);
            Assert.Equal(new Vector4<float>(2), result);
        }
    }
    
    public class ByteScalarTests : UnsignedScalarTests<byte> { }

    public class SByteScalarTests : SignedScalarTests<sbyte> { }

    public class UShortScalarTests : UnsignedScalarTests<ushort> { }

    public class ShortScalarTests : SignedScalarTests<short> { }

    public class UIntScalarTests : UnsignedScalarTests<uint> { }

    public class IntScalarTests : SignedScalarTests<int> { }

    public class ULongScalarTests : UnsignedScalarTests<ulong> { }

    public class LongScalarTests : SignedScalarTests<long> { }

    public class HalfScalarTests : FloatingPointScalarTests<Half> { }

    public class FloatScalarTests : FloatingPointScalarTests<float> { }

    public class DoubleScalarTests : FloatingPointScalarTests<double> { }

    public abstract class FloatingPointScalarTests<T> : SignedScalarTests<T> where T : unmanaged, IFormattable
    {
        [Fact]
        public T NegativeInfinityDoesNotThrow() => Scalar<T>.NegativeInfinity;

        [Fact]
        public T PositiveInfinityDoesNotThrow() => Scalar<T>.PositiveInfinity;
    }

    public abstract class SignedScalarTests<T> : UnsignedScalarTests<T> where T : unmanaged, IFormattable
    {
        [Theory]
        [InlineData(1, -1)]
        [InlineData(-1, 1)]
        public void Negate(T value, T expected) => Scalar.Negate(value).Should().Be(expected);
    }

    public abstract class UnsignedScalarTests<T> where T : unmanaged, IFormattable
    {
        [Theory]
        [InlineData(1, 1, 2)]
        public void Add(T a, T b, T expected) => Scalar.Add(a, b).Should().Be(expected);

        [Theory]
        [InlineData(3, 1, 2)]
        public void Subtract(T a, T b, T expected) => Scalar.Subtract(a, b).Should().Be(expected);

        [Theory]
        [InlineData(3, 3, 9)]
        public void Multiply(T a, T b, T expected) => Scalar.Multiply(a, b).Should().Be(expected);

        [Theory]
        [InlineData(6, 3, 2)]
        public void Divide(T a, T b, T expected) => Scalar.Divide(a, b).Should().Be(expected);

        [Theory]
        [InlineData(9, 3)]
        public void SquareRoot(T value, T expected) => Scalar.SquareRoot(value).Should().Be(expected);

        [Theory]
        [InlineData(6, 3, 3)]
        [InlineData(0, 3, 0)]
        public void Min(T a, T b, T expected) => Scalar.Min(a, b).Should().Be(expected);

        [Theory]
        [InlineData(6, 3, 6)]
        [InlineData(0, 3, 3)]
        public void Max(T a, T b, T expected) => Scalar.Max(a, b).Should().Be(expected);


        [Theory]
        [InlineData(6, 3, true)]
        [InlineData(0, 3, false)]
        public void Larger(T a, T b, bool expected) => Scalar.Larger(a, b).Should().Be(expected);


        [Theory]
        [InlineData(6, 3, false)]
        [InlineData(0, 3, true)]
        public void Smaller(T a, T b, bool expected) => Scalar.Smaller(a, b).Should().Be(expected);


        [Theory]
        [InlineData(6, 3, true)]
        [InlineData(0, 3, false)]
        [InlineData(6, 6, true)]
        public void LargerEquals(T a, T b, bool expected) => Scalar.LargerEquals(a, b).Should().Be(expected);


        [Theory]
        [InlineData(6, 3, false)]
        [InlineData(0, 3, true)]
        [InlineData(6, 6, true)]
        public void SmallerEquals(T a, T b, bool expected) => Scalar.SmallerEquals(a, b).Should().Be(expected);

        [Theory]
        [InlineData(0, 2, 3, 2)]
        [InlineData(3, 1, 5, 3)]
        [InlineData(9, 0, 5, 5)]
        public void Clamp(T a, T b, T c, T expected) => Scalar.Clamp(a, b, c).Should().Be(expected);


        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(8, 1, false)]
        public void Equal(T a, T b, bool expected) => Scalar.Equal(a, b).Should().Be(expected);

        [Fact]
        public void DoesNotThrowForUnsupportedBaseType() => ThrowForUnsupportedBaseType<T>();

        [Fact]
        public T OneDoesNotThrow() => Scalar<T>.One;

        [Fact]
        public void ThrowIndexOutOfRangeThrows() => Assert.Throws<IndexOutOfRangeException>(ThrowIndexOutOfRange);

        [Fact]
        public void ThrowNotSupportedByUnderlying()
            => Assert.Throws<NotSupportedException>(Scalar.ThrowNotSupportedByUnderlying<T>);

        [Fact]
        public void ThrowVectorTTooSmall() => Assert.Throws<NotSupportedException>(Scalar.ThrowVectorTTooSmall);

        [Fact]
        public T TwoDoesNotThrow() => Scalar<T>.Two;
    }

    public class ScalarNotSupportedTests
    {
        // DateTime is struct, IFormattable, and will never used

        [Fact]
        public void Add()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Add(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }


        [Fact]
        public void Clamp()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Clamp(fixture.Create<DateTime>(), fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Divide()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Divide(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }


        [Fact]
        public void Equal()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Equal(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Larger()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Larger(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void LargerEquals()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.LargerEquals(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Max()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Max(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }


        [Fact]
        public void Min()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Min(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Multiply()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Multiply(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Negate()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>(() => Scalar.Negate(fixture.Create<DateTime>()));
        }

        [Fact]
        public void Smaller()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Smaller(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }


        [Fact]
        public void SmallerEquals()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.SmallerEquals(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }

        [Fact]
        public void Subtract()
        {
            var fixture = new Fixture();
            Assert.Throws<NotSupportedException>
                (() => Scalar.Subtract(fixture.Create<DateTime>(), fixture.Create<DateTime>()));
        }
    }
}