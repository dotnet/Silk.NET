namespace Silk.NET.Maths
{
    using System.Numerics;

    partial struct Vector4F<T> : IEquatable<Vector4F<T>> where T : IFloatingPointIeee754<T>
    {
        public T X;
        public T Y;
        public T Z;
        public T W;
        public static bool operator ==(Vector4F<T> left, Vector4F<T> right) => left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
        public static bool operator !=(Vector4F<T> left, Vector4F<T> right) => !(left == right);
        public override bool Equals(object? obj) => obj is Vector4F<T> other && Equals(other);
        /// <inheridoc/>
        public bool Equals(Vector4F<T> other) => this == other;
        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);
    }
}