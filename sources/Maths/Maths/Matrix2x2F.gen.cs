namespace Silk.NET.Maths
{
    using System.Numerics;

    partial struct Matrix2x2F<T> : IEquatable<Matrix2x2F<T>> where T : IFloatingPointIeee754<T>
    {
        public Vector2F<T> Row1;
        public T M11 => Row1.X;
        public T M12 => Row1.Y;
        public Vector2F<T> Row2;
        public T M21 => Row2.X;
        public T M22 => Row2.Y;
        public static bool operator ==(Matrix2x2F<T> left, Matrix2x2F<T> right) => left.Row1 == right.Row1 && left.Row2 == right.Row2;
        public static bool operator !=(Matrix2x2F<T> left, Matrix2x2F<T> right) => !(left == right);
        public override bool Equals(object? obj) => obj is Matrix2x2F<T> other && Equals(other);
        /// <inheridoc/>
        public bool Equals(Matrix2x2F<T> other) => this == other;
        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2);
    }
}