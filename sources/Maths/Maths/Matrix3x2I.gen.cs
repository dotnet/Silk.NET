namespace Silk.NET.Maths
{
    using System.Numerics;

    partial struct Matrix3x2I<T> : IEquatable<Matrix3x2I<T>> where T : IBinaryInteger<T>
    {
        public Vector2I<T> Row1;
        public T M11 => Row1.X;
        public T M12 => Row1.Y;
        public Vector2I<T> Row2;
        public T M21 => Row2.X;
        public T M22 => Row2.Y;
        public Vector2I<T> Row3;
        public T M31 => Row3.X;
        public T M32 => Row3.Y;
        public static bool operator ==(Matrix3x2I<T> left, Matrix3x2I<T> right) => left.Row1 == right.Row1 && left.Row2 == right.Row2 && left.Row3 == right.Row3;
        public static bool operator !=(Matrix3x2I<T> left, Matrix3x2I<T> right) => !(left == right);
        public override bool Equals(object? obj) => obj is Matrix3x2I<T> other && Equals(other);
        /// <inheridoc/>
        public bool Equals(Matrix3x2I<T> other) => this == other;
        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2, Row3);
    }
}