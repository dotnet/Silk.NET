using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    public struct Matrix4x3<T> : IEquatable<Matrix4x3<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
        private const float DecomposeEpsilon = 0.0001f;

        private static readonly Matrix4x3<T> _identity = new
        (
            Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One,
            Constants<T>.Zero, Constants<T>.Zero, Constants<T>.Zero
        );

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        public T M11;

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        public T M12;

        /// <summary>Value at row 1, column 3 of the matrix.</summary>
        public T M13;

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        public T M21;

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        public T M22;

        /// <summary>Value at row 2, column 3 of the matrix.</summary>
        public T M23;

        /// <summary>Value at row 3, column 1 of the matrix.</summary>
        public T M31;

        /// <summary>Value at row 3, column 2 of the matrix.</summary>
        public T M32;

        /// <summary>Value at row 3, column 3 of the matrix.</summary>
        public T M33;

        /// <summary>Value at row 4, column 1 of the matrix.</summary>
        public T M41;

        /// <summary>Value at row 4, column 2 of the matrix.</summary>
        public T M42;

        /// <summary>Value at row 4, column 3 of the matrix.</summary>
        public T M43;

        /// <summary>Constructs a Matrix4x3 from the given components.</summary>
        public Matrix4x3(T m11, T m12, T m13,
                         T m21, T m22, T m23,
                         T m31, T m32, T m33,
                         T m41, T m42, T m43)
            => (M11, M12, M13,
                M21, M22, M23,
                M31, M32, M33,
                M41, M42, M43)
            =  (m11, m12, m13,
                m21, m22, m23,
                m31, m32, m33,
                m41, m42, m43);

        /// <summary>Constructs a Matrix4x3 from the given Matrix3x2.</summary>
        /// <param name="value">The source Matrix3x2.</param>
        public Matrix4x3(Matrix3x2<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = Constants<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Constants<T>.Zero;

            M31 = Constants<T>.Zero;
            M32 = Constants<T>.Zero;
            M33 = Constants<T>.One;

            M41 = value.M31;
            M42 = value.M32;
            M43 = Constants<T>.Zero;
        }
        
        /// <summary>Constructs a Matrix4x3 from the given Matrix4x4.</summary>
        /// <param name="value">The source Matrix4x4.</param>
        public Matrix4x3(Matrix4x4<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;

            M31 = value.M31;
            M32 = value.M32;
            M33 = value.M33;

            M41 = value.M31;
            M42 = value.M32;
            M43 = value.M43;
        }
        
        /// <summary>Constructs a Matrix4x4 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix4x3(Matrix2x4<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;

            M31 = Constants<T>.Zero;
            M32 = Constants<T>.Zero;
            M33 = Constants<T>.One;

            M41 = Constants<T>.Zero;
            M42 = Constants<T>.Zero;
            M43 = Constants<T>.Zero;
        }
        
        /// <summary>Constructs a Matrix4x4 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix4x3(Matrix4x2<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = Constants<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Constants<T>.Zero;

            M31 = value.M31;
            M32 = value.M32;
            M33 = Constants<T>.One;

            M41 = value.M41;
            M42 = value.M42;
            M43 = Constants<T>.Zero;
        }

        /// <summary>Constructs a Matrix4x3 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix4x3(Matrix3x4<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;

            M31 = value.M31;
            M32 = value.M32;
            M33 = value.M33;

            M41 = Constants<T>.Zero;
            M42 = Constants<T>.Zero;
            M43 = Constants<T>.Zero;
        }
        
        /// <summary>Constructs a Matrix4x3 from the given Matrix3x3.</summary>
        /// <param name="value">The source Matrix3x3.</param>
        public Matrix4x3(Matrix3x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;

            M31 = value.M31;
            M32 = value.M32;
            M33 = value.M33;

            M41 = Constants<T>.Zero;
            M42 = Constants<T>.Zero;
            M43 = Constants<T>.Zero;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix4x3<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        public readonly bool IsIdentity
            => Operations.Equal(M11, Constants<T>.One) && Operations.Equal(M22, Constants<T>.One) &&
               Operations.Equal(M33, Constants<T>.One) && // Check diagonal element first for early out.
               Operations.Equal(M12, Constants<T>.Zero) && Operations.Equal(M13, Constants<T>.Zero) &&
               Operations.Equal(M21, Constants<T>.Zero) && Operations.Equal(M23, Constants<T>.Zero) &&
               Operations.Equal(M31, Constants<T>.Zero) && Operations.Equal(M32, Constants<T>.Zero) &&
               Operations.Equal(M41, Constants<T>.Zero) && Operations.Equal(M42, Constants<T>.Zero) &&
               Operations.Equal(M43, Constants<T>.Zero);

        /// <summary>Gets or sets the translation component of this matrix.</summary>
        public Vector3<T> Translation
        {
            readonly get => new(M41, M42, M43);

            set
            {
                M41 = value.X;
                M42 = value.Y;
                M43 = value.Z;
            }
        }

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix4x3<T> operator +(Matrix4x3<T> value1, Matrix4x3<T> value2)
        {
            Matrix4x3<T> m;

            m.M11 = Operations.Add(value1.M11, value2.M11);
            m.M12 = Operations.Add(value1.M12, value2.M12);
            m.M13 = Operations.Add(value1.M13, value2.M13);
            m.M21 = Operations.Add(value1.M21, value2.M21);
            m.M22 = Operations.Add(value1.M22, value2.M22);
            m.M23 = Operations.Add(value1.M23, value2.M23);
            m.M31 = Operations.Add(value1.M31, value2.M31);
            m.M32 = Operations.Add(value1.M32, value2.M32);
            m.M33 = Operations.Add(value1.M33, value2.M33);
            m.M41 = Operations.Add(value1.M41, value2.M41);
            m.M42 = Operations.Add(value1.M42, value2.M42);
            m.M43 = Operations.Add(value1.M43, value2.M43);
            
            return m;
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix4x3<T> value1, Matrix4x3<T> value2)
        {
            return Operations.Equal(value1.M11, value2.M11) && Operations.Equal(value1.M22, value2.M22) &&
                   Operations.Equal(value1.M33, value2.M33) && // Check diagonal elements first for early out.
                   Operations.Equal(value1.M12, value2.M12) && Operations.Equal(value1.M13, value2.M13) &&
                   Operations.Equal(value1.M21, value2.M21) && Operations.Equal(value1.M23, value2.M23) &&
                   Operations.Equal(value1.M31, value2.M31) && Operations.Equal(value1.M32, value2.M32) &&
                   Operations.Equal(value1.M41, value2.M41) && Operations.Equal(value1.M42, value2.M42) &&
                   Operations.Equal(value1.M43, value2.M43);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix4x3<T> value1, Matrix4x3<T> value2)
        {
            return Operations.NotEqual(value1.M11, value2.M11) || Operations.NotEqual(value1.M22, value2.M22) ||
                   Operations.NotEqual(value1.M33, value2.M33) || // Check diagonal elements first for early out.
                   Operations.NotEqual(value1.M12, value2.M12) || Operations.NotEqual(value1.M13, value2.M13) ||
                   Operations.NotEqual(value1.M21, value2.M21) || Operations.NotEqual(value1.M23, value2.M23) ||
                   Operations.NotEqual(value1.M31, value2.M31) || Operations.NotEqual(value1.M32, value2.M32) ||
                   Operations.NotEqual(value1.M41, value2.M41) || Operations.NotEqual(value1.M42, value2.M42) ||
                   Operations.NotEqual(value1.M43, value2.M43);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix4x4<T> operator *(Matrix4x3<T> value1, Matrix3x4<T> value2)
        {
            Matrix4x4<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21)), Operations.Multiply(value1.M13, value2.M31));
            m.M12 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22)), Operations.Multiply(value1.M13, value2.M32));
            m.M13 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M13), Operations.Multiply(value1.M12, value2.M23)), Operations.Multiply(value1.M13, value2.M33));
            m.M14 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M14), Operations.Multiply(value1.M12, value2.M24)), Operations.Multiply(value1.M13, value2.M34));

            // Second row
            m.M21 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21)), Operations.Multiply(value1.M23, value2.M31));
            m.M22 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22)), Operations.Multiply(value1.M23, value2.M32));
            m.M23 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M13), Operations.Multiply(value1.M22, value2.M23)), Operations.Multiply(value1.M23, value2.M33));
            m.M24 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M14), Operations.Multiply(value1.M22, value2.M24)), Operations.Multiply(value1.M23, value2.M34));

            // Third row
            m.M31 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M11), Operations.Multiply(value1.M32, value2.M21)), Operations.Multiply(value1.M33, value2.M31));
            m.M32 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M12), Operations.Multiply(value1.M32, value2.M22)), Operations.Multiply(value1.M33, value2.M32));
            m.M33 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M13), Operations.Multiply(value1.M32, value2.M23)), Operations.Multiply(value1.M33, value2.M33));
            m.M34 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M14), Operations.Multiply(value1.M32, value2.M24)), Operations.Multiply(value1.M33, value2.M34));

            // Fourth row
            m.M41 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M11), Operations.Multiply(value1.M42, value2.M21)), Operations.Multiply(value1.M43, value2.M31));
            m.M42 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M12), Operations.Multiply(value1.M42, value2.M22)), Operations.Multiply(value1.M43, value2.M32));
            m.M43 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M13), Operations.Multiply(value1.M42, value2.M23)), Operations.Multiply(value1.M43, value2.M33));
            m.M44 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M14), Operations.Multiply(value1.M42, value2.M24)), Operations.Multiply(value1.M43, value2.M34));

            return m;
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix4x3<T> operator *(Matrix4x3<T> value1, Matrix3x3<T> value2)
        {
            Matrix4x3<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21)), Operations.Multiply(value1.M13, value2.M31));
            m.M12 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22)), Operations.Multiply(value1.M13, value2.M32));
            m.M13 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M13), Operations.Multiply(value1.M12, value2.M23)), Operations.Multiply(value1.M13, value2.M33));

            // Second row
            m.M21 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21)), Operations.Multiply(value1.M23, value2.M31));
            m.M22 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22)), Operations.Multiply(value1.M23, value2.M32));
            m.M23 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M13), Operations.Multiply(value1.M22, value2.M23)), Operations.Multiply(value1.M23, value2.M33));

            // Third row
            m.M31 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M11), Operations.Multiply(value1.M32, value2.M21)), Operations.Multiply(value1.M33, value2.M31));
            m.M32 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M12), Operations.Multiply(value1.M32, value2.M22)), Operations.Multiply(value1.M33, value2.M32));
            m.M33 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M13), Operations.Multiply(value1.M32, value2.M23)), Operations.Multiply(value1.M33, value2.M33));

            // Fourth row
            m.M41 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M11), Operations.Multiply(value1.M42, value2.M21)), Operations.Multiply(value1.M43, value2.M31));
            m.M42 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M12), Operations.Multiply(value1.M42, value2.M22)), Operations.Multiply(value1.M43, value2.M32));
            m.M43 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M13), Operations.Multiply(value1.M42, value2.M23)), Operations.Multiply(value1.M43, value2.M33));

            return m;
        }

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix4x3<T> operator *(Matrix4x3<T> value1, T value2)
        {
            Matrix4x3<T> m;

            m.M11 = Operations.Multiply(value1.M11, value2);
            m.M12 = Operations.Multiply(value1.M12, value2);
            m.M13 = Operations.Multiply(value1.M13, value2);
            m.M21 = Operations.Multiply(value1.M21, value2);
            m.M22 = Operations.Multiply(value1.M22, value2);
            m.M23 = Operations.Multiply(value1.M23, value2);
            m.M31 = Operations.Multiply(value1.M31, value2);
            m.M32 = Operations.Multiply(value1.M32, value2);
            m.M33 = Operations.Multiply(value1.M33, value2);
            m.M41 = Operations.Multiply(value1.M41, value2);
            m.M42 = Operations.Multiply(value1.M42, value2);
            m.M43 = Operations.Multiply(value1.M43, value2);

            return m;
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix4x3<T> operator -(Matrix4x3<T> value1, Matrix4x3<T> value2)
        {
            Matrix4x3<T> m;

            m.M11 = Operations.Subtract(value1.M11, value2.M11);
            m.M12 = Operations.Subtract(value1.M12, value2.M12);
            m.M13 = Operations.Subtract(value1.M13, value2.M13);
            m.M21 = Operations.Subtract(value1.M21, value2.M21);
            m.M22 = Operations.Subtract(value1.M22, value2.M22);
            m.M23 = Operations.Subtract(value1.M23, value2.M23);
            m.M31 = Operations.Subtract(value1.M31, value2.M31);
            m.M32 = Operations.Subtract(value1.M32, value2.M32);
            m.M33 = Operations.Subtract(value1.M33, value2.M33);
            m.M41 = Operations.Subtract(value1.M41, value2.M41);
            m.M42 = Operations.Subtract(value1.M42, value2.M42);
            m.M43 = Operations.Subtract(value1.M43, value2.M43);
            
            return m;
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix4x3<T> operator -(Matrix4x3<T> value)
        {
            Matrix4x3<T> m;

            m.M11 = Operations.Negate(value.M11);
            m.M12 = Operations.Negate(value.M12);
            m.M13 = Operations.Negate(value.M13);
            m.M21 = Operations.Negate(value.M21);
            m.M22 = Operations.Negate(value.M22);
            m.M23 = Operations.Negate(value.M23);
            m.M31 = Operations.Negate(value.M31);
            m.M32 = Operations.Negate(value.M32);
            m.M33 = Operations.Negate(value.M33);
            m.M41 = Operations.Negate(value.M41);
            m.M42 = Operations.Negate(value.M42);
            m.M43 = Operations.Negate(value.M43);
            
            return m;
        }

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x3<T> Add(Matrix4x3<T> value1, Matrix4x3<T> value2)
        {
            return value1 + value2;
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x3<T> Multiply(Matrix4x3<T> value1, Matrix3x3<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4<T> Multiply(Matrix4x3<T> value1, Matrix3x4<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x3<T> Multiply(Matrix4x4<T> value1, Matrix4x3<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3<T> Multiply(Matrix3x4<T> value1, Matrix4x3<T> value2)
            => value1 * value2;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x3<T> Multiply(Matrix4x3<T> value1, T value2)
            => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x3<T> Negate(Matrix4x3<T> value)
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x3<T> Subtract(Matrix4x3<T> value1, Matrix4x3<T> value2)
            => value1 - value2;

        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix4x3<T> Lerp(Matrix4x3<T> matrix1, Matrix4x3<T> matrix2, T amount)
        {
            Matrix4x3<T> result;

            // First row
            result.M11 = Operations.Add(matrix1.M11, Operations.Multiply(Operations.Subtract(matrix2.M11, matrix1.M11), amount));
            result.M12 = Operations.Add(matrix1.M12, Operations.Multiply(Operations.Subtract(matrix2.M12, matrix1.M12), amount));
            result.M13 = Operations.Add(matrix1.M13, Operations.Multiply(Operations.Subtract(matrix2.M13, matrix1.M13), amount));

            // Second row
            result.M21 = Operations.Add(matrix1.M21, Operations.Multiply(Operations.Subtract(matrix2.M21, matrix1.M21), amount));
            result.M22 = Operations.Add(matrix1.M22, Operations.Multiply(Operations.Subtract(matrix2.M22, matrix1.M22), amount));
            result.M23 = Operations.Add(matrix1.M23, Operations.Multiply(Operations.Subtract(matrix2.M23, matrix1.M23), amount));

            // Third row
            result.M31 = Operations.Add(matrix1.M31, Operations.Multiply(Operations.Subtract(matrix2.M31, matrix1.M31), amount));
            result.M32 = Operations.Add(matrix1.M32, Operations.Multiply(Operations.Subtract(matrix2.M32, matrix1.M32), amount));
            result.M33 = Operations.Add(matrix1.M33, Operations.Multiply(Operations.Subtract(matrix2.M33, matrix1.M33), amount));

            // Fourth row
            result.M41 = Operations.Add(matrix1.M41, Operations.Multiply(Operations.Subtract(matrix2.M41, matrix1.M41), amount));
            result.M42 = Operations.Add(matrix1.M42, Operations.Multiply(Operations.Subtract(matrix2.M42, matrix1.M42), amount));
            result.M43 = Operations.Add(matrix1.M43, Operations.Multiply(Operations.Subtract(matrix2.M43, matrix1.M43), amount));

            return result;
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix4x3<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix4x3<T> other)
            => this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>   
        public override readonly int GetHashCode()
        {
            HashCode hash = default;

            hash.Add(M11);
            hash.Add(M12);
            hash.Add(M13);

            hash.Add(M21);
            hash.Add(M22);
            hash.Add(M23);

            hash.Add(M31);
            hash.Add(M32);
            hash.Add(M33);

            hash.Add(M41);
            hash.Add(M42);
            hash.Add(M43);

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1} M13:{2}}} {{M21:{3} M22:{4} M23:{5}}} {{M31:{6} M32:{7} M33:{8}}} {{M41:{9} M42:{10} M43:{11}}} }}",
                                 M11, M12, M13,
                                 M21, M22, M23,
                                 M31, M32, M33,
                                 M41, M42, M43);
        }

        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix4x3<Half>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, Half>(from.M11),Operations.As<T, Half>(from.M12),
                Operations.As<T, Half>(from.M13),
                Operations.As<T, Half>(from.M21),Operations.As<T, Half>(from.M22),
                Operations.As<T, Half>(from.M23),
                Operations.As<T, Half>(from.M31),Operations.As<T, Half>(from.M32),
                Operations.As<T, Half>(from.M33),
                Operations.As<T, Half>(from.M41),Operations.As<T, Half>(from.M42),
                Operations.As<T, Half>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix4x3<float>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, float>(from.M11),Operations.As<T, float>(from.M12),
                Operations.As<T, float>(from.M13),
                Operations.As<T, float>(from.M21),Operations.As<T, float>(from.M22),
                Operations.As<T, float>(from.M23),
                Operations.As<T, float>(from.M31),Operations.As<T, float>(from.M32),
                Operations.As<T, float>(from.M33),
                Operations.As<T, float>(from.M41),Operations.As<T, float>(from.M42),
                Operations.As<T, float>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix4x3<double>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, double>(from.M11),Operations.As<T, double>(from.M12),
                Operations.As<T, double>(from.M13),
                Operations.As<T, double>(from.M21),Operations.As<T, double>(from.M22),
                Operations.As<T, double>(from.M23),
                Operations.As<T, double>(from.M31),Operations.As<T, double>(from.M32),
                Operations.As<T, double>(from.M33),
                Operations.As<T, double>(from.M41),Operations.As<T, double>(from.M42),
                Operations.As<T, double>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix4x3<decimal>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, decimal>(from.M11),Operations.As<T, decimal>(from.M12),
                Operations.As<T, decimal>(from.M13),
                Operations.As<T, decimal>(from.M21),Operations.As<T, decimal>(from.M22),
                Operations.As<T, decimal>(from.M23),
                Operations.As<T, decimal>(from.M31),Operations.As<T, decimal>(from.M32),
                Operations.As<T, decimal>(from.M33),
                Operations.As<T, decimal>(from.M41),Operations.As<T, decimal>(from.M42),
                Operations.As<T, decimal>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix4x3<sbyte>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, sbyte>(from.M11),Operations.As<T, sbyte>(from.M12),
                Operations.As<T, sbyte>(from.M13),
                Operations.As<T, sbyte>(from.M21),Operations.As<T, sbyte>(from.M22),
                Operations.As<T, sbyte>(from.M23),
                Operations.As<T, sbyte>(from.M31),Operations.As<T, sbyte>(from.M32),
                Operations.As<T, sbyte>(from.M33),
                Operations.As<T, sbyte>(from.M41),Operations.As<T, sbyte>(from.M42),
                Operations.As<T, sbyte>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix4x3<byte>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, byte>(from.M11),Operations.As<T, byte>(from.M12),
                Operations.As<T, byte>(from.M13),
                Operations.As<T, byte>(from.M21),Operations.As<T, byte>(from.M22),
                Operations.As<T, byte>(from.M23),
                Operations.As<T, byte>(from.M31),Operations.As<T, byte>(from.M32),
                Operations.As<T, byte>(from.M33),
                Operations.As<T, byte>(from.M41),Operations.As<T, byte>(from.M42),
                Operations.As<T, byte>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix4x3<ushort>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, ushort>(from.M11),Operations.As<T, ushort>(from.M12),
                Operations.As<T, ushort>(from.M13),
                Operations.As<T, ushort>(from.M21),Operations.As<T, ushort>(from.M22),
                Operations.As<T, ushort>(from.M23),
                Operations.As<T, ushort>(from.M31),Operations.As<T, ushort>(from.M32),
                Operations.As<T, ushort>(from.M33),
                Operations.As<T, ushort>(from.M41),Operations.As<T, ushort>(from.M42),
                Operations.As<T, ushort>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix4x3<short>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, short>(from.M11),Operations.As<T, short>(from.M12),
                Operations.As<T, short>(from.M13),
                Operations.As<T, short>(from.M21),Operations.As<T, short>(from.M22),
                Operations.As<T, short>(from.M23),
                Operations.As<T, short>(from.M31),Operations.As<T, short>(from.M32),
                Operations.As<T, short>(from.M33),
                Operations.As<T, short>(from.M41),Operations.As<T, short>(from.M42),
                Operations.As<T, short>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix4x3<uint>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, uint>(from.M11),Operations.As<T, uint>(from.M12),
                Operations.As<T, uint>(from.M13),
                Operations.As<T, uint>(from.M21),Operations.As<T, uint>(from.M22),
                Operations.As<T, uint>(from.M23),
                Operations.As<T, uint>(from.M31),Operations.As<T, uint>(from.M32),
                Operations.As<T, uint>(from.M33),
                Operations.As<T, uint>(from.M41),Operations.As<T, uint>(from.M42),
                Operations.As<T, uint>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix4x3<int>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, int>(from.M11),Operations.As<T, int>(from.M12),
                Operations.As<T, int>(from.M13),
                Operations.As<T, int>(from.M21),Operations.As<T, int>(from.M22),
                Operations.As<T, int>(from.M23),
                Operations.As<T, int>(from.M31),Operations.As<T, int>(from.M32),
                Operations.As<T, int>(from.M33),
                Operations.As<T, int>(from.M41),Operations.As<T, int>(from.M42),
                Operations.As<T, int>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix4x3<ulong>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, ulong>(from.M11),Operations.As<T, ulong>(from.M12),
                Operations.As<T, ulong>(from.M13),
                Operations.As<T, ulong>(from.M21),Operations.As<T, ulong>(from.M22),
                Operations.As<T, ulong>(from.M23),
                Operations.As<T, ulong>(from.M31),Operations.As<T, ulong>(from.M32),
                Operations.As<T, ulong>(from.M33),
                Operations.As<T, ulong>(from.M41),Operations.As<T, ulong>(from.M42),
                Operations.As<T, ulong>(from.M43)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x3{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix4x3<long>(Matrix4x3<T> from)
            => new
            (
                Operations.As<T, long>(from.M11),Operations.As<T, long>(from.M12),
                Operations.As<T, long>(from.M13),
                Operations.As<T, long>(from.M21),Operations.As<T, long>(from.M22),
                Operations.As<T, long>(from.M23),
                Operations.As<T, long>(from.M31),Operations.As<T, long>(from.M32),
                Operations.As<T, long>(from.M33),
                Operations.As<T, long>(from.M41),Operations.As<T, long>(from.M42),
                Operations.As<T, long>(from.M43)
            );
    }
}
