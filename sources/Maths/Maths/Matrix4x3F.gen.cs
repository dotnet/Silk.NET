namespace Silk.NET.Maths
{
    using System.Numerics;

    partial struct Matrix4x3F<T> : IEquatable<Matrix4x3F<T>> where T : IFloatingPointIeee754<T>
    {
        public Vector3F<T> Row1;
        public T M11 => Row1.X;
        public T M12 => Row1.Y;
        public T M13 => Row1.Z;
        public Vector3F<T> Row2;
        public T M21 => Row2.X;
        public T M22 => Row2.Y;
        public T M23 => Row2.Z;
        public Vector3F<T> Row3;
        public T M31 => Row3.X;
        public T M32 => Row3.Y;
        public T M33 => Row3.Z;
        public Vector3F<T> Row4;
        public T M41 => Row4.X;
        public T M42 => Row4.Y;
        public T M43 => Row4.Z;
        public static bool operator ==(Matrix4x3F<T> left, Matrix4x3F<T> right) => left.Row1 == right.Row1 && left.Row2 == right.Row2 && left.Row3 == right.Row3 && left.Row4 == right.Row4;
        public static bool operator !=(Matrix4x3F<T> left, Matrix4x3F<T> right) => !(left == right);
        public override bool Equals(object? obj) => obj is Matrix4x3F<T> other && Equals(other);
        /// <inheridoc/>
        public bool Equals(Matrix4x3F<T> other) => this == other;
        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2, Row3, Row4);
    }
}