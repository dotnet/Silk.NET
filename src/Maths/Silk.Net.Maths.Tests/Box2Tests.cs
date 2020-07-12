using System;
using AutoFixture;
using AutoFixture.Xunit2;
using FluentAssertions;
using Xunit;
using static Silk.NET.Maths.Scalar;

namespace Silk.NET.Maths.Tests
{
    public class ByteBox2Tests : Box2Tests<byte> { }

    public class SByteBox2Tests : Box2Tests<sbyte> { }

    public class UShortBox2Tests : Box2Tests<ushort> { }

    public class ShortBox2Tests : Box2Tests<short> { }

    public class UIntBox2Tests : Box2Tests<uint> { }

    public class IntBox2Tests : Box2Tests<int> { }

    public class ULongBox2Tests : Box2Tests<ulong> { }

    public class LongBox2Tests : Box2Tests<long> { }

    // public class HalfBox2Tests : Box2Tests<Half> { }

    public class FloatBox2Tests : Box2Tests<float> { }

    public class DoubleBox2Tests : Box2Tests<double> { }

    public abstract class Box2Tests<T> where T : unmanaged, IFormattable, IComparable<T>
    {
        [Fact]
        public void Box2_Invalid_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Box2<T>(Vector2<T>.One, Vector2<T>.Zero));
        }
        
        [Theory, AutoData]
        public void Min_ShouldReturnMinimum(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            var box = new Box2<T>(minX, minY, maxX, maxY);
            box.Min.Should().Be(new Vector2<T>(minX, minY));
        }
        
        
        [Theory, AutoData]
        public void Max_ShouldReturnMaximum(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            var box = new Box2<T>(minX, minY, maxX, maxY);
            box.Max.Should().Be(new Vector2<T>(maxX, maxY));
        }
        
        
        [Theory, AutoData]
        public void Size_ShouldReturnSize(T minX, T minY, T sizeX, T sizeY)
        {
            var box = new Box2<T>(minX, minY, Add(minX, sizeX), Add(minY, sizeY));
            box.Size.Should().Be(new Vector2<T>(sizeX, sizeY));
        }

        [Theory, AutoData]
        public void HalfSize_ShouldReturnHalfSize(T minX, T minY, T sizeX, T sizeY)
        {
            var box = new Box2<T>(minX, minY, Add(minX, sizeX), Add(minY, sizeY));
            box.HalfSize.Should().Be(new Vector2<T>(sizeX, sizeY) / Two<T>());
        }
        
        [Theory, AutoData]
        public void Center_ShouldReturnCenter(T minX, T minY, T sizeX, T sizeY)
        {
            var box = new Box2<T>(minX, minY, Add(minX, sizeX), Add(minY, sizeY));
            box.Center.Should().Be(box.Min + box.HalfSize);
        }

        [Theory, AutoData]
        public void Box2_ShouldReturnBox2(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            var boxA = new Box2<T>(minX, minY, maxX, maxY);
            var max = new Vector2<T>(maxX, maxY);
            var min = new Vector2<T>(minX, minY);
            var boxB = new Box2<T>(min, max);

            boxA.Min.Should().Be(min);
            boxB.Min.Should().Be(min);
            boxA.Max.Should().Be(max);
            boxB.Max.Should().Be(max);
            boxA.Should().Be(boxB);
        }

        [Theory, AutoData]
        public void WithMax_ShouldReturnWithMax(T minX1, T minY1, T minX2, T minY2, T sizeX, T sizeY)
        {
            var maxX = Add(Max(minX1, minX2), sizeX);
            var maxY = Add(Max(minY1, minY2), sizeY);
            
            var min1 = new Vector2<T>(minX1, minY1);
            var min2 = new Vector2<T>(minX2, minY2);
            var max = new Vector2<T>(maxX, maxY);
            var box = new Box2<T>(min1, max);
            box.Min.Should().Be(min1);
            box.Max.Should().Be(max);
            var newBox = box.WithMin(min2);
            newBox.Max.Should().Be(max);
            newBox.Min.Should().Be(min2);
        }
        
        [Theory, AutoData]
        public void WithMin_ShouldReturnWithMin(T minX, T minY, T sizeX1, T sizeY1, T sizeX2, T sizeY2)
        {
            var maxX1 = Add(minX, sizeX1);
            var maxX2 = Add(minX, sizeX2);
            var maxY1 = Add(minY, sizeY1);
            var maxY2 = Add(minY, sizeY2);

            var min = new Vector2<T>(minX, minY);
            var max1 = new Vector2<T>(maxX1, maxY1);
            var max2 = new Vector2<T>(maxX2, maxY2);
            var box = new Box2<T>(min, max1);
            box.Min.Should().Be(min);
            box.Max.Should().Be(max1);
            var newBox = box.WithMax(max2);
            newBox.Max.Should().Be(max2);
            newBox.Min.Should().Be(min);
        }

        [Theory, AutoData]
        public void op_Equality_WithSame_ShouldReturnTrue(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            (new Box2<T>(minX, minY, maxX, maxY) == new Box2<T>(minX, minY, maxX, maxY)).Should().BeTrue();
        }
        
        [Theory, AutoData]
        public void op_Equality_WithDifferent_ShouldReturnFalse(T minX1, T minY1, T maxX1, T maxY1, T minX2, T minY2, T maxX2, T maxY2)
        {
            (new Box2<T>(minX1, minY1, maxX1, maxY1) == new Box2<T>(minX2, minY2, maxX2, maxY2)).Should().BeFalse();
        }
        
        [Theory, AutoData]
        public void op_Inequality_WithSame_ShouldReturnFalse(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            (new Box2<T>(minX, minY, maxX, maxY) != new Box2<T>(minX, minY, maxX, maxY)).Should().BeFalse();
        }
        
        [Theory, AutoData]
        public void op_Inequality_WithDifferent_ShouldReturnTrue(T minX1, T minY1, T maxX1, T maxY1, T minX2, T minY2, T maxX2, T maxY2)
        {
            (new Box2<T>(minX1, minY1, maxX1, maxY1) != new Box2<T>(minX2, minY2, maxX2, maxY2)).Should().BeTrue();
        }
        
        [Theory, AutoData]
        public void Equals_obj_WithSame_ShouldReturnTrue(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            (new Box2<T>(minX, minY, maxX, maxY).Equals((object)new Box2<T>(minX, minY, maxX, maxY))).Should().BeTrue();
        }
        
        [Theory, AutoData]
        public void Equals_obj_WithDifferent_ShouldReturnFalse(T minX1, T minY1, T maxX1, T maxY1, T minX2, T minY2, T maxX2, T maxY2)
        {
            (new Box2<T>(minX1, minY1, maxX1, maxY1).Equals((object)new Box2<T>(minX2, minY2, maxX2, maxY2))).Should().BeFalse();
        }
        
        [Theory, AutoData]
        public void Equals_obj_WithWrongType_ShouldReturnFalse(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            (new Box2<T>(minX, minY, maxX, maxY).Equals((object)DateTime.Now)).Should().BeFalse();
        }
        
        [Theory, AutoData]
        public void Equals_WithSame_ShouldReturnTrue(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            (new Box2<T>(minX, minY, maxX, maxY).Equals(new Box2<T>(minX, minY, maxX, maxY))).Should().BeTrue();
        }
        
        [Theory, AutoData]
        public void Equals_WithDifferent_ShouldReturnFalse(T minX1, T minY1, T maxX1, T maxY1, T minX2, T minY2, T maxX2, T maxY2)
        {
            (new Box2<T>(minX1, minY1, maxX1, maxY1).Equals(new Box2<T>(minX2, minY2, maxX2, maxY2))).Should().BeFalse();
        }

        [Theory, AutoData]
        public void Contains_Vector2_Inclusive_ShouldReturnTrue(T minX, T minY, T sizeX, T sizeY, T posX, T posY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            var box = new Box2<T>(minX, minY, maxX, maxY);
            var pos = new Vector2<T>(posX, posY);

            box.Contains(pos, false).Should()
                .Be(Smaller(pos.X, box.Max.X) && Smaller(pos.Y, box.Max.Y) && Larger(pos.X, box.Min.X) && Larger(pos.Y, box.Min.Y));
        }

        [Theory, AutoData]
        public void Contains_Vector2_Inclusive_Min_ShouldReturnTrue(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            var box = new Box2<T>(minX, minY, maxX, maxY);
            box.Contains(box.Min, true).Should().BeTrue();
        }
        
        
        [Theory, AutoData]
        public void Contains_Vector2_Inclusive_Max_ShouldReturnTrue(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            var box = new Box2<T>(minX, minY, maxX, maxY);
            box.Contains(box.Max, true).Should().BeTrue();
        }
        
        [Theory, AutoData]
        public void Contains_Vector2_Exclusive_Min_ShouldReturnFalse(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            var box = new Box2<T>(minX, minY, maxX, maxY);
            box.Contains(box.Min, false).Should().BeFalse();
        }
        
        
        [Theory, AutoData]
        public void Contains_Vector2_Exclusive_Max_ShouldReturnFalse(T minX, T minY, T sizeX, T sizeY)
        {
            var maxX = Add(minX, sizeX);
            var maxY = Add(minY, sizeY);
            var box = new Box2<T>(minX, minY, maxX, maxY);
            box.Contains(box.Max, false).Should().BeFalse();
        }
    }
}
