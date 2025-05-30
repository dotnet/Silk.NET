namespace Silk.NET.Maths
{
    using System.Numerics;

    partial struct Matrix4x4I<T> : IEquatable<Matrix4x4I<T>> where T : IBinaryInteger<T>
    {
        public Vector4I<T> Row1;
        public T M11 => Row1.X;
        public T M12 => Row1.Y;
        public T M13 => Row1.Z;
        public T M14 => Row1.W;
        public Vector4I<T> Row2;
        public T M21 => Row2.X;
        public T M22 => Row2.Y;
        public T M23 => Row2.Z;
        public T M24 => Row2.W;
        public Vector4I<T> Row3;
        public T M31 => Row3.X;
        public T M32 => Row3.Y;
        public T M33 => Row3.Z;
        public T M34 => Row3.W;
        public Vector4I<T> Row4;
        public T M41 => Row4.X;
        public T M42 => Row4.Y;
        public T M43 => Row4.Z;
        public T M44 => Row4.W;
        public static bool operator ==(Matrix4x4I<T> left, Matrix4x4I<T> right) => left.Row1 == right.Row1 && left.Row2 == right.Row2 && left.Row3 == right.Row3 && left.Row4 == right.Row4;
        public static bool operator !=(Matrix4x4I<T> left, Matrix4x4I<T> right) => !(left == right);
        public override bool Equals(object? obj) => obj is Matrix4x4I<T> other && Equals(other);
        /// <inheridoc/>
        public bool Equals(Matrix4x4I<T> other) => this == other;
        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(Row1, Row2, Row3, Row4);
    }
}