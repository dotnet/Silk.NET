// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Globalization;

namespace Silk.NET.Maths
{
    public struct Box2<T> : IEquatable<Box2<T>>, IFormattable where T : unmanaged, IFormattable
    {
        private static readonly string ListSeparator;
        private Vector2<T> Min;
        private Vector2<T> Max;

        public Box2(Vector2<T> min, Vector2<T> max)
        {
            throw new NotImplementedException();
        }

        public Box2(T minX, T minY, T maxX, T maxY)
        {
            throw new NotImplementedException();
        }

        public Vector2<T> Size
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2<T> HalfSize
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2<T> Center
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public bool Contains(Vector2<T> point)
        {
            throw new NotImplementedException();
        }

        public bool Contains(Vector2<T> point, bool boundaryInclusive)
        {
            throw new NotImplementedException();
        }

        public bool Contains(Box2<T> other)
        {
            throw new NotImplementedException();
        }

        public T DistanceToNearestEdge(Vector2<T> point)
        {
            throw new NotImplementedException();
        }

        public void Translate(Vector2<T> distance)
        {
            throw new NotImplementedException();
        }

        public Box2<T> Translated(Vector2<T> distance)
        {
            throw new NotImplementedException();
        }

        public void Scale(Vector2<T> scale, Vector2<T> anchor)
        {
            throw new NotImplementedException();
        }

        public Box2<T> Scaled(Vector2<T> scale, Vector2<T> anchor)
        {
            throw new NotImplementedException();
        }

        public void Inflate(Vector2<T> point)
        {
            throw new NotImplementedException();
        }

        public Box2<T> Inflated(Vector2<T> point)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Box2<T> left, Box2<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Box2<T> left, Box2<T> right)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Box2<T> other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => ToString("G");

        public string ToString(string format) => ToString(format, CultureInfo.CurrentCulture);
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}
