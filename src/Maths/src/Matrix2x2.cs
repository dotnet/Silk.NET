using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    public struct Matrix2x2<T> : IEquatable<Matrix2x2<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
        private const float DecomposeEpsilon = 0.0001f;

        private static readonly Matrix2x2<T> _identity = new(Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero,
            Constants<T>.One);

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        public T M11;

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        public T M12;

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        public T M21;

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        public T M22;

        /// <summary>Constructs a Matrix2x2 from the given components.</summary>
        public Matrix2x2(T m11, T m12, T m21, T m22) => (M11, M12, M21, M22) = (m11, m12, m21, m22);

        /// <summary>Constructs a Matrix2x2 from the given Matrix3x2.</summary>
        /// <param name="value">The source Matrix3x2.</param>
        public Matrix2x2(Matrix3x2<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;

            M21 = value.M21;
            M22 = value.M22;
        }

        /// <summary>Constructs a Matrix2x2 from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix2x2(Matrix4x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;

            M21 = value.M21;
            M22 = value.M22;
        }

        /// <summary>Constructs a Matrix2x2 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix2x2(Matrix3x4<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;

            M21 = value.M21;
            M22 = value.M22;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix2x2<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        public readonly bool IsIdentity
            => Operations.Equal(M11, Constants<T>.One) &&
               Operations.Equal(M22, Constants<T>.One) && // Check diagonal element first for early out.
               Operations.Equal(M12, Constants<T>.Zero) && Operations.Equal(M21, Constants<T>.Zero);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix2x2<T> operator +(Matrix2x2<T> value1, Matrix2x2<T> value2)
        {
            Matrix2x2<T> m;

            m.M11 = Operations.Add(value1.M11, value2.M11);
            m.M12 = Operations.Add(value1.M12, value2.M12);
            m.M21 = Operations.Add(value1.M21, value2.M21);
            m.M22 = Operations.Add(value1.M22, value2.M22);

            return m;
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix2x2<T> value1, Matrix2x2<T> value2)
        {
            return Operations.Equal(value1.M11, value2.M11) && Operations.Equal(value1.M22, value2.M22) &&
                   // Check diagonal elements first for early out.
                   Operations.Equal(value1.M12, value2.M12) && Operations.Equal(value1.M21, value2.M21);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix2x2<T> value1, Matrix2x2<T> value2)
        {
            return Operations.NotEqual(value1.M11, value2.M11) ||
                   Operations.NotEqual(value1.M22, value2.M22) || // Check diagonal elements first for early out.
                   Operations.NotEqual(value1.M12, value2.M12) || Operations.NotEqual(value1.M21, value2.M21);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix2x2<T> operator *(Matrix2x2<T> value1, Matrix2x2<T> value2)
        {
            Matrix2x2<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21));
            m.M12 = Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22));

            // Second row
            m.M21 = Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21));
            m.M22 = Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22));

            return m;
        }

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix2x2<T> operator *(Matrix2x2<T> value1, T value2)
        {
            Matrix2x2<T> m;

            m.M11 = Operations.Multiply(value1.M11, value2);
            m.M12 = Operations.Multiply(value1.M12, value2);
            m.M21 = Operations.Multiply(value1.M21, value2);
            m.M22 = Operations.Multiply(value1.M22, value2);

            return m;
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix2x2<T> operator -(Matrix2x2<T> value1, Matrix2x2<T> value2)
        {
            Matrix2x2<T> m;

            m.M11 = Operations.Subtract(value1.M11, value2.M11);
            m.M12 = Operations.Subtract(value1.M12, value2.M12);
            m.M21 = Operations.Subtract(value1.M21, value2.M21);
            m.M22 = Operations.Subtract(value1.M22, value2.M22);

            return m;
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix2x2<T> operator -(Matrix2x2<T> value)
        {
            Matrix2x2<T> m;

            m.M11 = Operations.Negate(value.M11);
            m.M12 = Operations.Negate(value.M12);
            m.M21 = Operations.Negate(value.M21);
            m.M22 = Operations.Negate(value.M22);

            return m;
        }

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2<T> Add(Matrix2x2<T> value1, Matrix2x2<T> value2)
        {
            return value1 + value2;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2<T> Multiply(Matrix2x2<T> value1, Matrix2x2<T> value2) => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x2<T> Multiply(Matrix3x2<T> value1, Matrix2x2<T> value2) => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x3<T> Multiply(Matrix2x2<T> value1, Matrix2x3<T> value2) => value1 * value2;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2<T> Multiply(Matrix2x2<T> value1, T value2) => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2<T> Negate(Matrix2x2<T> value) => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2<T> Subtract(Matrix2x2<T> value1, Matrix2x2<T> value2) => value1 - value2;


        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix2x2<T> Lerp(Matrix2x2<T> matrix1, Matrix2x2<T> matrix2, T amount)
        {
            Matrix2x2<T> result;

            // First row
            result.M11 = Operations.Add(matrix1.M11,
                Operations.Multiply(Operations.Subtract(matrix2.M11, matrix1.M11), amount));
            result.M12 = Operations.Add(matrix1.M12,
                Operations.Multiply(Operations.Subtract(matrix2.M12, matrix1.M12), amount));

            // Second row
            result.M21 = Operations.Add(matrix1.M21,
                Operations.Multiply(Operations.Subtract(matrix2.M21, matrix1.M21), amount));
            result.M22 = Operations.Add(matrix1.M22,
                Operations.Multiply(Operations.Subtract(matrix2.M22, matrix1.M22), amount));

            return result;
        }
        
        /// <summary>Calculates the determinant of the matrix.</summary>
        /// <returns>The determinant of the matrix.</returns>
        public readonly T GetDeterminant()
        { 
            //   | a b |
            //   | c d | = ad - bc

            T a = M11, b = M12;
            T d = M21, c = M22;

            return Operations.Subtract(Operations.Multiply(a, d), Operations.Multiply(b, c));
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj) => (obj is Matrix2x2<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix2x2<T> other) => this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>   
        public override readonly int GetHashCode()
        {
            HashCode hash = default;

            hash.Add(M11);
            hash.Add(M12);

            hash.Add(M21);
            hash.Add(M22);

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1}}} {{M21:{2} M22:{3}}} }}", M11, M12,
                M21, M22);
        }

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix2x2<Half>(Matrix2x2<T> from)
            => new(Operations.As<T, Half>(from.M11), Operations.As<T, Half>(from.M12), Operations.As<T, Half>(from.M21),
                Operations.As<T, Half>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix2x2<float>(Matrix2x2<T> from)
            => new(Operations.As<T, float>(from.M11), Operations.As<T, float>(from.M12),
                Operations.As<T, float>(from.M21), Operations.As<T, float>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix2x2<double>(Matrix2x2<T> from)
            => new(Operations.As<T, double>(from.M11), Operations.As<T, double>(from.M12),
                Operations.As<T, double>(from.M21), Operations.As<T, double>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix2x2<decimal>(Matrix2x2<T> from)
            => new(Operations.As<T, decimal>(from.M11), Operations.As<T, decimal>(from.M12),
                Operations.As<T, decimal>(from.M21), Operations.As<T, decimal>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix2x2<sbyte>(Matrix2x2<T> from)
            => new(Operations.As<T, sbyte>(from.M11), Operations.As<T, sbyte>(from.M12),
                Operations.As<T, sbyte>(from.M21), Operations.As<T, sbyte>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix2x2<byte>(Matrix2x2<T> from)
            => new(Operations.As<T, byte>(from.M11), Operations.As<T, byte>(from.M12), Operations.As<T, byte>(from.M21),
                Operations.As<T, byte>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix2x2<ushort>(Matrix2x2<T> from)
            => new(Operations.As<T, ushort>(from.M11), Operations.As<T, ushort>(from.M12),
                Operations.As<T, ushort>(from.M21), Operations.As<T, ushort>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix2x2<short>(Matrix2x2<T> from)
            => new(Operations.As<T, short>(from.M11), Operations.As<T, short>(from.M12),
                Operations.As<T, short>(from.M21), Operations.As<T, short>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix2x2<uint>(Matrix2x2<T> from)
            => new(Operations.As<T, uint>(from.M11), Operations.As<T, uint>(from.M12), Operations.As<T, uint>(from.M21),
                Operations.As<T, uint>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix2x2<int>(Matrix2x2<T> from)
            => new(Operations.As<T, int>(from.M11), Operations.As<T, int>(from.M12), Operations.As<T, int>(from.M21),
                Operations.As<T, int>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix2x2<ulong>(Matrix2x2<T> from)
            => new(Operations.As<T, ulong>(from.M11), Operations.As<T, ulong>(from.M12),
                Operations.As<T, ulong>(from.M21), Operations.As<T, ulong>(from.M22));

        /// <summary>
        /// Converts a <see cref="Matrix2x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix2x2<long>(Matrix2x2<T> from)
            => new(Operations.As<T, long>(from.M11), Operations.As<T, long>(from.M12), Operations.As<T, long>(from.M21),
                Operations.As<T, long>(from.M22));
    }
}
