namespace Silk.NET.Maths
{
    using System.Numerics;

    partial struct Vector3F<T> : IEquatable<Vector3F<T>> where T : IFloatingPointIeee754<T>
    {
        public T X;
        public T Y;
        public T Z;
        public static bool operator ==(Vector3F<T> left, Vector3F<T> right) => left.X == right.X && left.Y == right.Y && left.Z == right.Z;
        public static bool operator !=(Vector3F<T> left, Vector3F<T> right) => !(left == right);
        public override bool Equals(object? obj) => obj is Vector3F<T> other && Equals(other);
        /// <inheridoc/>
        public bool Equals(Vector3F<T> other) => this == other;
        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);
    }
}