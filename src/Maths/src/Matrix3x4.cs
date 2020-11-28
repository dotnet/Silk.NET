using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    public struct Matrix3x4<T> : IEquatable<Matrix3x4<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
        private const float DecomposeEpsilon = 0.0001f;

        private static readonly Matrix3x4<T> _identity = new
        (
            Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero
        );

        /// <summary>Value at row 1, column 1 of the matrix.</summary>
        public T M11;

        /// <summary>Value at row 1, column 2 of the matrix.</summary>
        public T M12;

        /// <summary>Value at row 1, column 3 of the matrix.</summary>
        public T M13;

        /// <summary>Value at row 1, column 4 of the matrix.</summary>
        public T M14;

        /// <summary>Value at row 2, column 1 of the matrix.</summary>
        public T M21;

        /// <summary>Value at row 2, column 2 of the matrix.</summary>
        public T M22;

        /// <summary>Value at row 2, column 3 of the matrix.</summary>
        public T M23;

        /// <summary>Value at row 2, column 4 of the matrix.</summary>
        public T M24;

        /// <summary>Value at row 3, column 1 of the matrix.</summary>
        public T M31;

        /// <summary>Value at row 3, column 2 of the matrix.</summary>
        public T M32;

        /// <summary>Value at row 3, column 3 of the matrix.</summary>
        public T M33;

        /// <summary>Value at row 3, column 4 of the matrix.</summary>
        public T M34;

        /// <summary>Constructs a Matrix3x4 from the given components.</summary>
        public Matrix3x4(T m11, T m12, T m13, T m14,
                         T m21, T m22, T m23, T m24,
                         T m31, T m32, T m33, T m34)
            => (M11, M12, M13, M14,
                M21, M22, M23, M24,
                M31, M32, M33, M34)
            =  (m11, m12, m13, m14,
                m21, m22, m23, m24,
                m31, m32, m33, m34);

        /// <summary>Constructs a Matrix3x4 from the given Matrix3x2.</summary>
        /// <param name="value">The source Matrix3x2.</param>
        public Matrix3x4(Matrix3x2<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = Constants<T>.Zero;
            M14 = Constants<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = Constants<T>.Zero;
            M24 = Constants<T>.Zero;

            M31 = Constants<T>.Zero;
            M32 = Constants<T>.Zero;
            M33 = Constants<T>.One;
            M34 = Constants<T>.Zero;
        }

        /// <summary>Constructs a Matrix3x4 from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix3x4(Matrix4x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;
            M14 = Constants<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;
            M24 = Constants<T>.Zero;

            M31 = value.M31;
            M32 = value.M32;
            M33 = value.M33;
            M34 = Constants<T>.Zero;
        }
        
        /// <summary>Constructs a Matrix3x4 from the given Matrix3x3.</summary>
        /// <param name="value">The source Matrix3x3.</param>
        public Matrix3x4(Matrix3x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;
            M13 = value.M13;
            M14 = Constants<T>.Zero;

            M21 = value.M21;
            M22 = value.M22;
            M23 = value.M23;
            M24 = Constants<T>.Zero;

            M31 = value.M31;
            M32 = value.M32;
            M33 = value.M33;
            M34 = Constants<T>.Zero;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix3x4<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        public readonly bool IsIdentity
            => Operations.Equal(M11, Constants<T>.One) && Operations.Equal(M22, Constants<T>.One) &&
               Operations.Equal(M33, Constants<T>.One) && // Check diagonal element first for early out.
               Operations.Equal(M12, Constants<T>.Zero) && Operations.Equal(M13, Constants<T>.Zero) &&
               Operations.Equal(M14, Constants<T>.Zero) && Operations.Equal(M21, Constants<T>.Zero) &&
               Operations.Equal(M23, Constants<T>.Zero) && Operations.Equal(M24, Constants<T>.Zero) &&
               Operations.Equal(M31, Constants<T>.Zero) && Operations.Equal(M32, Constants<T>.Zero) &&
               Operations.Equal(M34, Constants<T>.Zero);

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        public static unsafe Matrix3x4<T> operator +(Matrix3x4<T> value1, Matrix3x4<T> value2)
        {
            /*if (AdvSimd.IsSupported)
            {
                AdvSimd.Store(&value1.M11, AdvSimd.Add(AdvSimd.LoadVector128(&value1.M11), AdvSimd.LoadVector128(&value2.M11)));
                AdvSimd.Store(&value1.M21, AdvSimd.Add(AdvSimd.LoadVector128(&value1.M21), AdvSimd.LoadVector128(&value2.M21)));
                AdvSimd.Store(&value1.M31, AdvSimd.Add(AdvSimd.LoadVector128(&value1.M31), AdvSimd.LoadVector128(&value2.M31)));
                AdvSimd.Store(&value1.M41, AdvSimd.Add(AdvSimd.LoadVector128(&value1.M41), AdvSimd.LoadVector128(&value2.M41)));
                return value1;
            }
            else if (Sse.IsSupported)
            {
                Sse.Store(&value1.M11, Sse.Add(Sse.LoadVector128(&value1.M11), Sse.LoadVector128(&value2.M11)));
                Sse.Store(&value1.M21, Sse.Add(Sse.LoadVector128(&value1.M21), Sse.LoadVector128(&value2.M21)));
                Sse.Store(&value1.M31, Sse.Add(Sse.LoadVector128(&value1.M31), Sse.LoadVector128(&value2.M31)));
                Sse.Store(&value1.M41, Sse.Add(Sse.LoadVector128(&value1.M41), Sse.LoadVector128(&value2.M41)));
                return value1;
            }*/

            Matrix3x4<T> m;

            m.M11 = Operations.Add(value1.M11, value2.M11);
            m.M12 = Operations.Add(value1.M12, value2.M12);
            m.M13 = Operations.Add(value1.M13, value2.M13);
            m.M14 = Operations.Add(value1.M14, value2.M14);
            m.M21 = Operations.Add(value1.M21, value2.M21);
            m.M22 = Operations.Add(value1.M22, value2.M22);
            m.M23 = Operations.Add(value1.M23, value2.M23);
            m.M24 = Operations.Add(value1.M24, value2.M24);
            m.M31 = Operations.Add(value1.M31, value2.M31);
            m.M32 = Operations.Add(value1.M32, value2.M32);
            m.M33 = Operations.Add(value1.M33, value2.M33);
            m.M34 = Operations.Add(value1.M34, value2.M34);
            
            return m;
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix3x4<T> value1, Matrix3x4<T> value2)
        {
            return Operations.Equal(value1.M11, value2.M11) && Operations.Equal(value1.M22, value2.M22) &&
                   Operations.Equal(value1.M33, value2.M33) && // Check diagonal elements first for early out.
                   Operations.Equal(value1.M12, value2.M12) && Operations.Equal(value1.M13, value2.M13) &&
                   Operations.Equal(value1.M14, value2.M14) && Operations.Equal(value1.M21, value2.M21) &&
                   Operations.Equal(value1.M23, value2.M23) && Operations.Equal(value1.M24, value2.M24) &&
                   Operations.Equal(value1.M31, value2.M31) && Operations.Equal(value1.M32, value2.M32) &&
                   Operations.Equal(value1.M34, value2.M34);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix3x4<T> value1, Matrix3x4<T> value2)
        {
            return Operations.NotEqual(value1.M11, value2.M11) || Operations.NotEqual(value1.M22, value2.M22) ||
                   Operations.NotEqual(value1.M33, value2.M33) || // Check diagonal elements first for early out.
                   Operations.NotEqual(value1.M12, value2.M12) || Operations.NotEqual(value1.M13, value2.M13) ||
                   Operations.NotEqual(value1.M14, value2.M14) || Operations.NotEqual(value1.M21, value2.M21) ||
                   Operations.NotEqual(value1.M23, value2.M23) || Operations.NotEqual(value1.M24, value2.M24) ||
                   Operations.NotEqual(value1.M31, value2.M31) || Operations.NotEqual(value1.M32, value2.M32) ||
                   Operations.NotEqual(value1.M34, value2.M34);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3x3<T> operator *(Matrix3x4<T> value1, Matrix4x3<T> value2)
        {
            Matrix3x3<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21)), Operations.Add(Operations.Multiply(value1.M13, value2.M31), Operations.Multiply(value1.M14, value2.M41)));
            m.M12 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22)), Operations.Add(Operations.Multiply(value1.M13, value2.M32), Operations.Multiply(value1.M14, value2.M42)));
            m.M13 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M13), Operations.Multiply(value1.M12, value2.M23)), Operations.Add(Operations.Multiply(value1.M13, value2.M33), Operations.Multiply(value1.M14, value2.M43)));

            // Second row
            m.M21 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21)), Operations.Add(Operations.Multiply(value1.M23, value2.M31), Operations.Multiply(value1.M24, value2.M41)));
            m.M22 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22)), Operations.Add(Operations.Multiply(value1.M23, value2.M32), Operations.Multiply(value1.M24, value2.M42)));
            m.M23 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M13), Operations.Multiply(value1.M22, value2.M23)), Operations.Add(Operations.Multiply(value1.M23, value2.M33), Operations.Multiply(value1.M24, value2.M43)));

            // Third row
            m.M31 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M11), Operations.Multiply(value1.M32, value2.M21)), Operations.Add(Operations.Multiply(value1.M33, value2.M31), Operations.Multiply(value1.M34, value2.M41)));
            m.M32 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M12), Operations.Multiply(value1.M32, value2.M22)), Operations.Add(Operations.Multiply(value1.M33, value2.M32), Operations.Multiply(value1.M34, value2.M42)));
            m.M33 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M13), Operations.Multiply(value1.M32, value2.M23)), Operations.Add(Operations.Multiply(value1.M33, value2.M33), Operations.Multiply(value1.M34, value2.M43)));

           return m;
        }
        
                /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3x4<T> operator *(Matrix3x3<T> value1, Matrix3x4<T> value2)
        {
            Matrix3x4<T> m;

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

            return m;
        }

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix3x4<T> operator *(Matrix3x4<T> value1, T value2)
        {
            Matrix3x4<T> m;

            m.M11 = Operations.Multiply(value1.M11, value2);
            m.M12 = Operations.Multiply(value1.M12, value2);
            m.M13 = Operations.Multiply(value1.M13, value2);
            m.M14 = Operations.Multiply(value1.M14, value2);
            m.M21 = Operations.Multiply(value1.M21, value2);
            m.M22 = Operations.Multiply(value1.M22, value2);
            m.M23 = Operations.Multiply(value1.M23, value2);
            m.M24 = Operations.Multiply(value1.M24, value2);
            m.M31 = Operations.Multiply(value1.M31, value2);
            m.M32 = Operations.Multiply(value1.M32, value2);
            m.M33 = Operations.Multiply(value1.M33, value2);
            m.M34 = Operations.Multiply(value1.M34, value2);
            

            return m;
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix3x4<T> operator -(Matrix3x4<T> value1, Matrix3x4<T> value2)
        {
            Matrix3x4<T> m;

            m.M11 = Operations.Subtract(value1.M11, value2.M11);
            m.M12 = Operations.Subtract(value1.M12, value2.M12);
            m.M13 = Operations.Subtract(value1.M13, value2.M13);
            m.M14 = Operations.Subtract(value1.M14, value2.M14);
            m.M21 = Operations.Subtract(value1.M21, value2.M21);
            m.M22 = Operations.Subtract(value1.M22, value2.M22);
            m.M23 = Operations.Subtract(value1.M23, value2.M23);
            m.M24 = Operations.Subtract(value1.M24, value2.M24);
            m.M31 = Operations.Subtract(value1.M31, value2.M31);
            m.M32 = Operations.Subtract(value1.M32, value2.M32);
            m.M33 = Operations.Subtract(value1.M33, value2.M33);
            m.M34 = Operations.Subtract(value1.M34, value2.M34);
            
            return m;
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix3x4<T> operator -(Matrix3x4<T> value)
        {
            Matrix3x4<T> m;

            m.M11 = Operations.Negate(value.M11);
            m.M12 = Operations.Negate(value.M12);
            m.M13 = Operations.Negate(value.M13);
            m.M14 = Operations.Negate(value.M14);
            m.M21 = Operations.Negate(value.M21);
            m.M22 = Operations.Negate(value.M22);
            m.M23 = Operations.Negate(value.M23);
            m.M24 = Operations.Negate(value.M24);
            m.M31 = Operations.Negate(value.M31);
            m.M32 = Operations.Negate(value.M32);
            m.M33 = Operations.Negate(value.M33);
            m.M34 = Operations.Negate(value.M34);
            
            return m;
        }

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x4<T> Add(Matrix3x4<T> value1, Matrix3x4<T> value2)
        {
            return value1 + value2;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3<T> Multiply(Matrix3x4<T> value1, Matrix4x3<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x4<T> Multiply(Matrix3x4<T> value1, Matrix4x4<T> value2)
            => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x4<T> Multiply(Matrix3x3<T> value1, Matrix3x4<T> value2)
            => value1 * value2;
        
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4<T> Multiply(Matrix4x3<T> value1, Matrix3x4<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x4<T> Multiply(Matrix3x4<T> value1, T value2)
            => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x4<T> Negate(Matrix3x4<T> value)
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x4<T> Subtract(Matrix3x4<T> value1, Matrix3x4<T> value2)
            => value1 - value2;

        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix3x4<T> Lerp(Matrix3x4<T> matrix1, Matrix3x4<T> matrix2, T amount)
        {
            /*if (AdvSimd.IsSupported)
            {
                Vector128<T> amountVec = Vector128.Create(amount);
                AdvSimd.Store(&matrix1.M11, VectorMath.Lerp(AdvSimd.LoadVector128(&matrix1.M11), AdvSimd.LoadVector128(&matrix2.M11), amountVec));
                AdvSimd.Store(&matrix1.M21, VectorMath.Lerp(AdvSimd.LoadVector128(&matrix1.M21), AdvSimd.LoadVector128(&matrix2.M21), amountVec));
                AdvSimd.Store(&matrix1.M31, VectorMath.Lerp(AdvSimd.LoadVector128(&matrix1.M31), AdvSimd.LoadVector128(&matrix2.M31), amountVec));
                AdvSimd.Store(&matrix1.M41, VectorMath.Lerp(AdvSimd.LoadVector128(&matrix1.M41), AdvSimd.LoadVector128(&matrix2.M41), amountVec));
                return matrix1;
            }
            else if (Sse.IsSupported)
            {
                Vector128<T> amountVec = Vector128.Create(amount);
                Sse.Store(&matrix1.M11, VectorMath.Lerp(Sse.LoadVector128(&matrix1.M11), Sse.LoadVector128(&matrix2.M11), amountVec));
                Sse.Store(&matrix1.M21, VectorMath.Lerp(Sse.LoadVector128(&matrix1.M21), Sse.LoadVector128(&matrix2.M21), amountVec));
                Sse.Store(&matrix1.M31, VectorMath.Lerp(Sse.LoadVector128(&matrix1.M31), Sse.LoadVector128(&matrix2.M31), amountVec));
                Sse.Store(&matrix1.M41, VectorMath.Lerp(Sse.LoadVector128(&matrix1.M41), Sse.LoadVector128(&matrix2.M41), amountVec));
                return matrix1;
            }*/

            Matrix3x4<T> result;

            // First row
            result.M11 = Operations.Add(matrix1.M11, Operations.Multiply(Operations.Subtract(matrix2.M11, matrix1.M11), amount));
            result.M12 = Operations.Add(matrix1.M12, Operations.Multiply(Operations.Subtract(matrix2.M12, matrix1.M12), amount));
            result.M13 = Operations.Add(matrix1.M13, Operations.Multiply(Operations.Subtract(matrix2.M13, matrix1.M13), amount));
            result.M14 = Operations.Add(matrix1.M14, Operations.Multiply(Operations.Subtract(matrix2.M14, matrix1.M14), amount));

            // Second row
            result.M21 = Operations.Add(matrix1.M21, Operations.Multiply(Operations.Subtract(matrix2.M21, matrix1.M21), amount));
            result.M22 = Operations.Add(matrix1.M22, Operations.Multiply(Operations.Subtract(matrix2.M22, matrix1.M22), amount));
            result.M23 = Operations.Add(matrix1.M23, Operations.Multiply(Operations.Subtract(matrix2.M23, matrix1.M23), amount));
            result.M24 = Operations.Add(matrix1.M24, Operations.Multiply(Operations.Subtract(matrix2.M24, matrix1.M24), amount));

            // Third row
            result.M31 = Operations.Add(matrix1.M31, Operations.Multiply(Operations.Subtract(matrix2.M31, matrix1.M31), amount));
            result.M32 = Operations.Add(matrix1.M32, Operations.Multiply(Operations.Subtract(matrix2.M32, matrix1.M32), amount));
            result.M33 = Operations.Add(matrix1.M33, Operations.Multiply(Operations.Subtract(matrix2.M33, matrix1.M33), amount));
            result.M34 = Operations.Add(matrix1.M34, Operations.Multiply(Operations.Subtract(matrix2.M34, matrix1.M34), amount));

            return result;
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix3x4<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix3x4<T> other)
            => this == other;

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>   
        public override readonly int GetHashCode()
        {
            HashCode hash = default;

            hash.Add(M11);
            hash.Add(M12);
            hash.Add(M13);
            hash.Add(M14);

            hash.Add(M21);
            hash.Add(M22);
            hash.Add(M23);
            hash.Add(M24);

            hash.Add(M31);
            hash.Add(M32);
            hash.Add(M33);
            hash.Add(M34);

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1} M13:{2} M14:{3}}} {{M21:{4} M22:{5} M23:{6} M24:{7}}} {{M31:{8} M32:{9} M33:{10} M34:{11}}} }}",
                                 M11, M12, M13, M14,
                                 M21, M22, M23, M24,
                                 M31, M32, M33, M34);
        }
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix3x4<Half>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, Half>(from.M11),Operations.As<T, Half>(from.M12),
                Operations.As<T, Half>(from.M13),Operations.As<T, Half>(from.M14),
                Operations.As<T, Half>(from.M21),Operations.As<T, Half>(from.M22),
                Operations.As<T, Half>(from.M23),Operations.As<T, Half>(from.M24),
                Operations.As<T, Half>(from.M31),Operations.As<T, Half>(from.M32),
                Operations.As<T, Half>(from.M33),Operations.As<T, Half>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix3x4<float>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, float>(from.M11),Operations.As<T, float>(from.M12),
                Operations.As<T, float>(from.M13),Operations.As<T, float>(from.M14),
                Operations.As<T, float>(from.M21),Operations.As<T, float>(from.M22),
                Operations.As<T, float>(from.M23),Operations.As<T, float>(from.M24),
                Operations.As<T, float>(from.M31),Operations.As<T, float>(from.M32),
                Operations.As<T, float>(from.M33),Operations.As<T, float>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix3x4<double>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, double>(from.M11),Operations.As<T, double>(from.M12),
                Operations.As<T, double>(from.M13),Operations.As<T, double>(from.M14),
                Operations.As<T, double>(from.M21),Operations.As<T, double>(from.M22),
                Operations.As<T, double>(from.M23),Operations.As<T, double>(from.M24),
                Operations.As<T, double>(from.M31),Operations.As<T, double>(from.M32),
                Operations.As<T, double>(from.M33),Operations.As<T, double>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix3x4<decimal>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, decimal>(from.M11),Operations.As<T, decimal>(from.M12),
                Operations.As<T, decimal>(from.M13),Operations.As<T, decimal>(from.M14),
                Operations.As<T, decimal>(from.M21),Operations.As<T, decimal>(from.M22),
                Operations.As<T, decimal>(from.M23),Operations.As<T, decimal>(from.M24),
                Operations.As<T, decimal>(from.M31),Operations.As<T, decimal>(from.M32),
                Operations.As<T, decimal>(from.M33),Operations.As<T, decimal>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix3x4<sbyte>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, sbyte>(from.M11),Operations.As<T, sbyte>(from.M12),
                Operations.As<T, sbyte>(from.M13),Operations.As<T, sbyte>(from.M14),
                Operations.As<T, sbyte>(from.M21),Operations.As<T, sbyte>(from.M22),
                Operations.As<T, sbyte>(from.M23),Operations.As<T, sbyte>(from.M24),
                Operations.As<T, sbyte>(from.M31),Operations.As<T, sbyte>(from.M32),
                Operations.As<T, sbyte>(from.M33),Operations.As<T, sbyte>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix3x4<byte>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, byte>(from.M11),Operations.As<T, byte>(from.M12),
                Operations.As<T, byte>(from.M13),Operations.As<T, byte>(from.M14),
                Operations.As<T, byte>(from.M21),Operations.As<T, byte>(from.M22),
                Operations.As<T, byte>(from.M23),Operations.As<T, byte>(from.M24),
                Operations.As<T, byte>(from.M31),Operations.As<T, byte>(from.M32),
                Operations.As<T, byte>(from.M33),Operations.As<T, byte>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix3x4<ushort>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, ushort>(from.M11),Operations.As<T, ushort>(from.M12),
                Operations.As<T, ushort>(from.M13),Operations.As<T, ushort>(from.M14),
                Operations.As<T, ushort>(from.M21),Operations.As<T, ushort>(from.M22),
                Operations.As<T, ushort>(from.M23),Operations.As<T, ushort>(from.M24),
                Operations.As<T, ushort>(from.M31),Operations.As<T, ushort>(from.M32),
                Operations.As<T, ushort>(from.M33),Operations.As<T, ushort>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix3x4<short>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, short>(from.M11),Operations.As<T, short>(from.M12),
                Operations.As<T, short>(from.M13),Operations.As<T, short>(from.M14),
                Operations.As<T, short>(from.M21),Operations.As<T, short>(from.M22),
                Operations.As<T, short>(from.M23),Operations.As<T, short>(from.M24),
                Operations.As<T, short>(from.M31),Operations.As<T, short>(from.M32),
                Operations.As<T, short>(from.M33),Operations.As<T, short>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix3x4<uint>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, uint>(from.M11),Operations.As<T, uint>(from.M12),
                Operations.As<T, uint>(from.M13),Operations.As<T, uint>(from.M14),
                Operations.As<T, uint>(from.M21),Operations.As<T, uint>(from.M22),
                Operations.As<T, uint>(from.M23),Operations.As<T, uint>(from.M24),
                Operations.As<T, uint>(from.M31),Operations.As<T, uint>(from.M32),
                Operations.As<T, uint>(from.M33),Operations.As<T, uint>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix3x4<int>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, int>(from.M11),Operations.As<T, int>(from.M12),
                Operations.As<T, int>(from.M13),Operations.As<T, int>(from.M14),
                Operations.As<T, int>(from.M21),Operations.As<T, int>(from.M22),
                Operations.As<T, int>(from.M23),Operations.As<T, int>(from.M24),
                Operations.As<T, int>(from.M31),Operations.As<T, int>(from.M32),
                Operations.As<T, int>(from.M33),Operations.As<T, int>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix3x4<ulong>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, ulong>(from.M11),Operations.As<T, ulong>(from.M12),
                Operations.As<T, ulong>(from.M13),Operations.As<T, ulong>(from.M14),
                Operations.As<T, ulong>(from.M21),Operations.As<T, ulong>(from.M22),
                Operations.As<T, ulong>(from.M23),Operations.As<T, ulong>(from.M24),
                Operations.As<T, ulong>(from.M31),Operations.As<T, ulong>(from.M32),
                Operations.As<T, ulong>(from.M33),Operations.As<T, ulong>(from.M34)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix3x4<long>(Matrix3x4<T> from)
            => new
            (
                Operations.As<T, long>(from.M11),Operations.As<T, long>(from.M12),
                Operations.As<T, long>(from.M13),Operations.As<T, long>(from.M14),
                Operations.As<T, long>(from.M21),Operations.As<T, long>(from.M22),
                Operations.As<T, long>(from.M23),Operations.As<T, long>(from.M24),
                Operations.As<T, long>(from.M31),Operations.As<T, long>(from.M32),
                Operations.As<T, long>(from.M33),Operations.As<T, long>(from.M34)
            );
    }
}
