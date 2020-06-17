// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;
using System.Text;

namespace Silk.NET.Maths
{
    public struct Box2<T> : IEquatable<Box2<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public Vector2<T> Min;
        public Vector2<T> Max;

        public Box2(Vector2<T> min, Vector2<T> max)
        {
            Min = min;
            Max = max;
        }

        public Box2(T minX, T minY, T maxX, T maxY) : this (new Vector2<T>(minX, minY), new Vector2<T>(maxX, maxY))
        { }

        public Vector2<T> Size => Max - Min;

        public readonly Vector2<T> HalfSize => Size / Scalar<T>.Two;

        public Vector2<T> Center => Min + Max / Scalar<T>.Two;

        public bool Contains(Vector2<T> point, bool boundaryInclusive = false)
            => boundaryInclusive 
                ? Scalar<T>.LargerEquals(point.X, Min.X)
               && Scalar<T>.LargerEquals(point.Y, Min.Y)
               && Scalar<T>.SmallerEquals(point.X, Max.X)
               && Scalar<T>.SmallerEquals(point.Y, Min.Y)
                :
                Scalar<T>.Larger(point.X, Min.X)
                && Scalar<T>.Larger(point.Y, Min.Y)
                && Scalar<T>.Smaller(point.X, Max.X)
                && Scalar<T>.Smaller(point.Y, Min.Y);

        public bool Contains(Box2<T> other, bool boundaryInclusive = false)
            => boundaryInclusive 
                ? Scalar<T>.LargerEquals(other.Min.X, Min.X)
                  && Scalar<T>.LargerEquals(other.Min.Y, Min.Y)
                  && Scalar<T>.SmallerEquals(other.Max.X, Max.X)
                  && Scalar<T>.SmallerEquals(other.Max.Y, Min.Y)
                :
                Scalar<T>.Larger(other.Min.X, Min.X)
                && Scalar<T>.Larger(other.Min.Y, Min.Y)
                && Scalar<T>.Smaller(other.Max.X, Max.X)
                && Scalar<T>.Smaller(other.Max.Y, Min.Y);

        public T DistanceToNearestEdge(Vector2<T> point)
            => Vector2<T>.ComponentMax(Vector2<T>.Zero, Vector2<T>.ComponentMax(Min - point, point - Max)).Length;

        public void Translate(Vector2<T> distance)
        {
            this = Translated(distance);
        }

        public Box2<T> Translated(Vector2<T> distance) 
            => new Box2<T>(Min + distance, Max + distance);

        public void Scale(Vector2<T> scale, Vector2<T> anchor) 
            => this = Scaled(scale, anchor);

        public Box2<T> Scaled(Vector2<T> scale, Vector2<T> anchor) 
            => new Box2<T>(anchor + (Min - anchor) * scale, anchor + (Max - anchor) * scale);

        public void Inflate(Vector2<T> point)
            => this = Inflated(point);

        public Box2<T> Inflated(Vector2<T> point) 
            => new Box2<T>(Vector2<T>.ComponentMin(point, Min), Vector2<T>.ComponentMin(point, Max));

        public static bool operator ==(Box2<T> left, Box2<T> right) 
            => left.Min == right.Min && left.Max == right.Max;

        public static bool operator !=(Box2<T> left, Box2<T> right) 
            => !(left == right);

        public bool Equals(Box2<T> other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
            => obj is Box2<T> box && Equals(box);

        public override int GetHashCode()
        {
#if NETSTANDARD2_1
            return HashCode.Combine(Min, Max);
#else
            return Min.GetHashCode() ^ Max.GetHashCode();
#endif
        }

        public override string ToString() => ToString("G");

        public string ToString(string format) => ToString(format, CultureInfo.CurrentCulture);
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            var sb = new StringBuilder();
            sb.Append(Min.ToString(format, formatProvider));
            sb.Append(" -> ");
            sb.Append(Max.ToString(format, formatProvider));
            return sb.ToString();
        }
    }
}
