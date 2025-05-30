namespace Silk.NET.Maths
{
    using System.Numerics;

    partial struct Matrix4x2I<T> : IEquatable<Matrix4x2I<T>> where T : IBinaryInteger<T>
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
        public Vector2I<T> Row4;
        public T M41 => Row4.X;
        public T M42 => Row4.Y;
        public static bool operator ==(Matrix4x2I<T> left, Matrix4x2I<T> right) => left.Row1 == right.Row1 && left.Row2 == right.Row2 && left.Row3 == right.Row3 && left.Row4 == right.Row4;
        public static bool operator !=(Matrix4x2I<T> left, Matrix4x2I<T> right) => !(left == right);
        public override bool Equals(object? obj) => obj is Matrix4x2I<T> other && Equals(other);
        /// <inheridoc/>
        public bool Equals(Matrix4x2I<T> other) => this == other;
        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2, Row3, Row4);
    }
}