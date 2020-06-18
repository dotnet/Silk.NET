// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Silk.NET.Maths
{
    public readonly struct Box3<T> : IEquatable<Box3<T>>, IFormattable where T : unmanaged, IFormattable
    {
        public readonly Vector3<T> Min;
        public readonly Vector3<T> Max;
        
        public Box3(Vector3<T> min, Vector3<T> max)
        {
            Min = min;
            Max = max;
        }

        public Box3(T minX, T minY, T minZ, T maxX, T maxY, T maxZ) : this(new Vector3<T>(minX, minY, minZ), new Vector3<T>(maxX, maxY, maxZ))
        { }

        public Vector3<T> Size => Max - Min;

        public Vector3<T> HalfSize => (Max - Min) / Scalar<T>.Two;

        public Vector3<T> Center => Min + Max / Scalar<T>.Two;

        public bool Contains(Vector3<T> point, bool boundaryInclusive = false)
            => boundaryInclusive 
                ? Scalar<T>.LargerEquals(point.X, Min.X)
                  && Scalar<T>.LargerEquals(point.Y, Min.Y)
                  && Scalar<T>.LargerEquals(point.Z, Min.Z)
                  && Scalar<T>.SmallerEquals(point.X, Max.X)
                  && Scalar<T>.SmallerEquals(point.Y, Min.Y)
                  && Scalar<T>.SmallerEquals(point.Z, Min.Z)
                :
                Scalar<T>.Larger(point.X, Min.X)
                && Scalar<T>.Larger(point.Y, Min.Y)
                && Scalar<T>.Larger(point.Z, Min.Z)
                && Scalar<T>.Smaller(point.X, Max.X)
                && Scalar<T>.Smaller(point.Y, Min.Y)
                && Scalar<T>.Smaller(point.Z, Min.Z);

        public bool Contains(Box3<T> other, bool boundaryInclusive = false)
            => boundaryInclusive 
                ? Scalar<T>.LargerEquals(other.Min.X, Min.X)
                  && Scalar<T>.LargerEquals(other.Min.Y, Min.Y)
                  && Scalar<T>.LargerEquals(other.Min.Z, Min.Z)
                  && Scalar<T>.SmallerEquals(other.Max.X, Max.X)
                  && Scalar<T>.SmallerEquals(other.Max.Y, Min.Y)
                  && Scalar<T>.SmallerEquals(other.Max.Z, Min.Z)
                :
                Scalar<T>.Larger(other.Min.X, Min.X)
                && Scalar<T>.Larger(other.Min.Y, Min.Y)
                && Scalar<T>.Smaller(other.Max.X, Max.X)
                && Scalar<T>.Smaller(other.Max.Y, Min.Y)
                && Scalar<T>.Smaller(other.Max.Z, Min.Z);

        public T DistanceToNearestEdge(Vector3<T> point)
            => Vector3<T>.ComponentMax(Vector3<T>.Zero, Vector3<T>.ComponentMax(Min - point, point - Max)).Length;

        public Box3<T> Translate(Vector3<T> distance) 
            => new Box3<T>(Min + distance, Max + distance);

        public Box3<T> Scale(Vector3<T> scale, Vector3<T> anchor)
            => new Box3<T>(anchor + (Min - anchor) * scale, anchor + (Max - anchor) * scale);

        public Box3<T> Inflate(Vector3<T> point)
            => new Box3<T>(Vector3<T>.ComponentMin(point, Min), Vector3<T>.ComponentMin(point, Max));

        public static bool operator ==(Box3<T> left, Box3<T> right) 
            => left.Min == right.Min && left.Max == right.Max;

        public static bool operator !=(Box3<T> left, Box3<T> right) 
            => !(left == right);

        public bool Equals(Box3<T> other) 
            => this == other;

        public override bool Equals(object? obj)
            => obj is Box3<T> box && Equals(box);

        public override int GetHashCode()
        {
#if NETSTANDARD2_1
            return HashCode.Combine(Min, Max);
#else
            return Min.GetHashCode() ^ Max.GetHashCode();
#endif
        }

        public override string ToString() => ToString("G");

        public string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);
        
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            var sb = new StringBuilder();
            sb.Append(Min.ToString(format, formatProvider));
            sb.Append(" -> ");
            sb.Append(Max.ToString(format, formatProvider));
            return sb.ToString();
        }
    }
}
