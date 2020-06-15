// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    public struct Box3<T> : IEquatable<Box3<T>> where T:unmanaged
    {
        private static readonly string ListSeparator;
        private Vector3<T> Min;
        private Vector3<T> Max;
        
        public Box3(Vector3<T> min, Vector3<T> max)
        {
            throw new NotImplementedException();
        }

        public Box3(T minX, T minY, T minZ, T maxX, T maxY, T maxZ)
        {
            throw new NotImplementedException();
        }

        public Vector3<T> Size
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector3<T> HalfSize
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector3<T> Center
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public bool Contains(Vector3<T> point)
        {
            throw new NotImplementedException();
        }

        public bool Contains(Vector3<T> point, bool boundaryInclusive)
        {
            throw new NotImplementedException();
        }

        public bool Contains(Box3<T> other)
        {
            throw new NotImplementedException();
        }

        public T DistanceToNearestEdge(Vector3<T> point)
        {
            throw new NotImplementedException();
        }

        public void Translate(Vector3<T> distance)
        {
            throw new NotImplementedException();
        }

        public Box3<T> Translated(Vector3<T> distance)
        {
            throw new NotImplementedException();
        }

        public void Scale(Vector3<T> scale, Vector3<T> anchor)
        {
            throw new NotImplementedException();
        }

        public Box3<T> Scaled(Vector3<T> scale, Vector3<T> anchor)
        {
            throw new NotImplementedException();
        }

        public void Inflate(Vector3<T> point)
        {
            throw new NotImplementedException();
        }

        public Box3<T> Inflated(Vector3<T> point)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Box3<T> left, Box3<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Box3<T> left, Box3<T> right)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Box3<T> other)
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

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
