using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating a 4x4 matrix.</summary>
    public struct Matrix4x4<T> : IEquatable<Matrix4x4<T>>
        where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
    {
        private const float BillboardEpsilon = 1e-4f;
        private const float BillboardMinAngle = 1.0f - (0.1f * (MathF.PI / 180.0f)); // 0.1 degrees
        private const float DecomposeEpsilon = 0.0001f;

        private static readonly Matrix4x4<T> _identity = new
        (
            Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One
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

        /// <summary>Value at row 4, column 1 of the matrix.</summary>
        public T M41;

        /// <summary>Value at row 4, column 2 of the matrix.</summary>
        public T M42;

        /// <summary>Value at row 4, column 3 of the matrix.</summary>
        public T M43;

        /// <summary>Value at row 4, column 4 of the matrix.</summary>
        public T M44;

        /// <summary>Constructs a Matrix4x4 from the given components.</summary>
        public Matrix4x4(T m11, T m12, T m13, T m14,
                         T m21, T m22, T m23, T m24,
                         T m31, T m32, T m33, T m34,
                         T m41, T m42, T m43, T m44)
            => (M11, M12, M13, M14,
                M21, M22, M23, M24,
                M31, M32, M33, M34,
                M41, M42, M43, M44)
            =  (m11, m12, m13, m14,
                m21, m22, m23, m24,
                m31, m32, m33, m34,
                m41, m42, m43, m44);

        /// <summary>Constructs a Matrix4x4 from the given Matrix3x2.</summary>
        /// <param name="value">The source Matrix3x2.</param>
        public Matrix4x4(Matrix3x2<T> value)
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

            M41 = value.M31;
            M42 = value.M32;
            M43 = Constants<T>.Zero;
            M44 = Constants<T>.One;
        }

        /// <summary>Constructs a Matrix4x4 from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix4x4(Matrix4x3<T> value)
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

            M41 = value.M31;
            M42 = value.M32;
            M43 = value.M43;
            M44 = Constants<T>.One;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix4x4<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        public readonly bool IsIdentity
            => Operations.Equal(M11, Constants<T>.One) && Operations.Equal(M22, Constants<T>.One) &&
               Operations.Equal(M33, Constants<T>.One) &&
               Operations.Equal(M44, Constants<T>.One) && // Check diagonal element first for early out.
               Operations.Equal(M12, Constants<T>.Zero) && Operations.Equal(M13, Constants<T>.Zero) &&
               Operations.Equal(M14, Constants<T>.Zero) && Operations.Equal(M21, Constants<T>.Zero) &&
               Operations.Equal(M23, Constants<T>.Zero) && Operations.Equal(M24, Constants<T>.Zero) &&
               Operations.Equal(M31, Constants<T>.Zero) && Operations.Equal(M32, Constants<T>.Zero) &&
               Operations.Equal(M34, Constants<T>.Zero) && Operations.Equal(M41, Constants<T>.Zero) &&
               Operations.Equal(M42, Constants<T>.Zero) && Operations.Equal(M43, Constants<T>.Zero);

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
        public static unsafe Matrix4x4<T> operator +(Matrix4x4<T> value1, Matrix4x4<T> value2)
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

            Matrix4x4<T> m;

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
            m.M41 = Operations.Add(value1.M41, value2.M41);
            m.M42 = Operations.Add(value1.M42, value2.M42);
            m.M43 = Operations.Add(value1.M43, value2.M43);
            m.M44 = Operations.Add(value1.M44, value2.M44);
            
            return m;
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are equal; False otherwise.</returns>
        public static unsafe bool operator ==(Matrix4x4<T> value1, Matrix4x4<T> value2)
        {
            /*if (AdvSimd.Arm64.IsSupported)
            {
                return VectorMath.Equal(AdvSimd.LoadVector128(&value1.M11), AdvSimd.LoadVector128(&value2.M11)) &&
                       VectorMath.Equal(AdvSimd.LoadVector128(&value1.M21), AdvSimd.LoadVector128(&value2.M21)) &&
                       VectorMath.Equal(AdvSimd.LoadVector128(&value1.M31), AdvSimd.LoadVector128(&value2.M31)) &&
                       VectorMath.Equal(AdvSimd.LoadVector128(&value1.M41), AdvSimd.LoadVector128(&value2.M41));
            }
            else if (Sse.IsSupported)
            {
                return VectorMath.Equal(Sse.LoadVector128(&value1.M11), Sse.LoadVector128(&value2.M11)) &&
                       VectorMath.Equal(Sse.LoadVector128(&value1.M21), Sse.LoadVector128(&value2.M21)) &&
                       VectorMath.Equal(Sse.LoadVector128(&value1.M31), Sse.LoadVector128(&value2.M31)) &&
                       VectorMath.Equal(Sse.LoadVector128(&value1.M41), Sse.LoadVector128(&value2.M41));
            }*/

            return Operations.Equal(value1.M11, value2.M11) && Operations.Equal(value1.M22, value2.M22) &&
                   Operations.Equal(value1.M33, value2.M33) &&
                   Operations.Equal(value1.M44, value2.M44) && // Check diagonal elements first for early out.
                   Operations.Equal(value1.M12, value2.M12) && Operations.Equal(value1.M13, value2.M13) &&
                   Operations.Equal(value1.M14, value2.M14) && Operations.Equal(value1.M21, value2.M21) &&
                   Operations.Equal(value1.M23, value2.M23) && Operations.Equal(value1.M24, value2.M24) &&
                   Operations.Equal(value1.M31, value2.M31) && Operations.Equal(value1.M32, value2.M32) &&
                   Operations.Equal(value1.M34, value2.M34) && Operations.Equal(value1.M41, value2.M41) &&
                   Operations.Equal(value1.M42, value2.M42) && Operations.Equal(value1.M43, value2.M43);
        }

        /// <summary>Returns a boolean indicating whether the given two matrices are not equal.</summary>
        /// <param name="value1">The first matrix to compare.</param>
        /// <param name="value2">The second matrix to compare.</param>
        /// <returns>True if the given matrices are not equal; False if they are equal.</returns>
        public static unsafe bool operator !=(Matrix4x4<T> value1, Matrix4x4<T> value2)
        {
            /*if (AdvSimd.Arm64.IsSupported)
            {
                return VectorMath.NotEqual(AdvSimd.LoadVector128(&value1.M11), AdvSimd.LoadVector128(&value2.M11)) ||
                       VectorMath.NotEqual(AdvSimd.LoadVector128(&value1.M21), AdvSimd.LoadVector128(&value2.M21)) ||
                       VectorMath.NotEqual(AdvSimd.LoadVector128(&value1.M31), AdvSimd.LoadVector128(&value2.M31)) ||
                       VectorMath.NotEqual(AdvSimd.LoadVector128(&value1.M41), AdvSimd.LoadVector128(&value2.M41));
            }
            else if (Sse.IsSupported)
            {
                return
                    VectorMath.NotEqual(Sse.LoadVector128(&value1.M11), Sse.LoadVector128(&value2.M11)) ||
                    VectorMath.NotEqual(Sse.LoadVector128(&value1.M21), Sse.LoadVector128(&value2.M21)) ||
                    VectorMath.NotEqual(Sse.LoadVector128(&value1.M31), Sse.LoadVector128(&value2.M31)) ||
                    VectorMath.NotEqual(Sse.LoadVector128(&value1.M41), Sse.LoadVector128(&value2.M41));
            }*/

            return Operations.NotEqual(value1.M11, value2.M11) || Operations.NotEqual(value1.M22, value2.M22) ||
                   Operations.NotEqual(value1.M33, value2.M33) ||
                   Operations.NotEqual(value1.M44, value2.M44) || // Check diagonal elements first for early out.
                   Operations.NotEqual(value1.M12, value2.M12) || Operations.NotEqual(value1.M13, value2.M13) ||
                   Operations.NotEqual(value1.M14, value2.M14) || Operations.NotEqual(value1.M21, value2.M21) ||
                   Operations.NotEqual(value1.M23, value2.M23) || Operations.NotEqual(value1.M24, value2.M24) ||
                   Operations.NotEqual(value1.M31, value2.M31) || Operations.NotEqual(value1.M32, value2.M32) ||
                   Operations.NotEqual(value1.M34, value2.M34) || Operations.NotEqual(value1.M41, value2.M41) ||
                   Operations.NotEqual(value1.M42, value2.M42) || Operations.NotEqual(value1.M43, value2.M43);
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix4x4<T> operator *(Matrix4x4<T> value1, Matrix4x4<T> value2)
        {
            /*if (AdvSimd.Arm64.IsSupported)
            {
                Unsafe.SkipInit(out Matrix4x4 result);

                // Perform the operation on the first row

                Vector128<T> M11 = AdvSimd.LoadVector128(&value1.M11);

                Vector128<T> vX = AdvSimd.MultiplyBySelectedScalar(AdvSimd.LoadVector128(&value2.M11), M11, 0);
                Vector128<T> vY = AdvSimd.MultiplyBySelectedScalar(AdvSimd.LoadVector128(&value2.M21), M11, 1);
                Vector128<T> vZ = AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(vX, AdvSimd.LoadVector128(&value2.M31), M11, 2);
                Vector128<T> vW = AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(vY, AdvSimd.LoadVector128(&value2.M41), M11, 3);

                AdvSimd.Store(&result.M11, AdvSimd.Add(vZ, vW));

                // Repeat for the other 3 rows

                Vector128<T> M21 = AdvSimd.LoadVector128(&value1.M21);

                vX = AdvSimd.MultiplyBySelectedScalar(AdvSimd.LoadVector128(&value2.M11), M21, 0);
                vY = AdvSimd.MultiplyBySelectedScalar(AdvSimd.LoadVector128(&value2.M21), M21, 1);
                vZ = AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(vX, AdvSimd.LoadVector128(&value2.M31), M21, 2);
                vW = AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(vY, AdvSimd.LoadVector128(&value2.M41), M21, 3);

                AdvSimd.Store(&result.M21, AdvSimd.Add(vZ, vW));

                Vector128<T> M31 = AdvSimd.LoadVector128(&value1.M31);

                vX = AdvSimd.MultiplyBySelectedScalar(AdvSimd.LoadVector128(&value2.M11), M31, 0);
                vY = AdvSimd.MultiplyBySelectedScalar(AdvSimd.LoadVector128(&value2.M21), M31, 1);
                vZ = AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(vX, AdvSimd.LoadVector128(&value2.M31), M31, 2);
                vW = AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(vY, AdvSimd.LoadVector128(&value2.M41), M31, 3);

                AdvSimd.Store(&result.M31, AdvSimd.Add(vZ, vW));

                Vector128<T> M41 = AdvSimd.LoadVector128(&value1.M41);

                vX = AdvSimd.MultiplyBySelectedScalar(AdvSimd.LoadVector128(&value2.M11), M41, 0);
                vY = AdvSimd.MultiplyBySelectedScalar(AdvSimd.LoadVector128(&value2.M21), M41, 1);
                vZ = AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(vX, AdvSimd.LoadVector128(&value2.M31), M41, 2);
                vW = AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(vY, AdvSimd.LoadVector128(&value2.M41), M41, 3);

                AdvSimd.Store(&result.M41, AdvSimd.Add(vZ, vW));

                return result;
            }
            else if (Sse.IsSupported)
            {
                Vector128<T> row = Sse.LoadVector128(&value1.M11);
                Sse.Store(&value1.M11,
                    Sse.Add(Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0x00), Sse.LoadVector128(&value2.M11)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0x55), Sse.LoadVector128(&value2.M21))),
                            Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0xAA), Sse.LoadVector128(&value2.M31)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0xFF), Sse.LoadVector128(&value2.M41)))));

                // 0x00 is _MM_SHUFFLE(0,0,0,0), 0x55 is _MM_SHUFFLE(1,1,1,1), etc.
                // TODO: Replace with a method once it's added to the API.

                row = Sse.LoadVector128(&value1.M21);
                Sse.Store(&value1.M21,
                    Sse.Add(Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0x00), Sse.LoadVector128(&value2.M11)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0x55), Sse.LoadVector128(&value2.M21))),
                            Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0xAA), Sse.LoadVector128(&value2.M31)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0xFF), Sse.LoadVector128(&value2.M41)))));

                row = Sse.LoadVector128(&value1.M31);
                Sse.Store(&value1.M31,
                    Sse.Add(Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0x00), Sse.LoadVector128(&value2.M11)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0x55), Sse.LoadVector128(&value2.M21))),
                            Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0xAA), Sse.LoadVector128(&value2.M31)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0xFF), Sse.LoadVector128(&value2.M41)))));

                row = Sse.LoadVector128(&value1.M41);
                Sse.Store(&value1.M41,
                    Sse.Add(Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0x00), Sse.LoadVector128(&value2.M11)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0x55), Sse.LoadVector128(&value2.M21))),
                            Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0xAA), Sse.LoadVector128(&value2.M31)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0xFF), Sse.LoadVector128(&value2.M41)))));
                return value1;
            }*/

            Matrix4x4<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21)), Operations.Add(Operations.Multiply(value1.M13, value2.M31), Operations.Multiply(value1.M14, value2.M41)));
            m.M12 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22)), Operations.Add(Operations.Multiply(value1.M13, value2.M32), Operations.Multiply(value1.M14, value2.M42)));
            m.M13 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M13), Operations.Multiply(value1.M12, value2.M23)), Operations.Add(Operations.Multiply(value1.M13, value2.M33), Operations.Multiply(value1.M14, value2.M43)));
            m.M14 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M14), Operations.Multiply(value1.M12, value2.M24)), Operations.Add(Operations.Multiply(value1.M13, value2.M34), Operations.Multiply(value1.M14, value2.M44)));

            // Second row
            m.M21 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21)), Operations.Add(Operations.Multiply(value1.M23, value2.M31), Operations.Multiply(value1.M24, value2.M41)));
            m.M22 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22)), Operations.Add(Operations.Multiply(value1.M23, value2.M32), Operations.Multiply(value1.M24, value2.M42)));
            m.M23 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M13), Operations.Multiply(value1.M22, value2.M23)), Operations.Add(Operations.Multiply(value1.M23, value2.M33), Operations.Multiply(value1.M24, value2.M43)));
            m.M24 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M14), Operations.Multiply(value1.M22, value2.M24)), Operations.Add(Operations.Multiply(value1.M23, value2.M34), Operations.Multiply(value1.M24, value2.M44)));

            // Third row
            m.M31 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M11), Operations.Multiply(value1.M32, value2.M21)), Operations.Add(Operations.Multiply(value1.M33, value2.M31), Operations.Multiply(value1.M34, value2.M41)));
            m.M32 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M12), Operations.Multiply(value1.M32, value2.M22)), Operations.Add(Operations.Multiply(value1.M33, value2.M32), Operations.Multiply(value1.M34, value2.M42)));
            m.M33 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M13), Operations.Multiply(value1.M32, value2.M23)), Operations.Add(Operations.Multiply(value1.M33, value2.M33), Operations.Multiply(value1.M34, value2.M43)));
            m.M34 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M14), Operations.Multiply(value1.M32, value2.M24)), Operations.Add(Operations.Multiply(value1.M33, value2.M34), Operations.Multiply(value1.M34, value2.M44)));

            // Fourth row
            m.M41 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M11), Operations.Multiply(value1.M42, value2.M21)), Operations.Add(Operations.Multiply(value1.M43, value2.M31), Operations.Multiply(value1.M44, value2.M41)));
            m.M42 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M12), Operations.Multiply(value1.M42, value2.M22)), Operations.Add(Operations.Multiply(value1.M43, value2.M32), Operations.Multiply(value1.M44, value2.M42)));
            m.M43 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M13), Operations.Multiply(value1.M42, value2.M23)), Operations.Add(Operations.Multiply(value1.M43, value2.M33), Operations.Multiply(value1.M44, value2.M43)));
            m.M44 = Operations.Add(Operations.Add(Operations.Multiply(value1.M41, value2.M14), Operations.Multiply(value1.M42, value2.M24)), Operations.Add(Operations.Multiply(value1.M43, value2.M34), Operations.Multiply(value1.M44, value2.M44)));

            return m;
        }

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        public static unsafe Matrix4x4<T> operator *(Matrix4x4<T> value1, T value2)
        {
            /*if (AdvSimd.IsSupported)
            {
                Vector128<T> value2Vec = Vector128.Create(value2);
                AdvSimd.Store(&value1.M11, AdvSimd.Multiply(AdvSimd.LoadVector128(&value1.M11), value2Vec));
                AdvSimd.Store(&value1.M21, AdvSimd.Multiply(AdvSimd.LoadVector128(&value1.M21), value2Vec));
                AdvSimd.Store(&value1.M31, AdvSimd.Multiply(AdvSimd.LoadVector128(&value1.M31), value2Vec));
                AdvSimd.Store(&value1.M41, AdvSimd.Multiply(AdvSimd.LoadVector128(&value1.M41), value2Vec));
                return value1;
            }
            else if (Sse.IsSupported)
            {
                Vector128<T> value2Vec = Vector128.Create(value2);
                Sse.Store(&value1.M11, Sse.Multiply(Sse.LoadVector128(&value1.M11), value2Vec));
                Sse.Store(&value1.M21, Sse.Multiply(Sse.LoadVector128(&value1.M21), value2Vec));
                Sse.Store(&value1.M31, Sse.Multiply(Sse.LoadVector128(&value1.M31), value2Vec));
                Sse.Store(&value1.M41, Sse.Multiply(Sse.LoadVector128(&value1.M41), value2Vec));
                return value1;
            }*/

            Matrix4x4<T> m;

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
            m.M41 = Operations.Multiply(value1.M41, value2);
            m.M42 = Operations.Multiply(value1.M42, value2);
            m.M43 = Operations.Multiply(value1.M43, value2);
            m.M44 = Operations.Multiply(value1.M44, value2);
            

            return m;
        }

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        public static unsafe Matrix4x4<T> operator -(Matrix4x4<T> value1, Matrix4x4<T> value2)
        {
            /*if (AdvSimd.IsSupported)
            {
                AdvSimd.Store(&value1.M11, AdvSimd.Subtract(AdvSimd.LoadVector128(&value1.M11), AdvSimd.LoadVector128(&value2.M11)));
                AdvSimd.Store(&value1.M21, AdvSimd.Subtract(AdvSimd.LoadVector128(&value1.M21), AdvSimd.LoadVector128(&value2.M21)));
                AdvSimd.Store(&value1.M31, AdvSimd.Subtract(AdvSimd.LoadVector128(&value1.M31), AdvSimd.LoadVector128(&value2.M31)));
                AdvSimd.Store(&value1.M41, AdvSimd.Subtract(AdvSimd.LoadVector128(&value1.M41), AdvSimd.LoadVector128(&value2.M41)));
                return value1;
            }
            else if (Sse.IsSupported)
            {
                Sse.Store(&value1.M11, Sse.Subtract(Sse.LoadVector128(&value1.M11), Sse.LoadVector128(&value2.M11)));
                Sse.Store(&value1.M21, Sse.Subtract(Sse.LoadVector128(&value1.M21), Sse.LoadVector128(&value2.M21)));
                Sse.Store(&value1.M31, Sse.Subtract(Sse.LoadVector128(&value1.M31), Sse.LoadVector128(&value2.M31)));
                Sse.Store(&value1.M41, Sse.Subtract(Sse.LoadVector128(&value1.M41), Sse.LoadVector128(&value2.M41)));
                return value1;
            }*/

            Matrix4x4<T> m;

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
            m.M41 = Operations.Subtract(value1.M41, value2.M41);
            m.M42 = Operations.Subtract(value1.M42, value2.M42);
            m.M43 = Operations.Subtract(value1.M43, value2.M43);
            m.M44 = Operations.Subtract(value1.M44, value2.M44);
            
            return m;
        }

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static unsafe Matrix4x4<T> operator -(Matrix4x4<T> value)
        {
            /*if (AdvSimd.IsSupported)
            {
                AdvSimd.Store(&value.M11, AdvSimd.Negate(AdvSimd.LoadVector128(&value.M11)));
                AdvSimd.Store(&value.M21, AdvSimd.Negate(AdvSimd.LoadVector128(&value.M21)));
                AdvSimd.Store(&value.M31, AdvSimd.Negate(AdvSimd.LoadVector128(&value.M31)));
                AdvSimd.Store(&value.M41, AdvSimd.Negate(AdvSimd.LoadVector128(&value.M41)));
                return value;
            }
            else if (Sse.IsSupported)
            {
                Vector128<T> zero = Vector128<T>.Zero;
                Sse.Store(&value.M11, Sse.Subtract(zero, Sse.LoadVector128(&value.M11)));
                Sse.Store(&value.M21, Sse.Subtract(zero, Sse.LoadVector128(&value.M21)));
                Sse.Store(&value.M31, Sse.Subtract(zero, Sse.LoadVector128(&value.M31)));
                Sse.Store(&value.M41, Sse.Subtract(zero, Sse.LoadVector128(&value.M41)));
                return value;
            }*/

            Matrix4x4<T> m;

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
            m.M41 = Operations.Negate(value.M41);
            m.M42 = Operations.Negate(value.M42);
            m.M43 = Operations.Negate(value.M43);
            m.M44 = Operations.Negate(value.M44);
            
            return m;
        }

        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4<T> Add(Matrix4x4<T> value1, Matrix4x4<T> value2)
        {
            return value1 + value2;
        }

        /// <summary>Creates a spherical billboard that rotates around a specified object position.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="cameraUpVector">The up vector of the camera.</param>
        /// <param name="cameraForwardVector">The forward vector of the camera.</param>
        /// <returns>The created billboard matrix</returns>
        public static Matrix4x4<T> CreateBillboard(Vector3<T> objectPosition, Vector3<T> cameraPosition, Vector3<T> cameraUpVector, Vector3<T> cameraForwardVector)
        {
            Vector3<T> zaxis = objectPosition - cameraPosition;
            var norm = zaxis.LengthSquared();

            if (!Operations.GreaterThanOrEqual(norm, Operations.As<float, T>(BillboardEpsilon)))
            {
                zaxis = -cameraForwardVector;
            }
            else
            {
                zaxis = Vector3<T>.Multiply(zaxis, Operations.Divide(Constants<T>.One, Operations.Sqrt(norm)));
            }

            Vector3<T> xaxis = Vector3<T>.Normalize(Vector3<T>.Cross(cameraUpVector, zaxis));
            Vector3<T> yaxis = Vector3<T>.Cross(zaxis, xaxis);

            Matrix4x4<T> result;

            result.M11 = xaxis.X;
            result.M12 = xaxis.Y;
            result.M13 = xaxis.Z;
            result.M14 = Constants<T>.Zero;

            result.M21 = yaxis.X;
            result.M22 = yaxis.Y;
            result.M23 = yaxis.Z;
            result.M24 = Constants<T>.Zero;

            result.M31 = zaxis.X;
            result.M32 = zaxis.Y;
            result.M33 = zaxis.Z;
            result.M34 = Constants<T>.Zero;

            result.M41 = objectPosition.X;
            result.M42 = objectPosition.Y;
            result.M43 = objectPosition.Z;
            result.M44 = Constants<T>.One;

            return result;
        }

        /// <summary>Creates a cylindrical billboard that rotates around a specified axis.</summary>
        /// <param name="objectPosition">Position of the object the billboard will rotate around.</param>
        /// <param name="cameraPosition">Position of the camera.</param>
        /// <param name="rotateAxis">Axis to rotate the billboard around.</param>
        /// <param name="cameraForwardVector">Forward vector of the camera.</param>
        /// <param name="objectForwardVector">Forward vector of the object.</param>
        /// <returns>The created billboard matrix.</returns>
        public static Matrix4x4<T> CreateConstrainedBillboard(Vector3<T> objectPosition, Vector3<T> cameraPosition, Vector3<T> rotateAxis, Vector3<T> cameraForwardVector, Vector3<T> objectForwardVector)
        {
            // Treat the case when object and camera positions are too close.
            Vector3<T> faceDir = objectPosition - cameraPosition;
            T norm = faceDir.LengthSquared();

            if (!Operations.GreaterThanOrEqual(norm, Operations.As<float, T>(BillboardEpsilon)))
            {
                faceDir = -cameraForwardVector;
            }
            else
            {
                faceDir = Vector3<T>.Multiply(faceDir, Operations.Divide(Constants<T>.One, Operations.Sqrt(norm)));
            }

            Vector3<T> yaxis = rotateAxis;
            Vector3<T> xaxis;
            Vector3<T> zaxis;

            // Treat the case when angle between faceDir and rotateAxis is too close to 0.
            T dot = Vector3<T>.Dot(rotateAxis, faceDir);

            if (Operations.GreaterThan(Operations.Abs(dot), Operations.As<float, T>(BillboardMinAngle)))
            {
                zaxis = objectForwardVector;

                // Make sure passed values are useful for compute.
                dot = Vector3<T>.Dot(rotateAxis, zaxis);

                if (Operations.GreaterThan(Operations.Abs(dot), Operations.As<float, T>(BillboardMinAngle)))
                {
                    zaxis =
                        Operations.GreaterThan(Operations.Abs(rotateAxis.Z), Operations.As<float, T>(BillboardMinAngle))
                            ? new Vector3<T>(Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero)
                            : new Vector3<T>(Constants<T>.Zero, Constants<T>.Zero, Constants<T>.MinusOne);
                }

                xaxis = Vector3<T>.Normalize(Vector3<T>.Cross(rotateAxis, zaxis));
                zaxis = Vector3<T>.Normalize(Vector3<T>.Cross(xaxis, rotateAxis));
            }
            else
            {
                xaxis = Vector3<T>.Normalize(Vector3<T>.Cross(rotateAxis, faceDir));
                zaxis = Vector3<T>.Normalize(Vector3<T>.Cross(xaxis, yaxis));
            }

            Matrix4x4<T> result;

            result.M11 = xaxis.X;
            result.M12 = xaxis.Y;
            result.M13 = xaxis.Z;
            result.M14 = Constants<T>.Zero;

            result.M21 = yaxis.X;
            result.M22 = yaxis.Y;
            result.M23 = yaxis.Z;
            result.M24 = Constants<T>.Zero;

            result.M31 = zaxis.X;
            result.M32 = zaxis.Y;
            result.M33 = zaxis.Z;
            result.M34 = Constants<T>.Zero;

            result.M41 = objectPosition.X;
            result.M42 = objectPosition.Y;
            result.M43 = objectPosition.Z;
            result.M44 = Constants<T>.One;

            return result;
        }

        /// <summary>Creates a matrix that rotates around an arbitrary vector.</summary>
        /// <param name="axis">The axis to rotate around.</param>
        /// <param name="angle">The angle to rotate around the given axis, in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4x4<T> CreateFromAxisAngle(Vector3<T> axis, T angle)
        {
            // a: angle
            // x, y, z: unit vector for axis.
            //
            // Rotation matrix M can compute by using below equation.
            //
            //        T               T
            //  M = uu + (cos a)( I-uu ) + (sin a)S
            //
            // Where:
            //
            //  u = ( x, y, z )
            //
            //      [  0 -z  y ]
            //  S = [  z  0 -x ]
            //      [ -y  x  0 ]
            //
            //      [ 1 0 0 ]
            //  I = [ 0 1 0 ]
            //      [ 0 0 1 ]
            //
            //
            //     [  xx+cosa*(1-xx)   yx-cosa*yx-sina*z zx-cosa*xz+sina*y ]
            // M = [ xy-cosa*yx+sina*z    yy+cosa(1-yy)  yz-cosa*yz-sina*x ]
            //     [ zx-cosa*zx-sina*y zy-cosa*zy+sina*x   zz+cosa*(1-zz)  ]
            //
            T x = axis.X, y = axis.Y, z = axis.Z;
            T sa = Operations.Sin(angle), ca = Operations.Cos(angle);
            T xx = Operations.Multiply(x, x), yy = Operations.Multiply(y, y), zz = Operations.Multiply(z, z);
            T xy = Operations.Multiply(x, y), xz = Operations.Multiply(x, z), yz = Operations.Multiply(y, z);

            Matrix4x4<T> result = Identity;

            result.M11 = Operations.Add(xx, Operations.Multiply(ca, Operations.Subtract(Constants<T>.One, xx)));
            result.M12 = Operations.Add(Operations.Subtract(xy, Operations.Multiply(ca, xy)), Operations.Multiply(sa, z));
            result.M13 = Operations.Subtract(Operations.Subtract(xz, Operations.Multiply(ca, xz)), Operations.Multiply(sa, y));

            result.M21 = Operations.Subtract(Operations.Subtract(xy, Operations.Multiply(ca, xy)), Operations.Multiply(sa, z));
            result.M22 = Operations.Add(yy, Operations.Multiply(ca, Operations.Subtract(Constants<T>.One, yy)));
            result.M23 = Operations.Add(Operations.Subtract(yz, Operations.Multiply(ca, yz)), Operations.Multiply(sa, x));

            result.M31 = Operations.Add(Operations.Subtract(xz, Operations.Multiply(ca, xz)), Operations.Multiply(sa, y));
            result.M32 = Operations.Subtract(Operations.Subtract(yz, Operations.Multiply(ca, yz)), Operations.Multiply(sa, x));
            result.M33 = Operations.Add(zz, Operations.Multiply(ca, Operations.Subtract(Constants<T>.One, zz)));

            return result;
        }

        /// <summary>Creates a rotation matrix from the given Quaternion rotation value.</summary>
        /// <param name="quaternion">The source Quaternion.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4x4<T> CreateFromQuaternion(Quaternion<T> quaternion)
        {
            Matrix4x4<T> result = Identity;

            T xx = Operations.Multiply(quaternion.X, quaternion.X);
            T yy = Operations.Multiply(quaternion.Y, quaternion.Y);
            T zz = Operations.Multiply(quaternion.Z, quaternion.Z);

            T xy = Operations.Multiply(quaternion.X, quaternion.Y);
            T wz = Operations.Multiply(quaternion.Z, quaternion.W);
            T xz = Operations.Multiply(quaternion.Z, quaternion.X);
            T wy = Operations.Multiply(quaternion.Y, quaternion.W);
            T yz = Operations.Multiply(quaternion.Y, quaternion.Z);
            T wx = Operations.Multiply(quaternion.X, quaternion.W);

            result.M11 = Operations.Subtract(Constants<T>.One, Operations.Multiply(Constants<T>.Two, Operations.Add(yy, zz)));
            result.M12 = Operations.Multiply(Constants<T>.Two, Operations.Add(xy, wz));
            result.M13 = Operations.Multiply(Constants<T>.Two, Operations.Subtract(xz, wy));

            result.M21 = Operations.Multiply(Constants<T>.Two, Operations.Subtract(xy, wz));
            result.M22 = Operations.Subtract(Constants<T>.One, Operations.Multiply(Constants<T>.Two, Operations.Add(zz, xx)));
            result.M23 = Operations.Multiply(Constants<T>.Two, Operations.Add(yz, wx));

            result.M31 = Operations.Multiply(Constants<T>.Two, Operations.Add(xz, wy));
            result.M32 = Operations.Multiply(Constants<T>.Two, Operations.Subtract(yz, wx));
            result.M33 = Operations.Subtract(Constants<T>.One, Operations.Multiply(Constants<T>.Two, Operations.Add(yy, xx)));

            return result;
        }
        

        /// <summary>Creates a rotation matrix from the specified yaw, pitch, and roll.</summary>
        /// <param name="yaw">Angle of rotation, in radians, around the Y-axis.</param>
        /// <param name="pitch">Angle of rotation, in radians, around the X-axis.</param>
        /// <param name="roll">Angle of rotation, in radians, around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4x4<T> CreateFromYawPitchRoll(T yaw, T pitch, T roll)
        {
            Quaternion<T> q = Quaternion<T>.CreateFromYawPitchRoll(yaw, pitch, roll);
            return CreateFromQuaternion(q);
        }

        /// <summary>Creates a view matrix.</summary>
        /// <param name="cameraPosition">The position of the camera.</param>
        /// <param name="cameraTarget">The target towards which the camera is pointing.</param>
        /// <param name="cameraUpVector">The direction that is "up" from the camera's point of view.</param>
        /// <returns>The view matrix.</returns>
        public static Matrix4x4<T> CreateLookAt(Vector3<T> cameraPosition, Vector3<T> cameraTarget, Vector3<T> cameraUpVector)
        {
            Vector3<T> zaxis = Vector3<T>.Normalize(cameraPosition - cameraTarget);
            Vector3<T> xaxis = Vector3<T>.Normalize(Vector3<T>.Cross(cameraUpVector, zaxis));
            Vector3<T> yaxis = Vector3<T>.Cross(zaxis, xaxis);

            Matrix4x4<T> result = Identity;

            result.M11 = xaxis.X;
            result.M12 = yaxis.X;
            result.M13 = zaxis.X;

            result.M21 = xaxis.Y;
            result.M22 = yaxis.Y;
            result.M23 = zaxis.Y;

            result.M31 = xaxis.Z;
            result.M32 = yaxis.Z;
            result.M33 = zaxis.Z;

            result.M41 = Operations.Negate(Vector3<T>.Dot(xaxis, cameraPosition));
            result.M42 = Operations.Negate(Vector3<T>.Dot(yaxis, cameraPosition));
            result.M43 = Operations.Negate(Vector3<T>.Dot(zaxis, cameraPosition));

            return result;
        }

        /// <summary>Creates an orthographic perspective matrix from the given view volume dimensions.</summary>
        /// <param name="width">Width of the view volume.</param>
        /// <param name="height">Height of the view volume.</param>
        /// <param name="zNearPlane">Minimum Z-value of the view volume.</param>
        /// <param name="zFarPlane">Maximum Z-value of the view volume.</param>
        /// <returns>The orthographic projection matrix.</returns>
        public static Matrix4x4<T> CreateOrthographic(T width, T height, T zNearPlane, T zFarPlane)
        {
            Matrix4x4<T> result = Identity;

            result.M11 = Operations.Divide(Constants<T>.Two, width);
            result.M22 = Operations.Divide(Constants<T>.Two, height);
            result.M33 = Operations.Divide(Constants<T>.One, Operations.Subtract(zNearPlane, zFarPlane));
            result.M43 = Operations.Divide(zNearPlane, Operations.Subtract(zNearPlane, zFarPlane));

            return result;
        }

        /// <summary>Builds a customized, orthographic projection matrix.</summary>
        /// <param name="left">Minimum X-value of the view volume.</param>
        /// <param name="right">Maximum X-value of the view volume.</param>
        /// <param name="bottom">Minimum Y-value of the view volume.</param>
        /// <param name="top">Maximum Y-value of the view volume.</param>
        /// <param name="zNearPlane">Minimum Z-value of the view volume.</param>
        /// <param name="zFarPlane">Maximum Z-value of the view volume.</param>
        /// <returns>The orthographic projection matrix.</returns>
        public static Matrix4x4<T> CreateOrthographicOffCenter(T left, T right, T bottom, T top, T zNearPlane, T zFarPlane)
        {
            Matrix4x4<T> result = Identity;

            result.M11 = Operations.Divide(Constants<T>.Two, Operations.Subtract(right, left));

            result.M22 = Operations.Divide(Constants<T>.Two, Operations.Subtract(top, bottom));

            result.M33 = Operations.Divide(Constants<T>.One, Operations.Subtract(zNearPlane, zFarPlane));

            result.M41 = Operations.Divide(Operations.Add(left, right), Operations.Subtract(left, right));
            result.M42 = Operations.Divide(Operations.Add(top, bottom), Operations.Subtract(bottom, top));
            result.M43 = Operations.Divide(zNearPlane, Operations.Subtract(zNearPlane, zFarPlane));

            return result;
        }

        /// <summary>Creates a perspective projection matrix from the given view volume dimensions.</summary>
        /// <param name="width">Width of the view volume at the near view plane.</param>
        /// <param name="height">Height of the view volume at the near view plane.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4x4<T> CreatePerspective(T width, T height, T nearPlaneDistance, T farPlaneDistance)
        {
            if (!Operations.GreaterThan(nearPlaneDistance, Constants<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!Operations.GreaterThan(farPlaneDistance, Constants<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            if (Operations.GreaterThanOrEqual(nearPlaneDistance, farPlaneDistance))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            Matrix4x4<T> result;

            result.M11 = Operations.Divide(Operations.Multiply(Constants<T>.Two, nearPlaneDistance), width);
            result.M12 = result.M13 = result.M14 = Constants<T>.Zero;

            result.M22 = Operations.Divide(Operations.Multiply(Constants<T>.Two, nearPlaneDistance), height);
            result.M21 = result.M23 = result.M24 = Constants<T>.Zero;

            T negFarRange = Operations.IsPositiveInfinity(farPlaneDistance)
                ? Constants<T>.MinusOne
                : Operations.Divide(farPlaneDistance, Operations.Subtract(nearPlaneDistance, farPlaneDistance));
            result.M33 = negFarRange;
            result.M31 = result.M32 = Constants<T>.Zero;
            result.M34 = Constants<T>.MinusOne;

            result.M41 = result.M42 = result.M44 = Constants<T>.Zero;
            result.M43 = Operations.Multiply(nearPlaneDistance, negFarRange);

            return result;
        }

        /// <summary>Creates a perspective projection matrix based on a field of view, aspect ratio, and near and far view plane distances.</summary>
        /// <param name="fieldOfView">Field of view in the y direction, in radians.</param>
        /// <param name="aspectRatio">Aspect ratio, defined as view space width divided by height.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4x4<T> CreatePerspectiveFieldOfView(T fieldOfView, T aspectRatio, T nearPlaneDistance, T farPlaneDistance)
        {
            if (!Operations.GreaterThan(fieldOfView, Constants<T>.Zero) || Operations.GreaterThanOrEqual(fieldOfView , Constants<T>.Pi))
                throw new ArgumentOutOfRangeException(nameof(fieldOfView));

            if (!Operations.GreaterThan(nearPlaneDistance, Constants<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!Operations.GreaterThan(farPlaneDistance , Constants<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            if (Operations.GreaterThanOrEqual(nearPlaneDistance, farPlaneDistance))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            T yScale = Operations.Divide(Constants<T>.One, Operations.Tan(Operations.Divide(fieldOfView, Constants<T>.Two)));
            T xScale = Operations.Divide(yScale, aspectRatio);

            Matrix4x4<T> result;

            result.M11 = xScale;
            result.M12 = result.M13 = result.M14 = Constants<T>.Zero;

            result.M22 = yScale;
            result.M21 = result.M23 = result.M24 = Constants<T>.Zero;

            result.M31 = result.M32 = Constants<T>.Zero;
            T negFarRange = Operations.IsPositiveInfinity(farPlaneDistance) ? Constants<T>.MinusOne : Operations.Divide(farPlaneDistance, Operations.Subtract(nearPlaneDistance, farPlaneDistance));
            result.M33 = negFarRange;
            result.M34 = Constants<T>.MinusOne;

            result.M41 = result.M42 = result.M44 = Constants<T>.Zero;
            result.M43 = Operations.Multiply(nearPlaneDistance, negFarRange);

            return result;
        }

        /// <summary>Creates a customized, perspective projection matrix.</summary>
        /// <param name="left">Minimum x-value of the view volume at the near view plane.</param>
        /// <param name="right">Maximum x-value of the view volume at the near view plane.</param>
        /// <param name="bottom">Minimum y-value of the view volume at the near view plane.</param>
        /// <param name="top">Maximum y-value of the view volume at the near view plane.</param>
        /// <param name="nearPlaneDistance">Distance to the near view plane.</param>
        /// <param name="farPlaneDistance">Distance to of the far view plane.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static Matrix4x4<T> CreatePerspectiveOffCenter(T left, T right, T bottom, T top, T nearPlaneDistance, T farPlaneDistance)
        {
            if (!Operations.GreaterThan(nearPlaneDistance, Constants<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (!Operations.GreaterThan(farPlaneDistance, Constants<T>.Zero))
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            if (Operations.GreaterThanOrEqual(nearPlaneDistance, farPlaneDistance))
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            Matrix4x4<T> result;

            result.M11 = Operations.Divide(Operations.Multiply(Constants<T>.Two, nearPlaneDistance), Operations.Subtract(right, left));
            result.M12 = result.M13 = result.M14 = Constants<T>.Zero;

            result.M22 = Operations.Divide(Operations.Multiply(Constants<T>.Two, nearPlaneDistance), Operations.Subtract(top, bottom));
            result.M21 = result.M23 = result.M24 = Constants<T>.Zero;

            result.M31 = Operations.Divide(Operations.Add(left, right), Operations.Subtract(right, left));
            result.M32 = Operations.Divide(Operations.Add(top, bottom), Operations.Subtract(top, bottom));
            T negFarRange = Operations.IsPositiveInfinity(farPlaneDistance) ? Constants<T>.MinusOne : Operations.Divide(farPlaneDistance, Operations.Subtract(nearPlaneDistance, farPlaneDistance));
            result.M33 = negFarRange;
            result.M34 = Constants<T>.MinusOne;

            result.M43 = Operations.Multiply(nearPlaneDistance, negFarRange);
            result.M41 = result.M42 = result.M44 = Constants<T>.Zero;

            return result;
        }

        /// <summary>Creates a Matrix that reflects the coordinate system about a specified Plane.</summary>
        /// <param name="value">The Plane about which to create a reflection.</param>
        /// <returns>A new matrix expressing the reflection.</returns>
        public static Matrix4x4<T> CreateReflection(Plane<T> value)
        {
            value = Plane<T>.Normalize(value);

            T a = value.Normal.X;
            T b = value.Normal.Y;
            T c = value.Normal.Z;

            T fa = Operations.Multiply(Constants<T>.MinusTwo, a);
            T fb = Operations.Multiply(Constants<T>.MinusTwo, b);
            T fc = Operations.Multiply(Constants<T>.MinusTwo, c);

            Matrix4x4<T> result = Identity;

            result.M11 = Operations.Add(Operations.Multiply(fa, a), Constants<T>.One);
            result.M12 = Operations.Multiply(fb, a);
            result.M13 = Operations.Multiply(fc, a);

            result.M21 = Operations.Multiply(fa, b);
            result.M22 = Operations.Add(Operations.Multiply(fb, b), Constants<T>.One);
            result.M23 = Operations.Multiply(fc, b);

            result.M31 = Operations.Multiply(fa, c);
            result.M32 = Operations.Multiply(fb, c);
            result.M33 = Operations.Add(Operations.Multiply(fc, c), Constants<T>.One);

            result.M41 = Operations.Multiply(fa, value.D);
            result.M42 = Operations.Multiply(fb, value.D);
            result.M43 = Operations.Multiply(fc, value.D);

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the X-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the X-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4x4<T> CreateRotationX(T radians)
        {
            Matrix4x4<T> result = Identity;

            T c = Operations.Cos(radians);
            T s = Operations.Sin(radians);

            // [  1  0  0  0 ]
            // [  0  c  s  0 ]
            // [  0 -s  c  0 ]
            // [  0  0  0  1 ]

            result.M22 = c;
            result.M23 = s;
            result.M32 = Operations.Negate(s);
            result.M33 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the X-axis, from a center point.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the X-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4x4<T> CreateRotationX(T radians, Vector3<T> centerPoint)
        {
            Matrix4x4<T> result = Identity;

            T c = Operations.Cos(radians);
            T s = Operations.Sin(radians);

            T y = Operations.Add(Operations.Multiply(centerPoint.Y, Operations.Subtract(Constants<T>.One, c)), Operations.Multiply(centerPoint.Z, s));
            T z = Operations.Subtract(Operations.Multiply(centerPoint.Z, Operations.Subtract(Constants<T>.One, c)), Operations.Multiply(centerPoint.Y, s));

            // [  1  0  0  0 ]
            // [  0  c  s  0 ]
            // [  0 -s  c  0 ]
            // [  0  y  z  1 ]

            result.M22 = c;
            result.M23 = s;
            result.M32 = Operations.Negate(s);
            result.M33 = c;
            result.M42 = y;
            result.M43 = z;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Y-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Y-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4x4<T> CreateRotationY(T radians)
        {
            Matrix4x4<T> result = Identity;

            T c = Operations.Cos(radians);
            T s = Operations.Sin(radians);

            // [  c  0 -s  0 ]
            // [  0  1  0  0 ]
            // [  s  0  c  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M13 = Operations.Negate(s);
            result.M31 = s;
            result.M33 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Y-axis, from a center point.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Y-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4x4<T> CreateRotationY(T radians, Vector3<T> centerPoint)
        {
            Matrix4x4<T> result = Identity;

            T c = Operations.Cos(radians);
            T s = Operations.Sin(radians);

            T x = Operations.Subtract(Operations.Multiply(centerPoint.X, Operations.Subtract(Constants<T>.One,c)), Operations.Multiply(centerPoint.Z, s));
            T z = Operations.Add(Operations.Multiply(centerPoint.Z, Operations.Subtract(Constants<T>.One, c)), Operations.Multiply(centerPoint.X, s));

            // [  c  0 -s  0 ]
            // [  0  1  0  0 ]
            // [  s  0  c  0 ]
            // [  x  0  z  1 ]
            result.M11 = c;
            result.M13 = Operations.Negate(s);
            result.M31 = s;
            result.M33 = c;
            result.M41 = x;
            result.M43 = z;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Z-axis.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Z-axis.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4x4<T> CreateRotationZ(T radians)
        {
            Matrix4x4<T> result = Identity;

            T c = Operations.Cos(radians);
            T s = Operations.Sin(radians);

            // [  c  s  0  0 ]
            // [ -s  c  0  0 ]
            // [  0  0  1  0 ]
            // [  0  0  0  1 ]
            result.M11 = c;
            result.M12 = s;
            result.M21 = Operations.Negate(s);
            result.M22 = c;

            return result;
        }

        /// <summary>Creates a matrix for rotating points around the Z-axis, from a center point.</summary>
        /// <param name="radians">The amount, in radians, by which to rotate around the Z-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The rotation matrix.</returns>
        public static Matrix4x4<T> CreateRotationZ(T radians, Vector3<T> centerPoint)
        {
            Matrix4x4<T> result = Identity;

            T c = Operations.Cos(radians);
            T s = Operations.Sin(radians);

            T x = Operations.Add(Operations.Multiply(centerPoint.X, Operations.Subtract(Constants<T>.One, c)), Operations.Multiply(centerPoint.Y, s));
            T y = Operations.Subtract(Operations.Multiply(centerPoint.Y, Operations.Subtract(Constants<T>.One, c)), Operations.Multiply(centerPoint.X, s));

            // [  c  s  0  0 ]
            // [ -s  c  0  0 ]
            // [  0  0  1  0 ]
            // [  x  y  0  1 ]
            result.M11 = c;
            result.M12 = s;
            result.M21 = Operations.Negate(s);
            result.M22 = c;
            result.M41 = x;
            result.M42 = y;

            return result;
        }

        /// <summary>Creates a scaling matrix.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <param name="zScale">Value to scale by on the Z-axis.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4x4<T> CreateScale(T xScale, T yScale, T zScale)
        {
            Matrix4x4<T> result = Identity;
            result.M11 = xScale;
            result.M22 = yScale;
            result.M33 = zScale;
            return result;
        }

        /// <summary>Creates a scaling matrix with a center point.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <param name="zScale">Value to scale by on the Z-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4x4<T> CreateScale(T xScale, T yScale, T zScale, Vector3<T> centerPoint)
        {
            Matrix4x4<T> result = Identity;

            T tx = Operations.Multiply(centerPoint.X, Operations.Subtract(Constants<T>.One, xScale));
            T ty = Operations.Multiply(centerPoint.Y, Operations.Subtract(Constants<T>.One, yScale));
            T tz = Operations.Multiply(centerPoint.Z, Operations.Subtract(Constants<T>.One, zScale));

            result.M11 = xScale;
            result.M22 = yScale;
            result.M33 = zScale;
            result.M41 = tx;
            result.M42 = ty;
            result.M43 = tz;
            return result;
        }

        /// <summary>Creates a scaling matrix.</summary>
        /// <param name="scales">The vector containing the amount to scale by on each axis.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4x4<T> CreateScale(Vector3<T> scales)
        {
            Matrix4x4<T> result = Identity;
            result.M11 = scales.X;
            result.M22 = scales.Y;
            result.M33 = scales.Z;
            return result;
        }

        /// <summary>Creates a scaling matrix with a center point.</summary>
        /// <param name="scales">The vector containing the amount to scale by on each axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4x4<T> CreateScale(Vector3<T> scales, Vector3<T> centerPoint)
        {
            Matrix4x4<T> result = Identity;

            T tx = Operations.Multiply(centerPoint.X, Operations.Subtract(Constants<T>.One, scales.X));
            T ty = Operations.Multiply(centerPoint.Y, Operations.Subtract(Constants<T>.One, scales.Y));
            T tz = Operations.Multiply(centerPoint.Z, Operations.Subtract(Constants<T>.One, scales.Z));

            result.M11 = scales.X;
            result.M22 = scales.Y;
            result.M33 = scales.Z;
            result.M41 = tx;
            result.M42 = ty;
            result.M43 = tz;
            return result;
        }

        /// <summary>Creates a uniform scaling matrix that scales equally on each axis.</summary>
        /// <param name="scale">The uniform scaling factor.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4x4<T> CreateScale(T scale)
        {
            Matrix4x4<T> result = Identity;

            result.M11 = scale;
            result.M22 = scale;
            result.M33 = scale;

            return result;
        }

        /// <summary>Creates a uniform scaling matrix that scales equally on each axis with a center point.</summary>
        /// <param name="scale">The uniform scaling factor.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>The scaling matrix.</returns>
        public static Matrix4x4<T> CreateScale(T scale, Vector3<T> centerPoint)
        {
            Matrix4x4<T> result = Identity;

            T tx = Operations.Multiply(centerPoint.X, Operations.Subtract(Constants<T>.One, scale));
            T ty = Operations.Multiply(centerPoint.Y, Operations.Subtract(Constants<T>.One, scale));
            T tz = Operations.Multiply(centerPoint.Z, Operations.Subtract(Constants<T>.One, scale));

            result.M11 = scale;
            result.M22 = scale;
            result.M33 = scale;

            result.M41 = tx;
            result.M42 = ty;
            result.M43 = tz;

            return result;
        }
        
        /// <summary>Creates a Matrix that flattens geometry into a specified Plane as if casting a shadow from a specified light source.</summary>
        /// <param name="lightDirection">The direction from which the light that will cast the shadow is coming.</param>
        /// <param name="plane">The Plane onto which the new matrix should flatten geometry so as to cast a shadow.</param>
        /// <returns>A new Matrix that can be used to flatten geometry onto the specified plane from the specified direction.</returns>
        public static Matrix4x4<T> CreateShadow(Vector3<T> lightDirection, Plane<T> plane)
        {
            Plane<T> p = Plane<T>.Normalize(plane);

            T dot = Operations.Add(Operations.Add(Operations.Multiply(p.Normal.X, lightDirection.X),Operations.Multiply(p.Normal.Y, lightDirection.Y)), Operations.Multiply(p.Normal.Z, lightDirection.Z));
            T a = Operations.Negate(p.Normal.X);
            T b = Operations.Negate(p.Normal.Y);
            T c = Operations.Negate(p.Normal.Z);
            T d = Operations.Negate(p.D);

            Matrix4x4<T> result = Identity;

            result.M11 = Operations.Add(Operations.Multiply(a, lightDirection.X), dot);
            result.M21 = Operations.Multiply(b, lightDirection.X);
            result.M31 = Operations.Multiply(c, lightDirection.X);
            result.M41 = Operations.Multiply(d, lightDirection.X);

            result.M12 = Operations.Multiply(a, lightDirection.Y);
            result.M22 = Operations.Add(Operations.Multiply(b, lightDirection.Y), dot);
            result.M32 = Operations.Multiply(c, lightDirection.Y);
            result.M42 = Operations.Multiply(d, lightDirection.Y);

            result.M13 = Operations.Multiply(a, lightDirection.Z);
            result.M23 = Operations.Multiply(b, lightDirection.Z);
            result.M33 = Operations.Add(Operations.Multiply(c, lightDirection.Z), dot);
            result.M43 = Operations.Multiply(d, lightDirection.Z);

            result.M44 = dot;

            return result;
        }

        /// <summary>Creates a translation matrix.</summary>
        /// <param name="position">The amount to translate in each axis.</param>
        /// <returns>The translation matrix.</returns>
        public static Matrix4x4<T> CreateTranslation(Vector3<T> position)
        {
            Matrix4x4<T> result = Identity;
            result.M41 = position.X;
            result.M42 = position.Y;
            result.M43 = position.Z;
            return result;
        }

        /// <summary>Creates a translation matrix.</summary>
        /// <param name="xPosition">The amount to translate on the X-axis.</param>
        /// <param name="yPosition">The amount to translate on the Y-axis.</param>
        /// <param name="zPosition">The amount to translate on the Z-axis.</param>
        /// <returns>The translation matrix.</returns>
        public static Matrix4x4<T> CreateTranslation(T xPosition, T yPosition, T zPosition)
        {
            Matrix4x4<T> result = Identity;
            result.M41 = xPosition;
            result.M42 = yPosition;
            result.M43 = zPosition;
            return result;
        }

        /// <summary>Creates a world matrix with the specified parameters.</summary>
        /// <param name="position">The position of the object; used in translation operations.</param>
        /// <param name="forward">Forward direction of the object.</param>
        /// <param name="up">Upward direction of the object; usually [0, 1, 0].</param>
        /// <returns>The world matrix.</returns>
        public static Matrix4x4<T> CreateWorld(Vector3<T> position, Vector3<T> forward, Vector3<T> up)
        {
            Vector3<T> zaxis = Vector3<T>.Normalize(-forward);
            Vector3<T> xaxis = Vector3<T>.Normalize(Vector3<T>.Cross(up, zaxis));
            Vector3<T> yaxis = Vector3<T>.Cross(zaxis, xaxis);

            Matrix4x4<T> result = Identity;

            result.M11 = xaxis.X;
            result.M12 = xaxis.Y;
            result.M13 = xaxis.Z;

            result.M21 = yaxis.X;
            result.M22 = yaxis.Y;
            result.M23 = yaxis.Z;

            result.M31 = zaxis.X;
            result.M32 = zaxis.Y;
            result.M33 = zaxis.Z;

            result.M41 = position.X;
            result.M42 = position.Y;
            result.M43 = position.Z;

            return result;
        }

        /// <summary>Attempts to calculate the inverse of the given matrix. If successful, result will contain the inverted matrix.</summary>
        /// <param name="matrix">The source matrix to invert.</param>
        /// <param name="result">If successful, contains the inverted matrix.</param>
        /// <returns>True if the source matrix could be inverted; False otherwise.</returns>
        ///
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe bool Invert(Matrix4x4<T> matrix, out Matrix4x4<T> result)
        {
            // This implementation is based on the DirectX Math Library XMMatrixInverse method
            // https://github.com/microsoft/DirectXMath/blob/master/Inc/DirectXMathMatrix.inl

            /*if (Sse.IsSupported)
            {
                return SseImpl(matrix, out result);
            }*/

            return SoftwareFallback(matrix, out result);

            /*static unsafe bool SseImpl(Matrix4x4 matrix, out Matrix4x4 result)
            {
                if (!Sse.IsSupported)
                {
                    // Redundant test so we won't prejit remainder of this method on platforms without SSE.
                    throw new PlatformNotSupportedException();
                }

                // Load the matrix values into rows
                Vector128<T> row1 = Sse.LoadVector128(&matrix.M11);
                Vector128<T> row2 = Sse.LoadVector128(&matrix.M21);
                Vector128<T> row3 = Sse.LoadVector128(&matrix.M31);
                Vector128<T> row4 = Sse.LoadVector128(&matrix.M41);

                // Transpose the matrix
                Vector128<T> vTemp1 = Sse.Shuffle(row1, row2, 0x44); //_MM_SHUFFLE(1, 0, 1, 0)
                Vector128<T> vTemp3 = Sse.Shuffle(row1, row2, 0xEE); //_MM_SHUFFLE(3, 2, 3, 2)
                Vector128<T> vTemp2 = Sse.Shuffle(row3, row4, 0x44); //_MM_SHUFFLE(1, 0, 1, 0)
                Vector128<T> vTemp4 = Sse.Shuffle(row3, row4, 0xEE); //_MM_SHUFFLE(3, 2, 3, 2)

                row1 = Sse.Shuffle(vTemp1, vTemp2, 0x88); //_MM_SHUFFLE(2, 0, 2, 0)
                row2 = Sse.Shuffle(vTemp1, vTemp2, 0xDD); //_MM_SHUFFLE(3, 1, 3, 1)
                row3 = Sse.Shuffle(vTemp3, vTemp4, 0x88); //_MM_SHUFFLE(2, 0, 2, 0)
                row4 = Sse.Shuffle(vTemp3, vTemp4, 0xDD); //_MM_SHUFFLE(3, 1, 3, 1)

                Vector128<T> V00 = Permute(row3, 0x50);           //_MM_SHUFFLE(1, 1, 0, 0)
                Vector128<T> V10 = Permute(row4, 0xEE);           //_MM_SHUFFLE(3, 2, 3, 2)
                Vector128<T> V01 = Permute(row1, 0x50);           //_MM_SHUFFLE(1, 1, 0, 0)
                Vector128<T> V11 = Permute(row2, 0xEE);           //_MM_SHUFFLE(3, 2, 3, 2)
                Vector128<T> V02 = Sse.Shuffle(row3, row1, 0x88); //_MM_SHUFFLE(2, 0, 2, 0)
                Vector128<T> V12 = Sse.Shuffle(row4, row2, 0xDD); //_MM_SHUFFLE(3, 1, 3, 1)

                Vector128<T> D0 = Sse.Multiply(V00, V10);
                Vector128<T> D1 = Sse.Multiply(V01, V11);
                Vector128<T> D2 = Sse.Multiply(V02, V12);

                V00 = Permute(row3, 0xEE);           //_MM_SHUFFLE(3, 2, 3, 2)
                V10 = Permute(row4, 0x50);           //_MM_SHUFFLE(1, 1, 0, 0)
                V01 = Permute(row1, 0xEE);           //_MM_SHUFFLE(3, 2, 3, 2)
                V11 = Permute(row2, 0x50);           //_MM_SHUFFLE(1, 1, 0, 0)
                V02 = Sse.Shuffle(row3, row1, 0xDD); //_MM_SHUFFLE(3, 1, 3, 1)
                V12 = Sse.Shuffle(row4, row2, 0x88); //_MM_SHUFFLE(2, 0, 2, 0)

                // Note:  We use this expansion pattern instead of Fused Multiply Add
                // in order to support older hardware
                D0 = Sse.Subtract(D0, Sse.Multiply(V00, V10));
                D1 = Sse.Subtract(D1, Sse.Multiply(V01, V11));
                D2 = Sse.Subtract(D2, Sse.Multiply(V02, V12));

                // V11 = D0Y,D0W,D2Y,D2Y
                V11 = Sse.Shuffle(D0, D2, 0x5D);  //_MM_SHUFFLE(1, 1, 3, 1)
                V00 = Permute(row2, 0x49);        //_MM_SHUFFLE(1, 0, 2, 1)
                V10 = Sse.Shuffle(V11, D0, 0x32); //_MM_SHUFFLE(0, 3, 0, 2)
                V01 = Permute(row1, 0x12);        //_MM_SHUFFLE(0, 1, 0, 2)
                V11 = Sse.Shuffle(V11, D0, 0x99); //_MM_SHUFFLE(2, 1, 2, 1)

                // V13 = D1Y,D1W,D2W,D2W
                Vector128<T> V13 = Sse.Shuffle(D1, D2, 0xFD); //_MM_SHUFFLE(3, 3, 3, 1)
                V02 = Permute(row4, 0x49);                        //_MM_SHUFFLE(1, 0, 2, 1)
                V12 = Sse.Shuffle(V13, D1, 0x32);                 //_MM_SHUFFLE(0, 3, 0, 2)
                Vector128<T> V03 = Permute(row3, 0x12);       //_MM_SHUFFLE(0, 1, 0, 2)
                V13 = Sse.Shuffle(V13, D1, 0x99);                 //_MM_SHUFFLE(2, 1, 2, 1)

                Vector128<T> C0 = Sse.Multiply(V00, V10);
                Vector128<T> C2 = Sse.Multiply(V01, V11);
                Vector128<T> C4 = Sse.Multiply(V02, V12);
                Vector128<T> C6 = Sse.Multiply(V03, V13);

                // V11 = D0X,D0Y,D2X,D2X
                V11 = Sse.Shuffle(D0, D2, 0x4);    //_MM_SHUFFLE(0, 0, 1, 0)
                V00 = Permute(row2, 0x9e);         //_MM_SHUFFLE(2, 1, 3, 2)
                V10 = Sse.Shuffle(D0, V11, 0x93);  //_MM_SHUFFLE(2, 1, 0, 3)
                V01 = Permute(row1, 0x7b);         //_MM_SHUFFLE(1, 3, 2, 3)
                V11 = Sse.Shuffle(D0, V11, 0x26);  //_MM_SHUFFLE(0, 2, 1, 2)

                // V13 = D1X,D1Y,D2Z,D2Z
                V13 = Sse.Shuffle(D1, D2, 0xa4);   //_MM_SHUFFLE(2, 2, 1, 0)
                V02 = Permute(row4, 0x9e);         //_MM_SHUFFLE(2, 1, 3, 2)
                V12 = Sse.Shuffle(D1, V13, 0x93);  //_MM_SHUFFLE(2, 1, 0, 3)
                V03 = Permute(row3, 0x7b);         //_MM_SHUFFLE(1, 3, 2, 3)
                V13 = Sse.Shuffle(D1, V13, 0x26);  //_MM_SHUFFLE(0, 2, 1, 2)

                C0 = Sse.Subtract(C0, Sse.Multiply(V00, V10));
                C2 = Sse.Subtract(C2, Sse.Multiply(V01, V11));
                C4 = Sse.Subtract(C4, Sse.Multiply(V02, V12));
                C6 = Sse.Subtract(C6, Sse.Multiply(V03, V13));

                V00 = Permute(row2, 0x33); //_MM_SHUFFLE(0, 3, 0, 3)

                // V10 = D0Z,D0Z,D2X,D2Y
                V10 = Sse.Shuffle(D0, D2, 0x4A); //_MM_SHUFFLE(1, 0, 2, 2)
                V10 = Permute(V10, 0x2C);        //_MM_SHUFFLE(0, 2, 3, 0)
                V01 = Permute(row1, 0x8D);       //_MM_SHUFFLE(2, 0, 3, 1)

                // V11 = D0X,D0W,D2X,D2Y
                V11 = Sse.Shuffle(D0, D2, 0x4C); //_MM_SHUFFLE(1, 0, 3, 0)
                V11 = Permute(V11, 0x93);        //_MM_SHUFFLE(2, 1, 0, 3)
                V02 = Permute(row4, 0x33);       //_MM_SHUFFLE(0, 3, 0, 3)

                // V12 = D1Z,D1Z,D2Z,D2W
                V12 = Sse.Shuffle(D1, D2, 0xEA); //_MM_SHUFFLE(3, 2, 2, 2)
                V12 = Permute(V12, 0x2C);        //_MM_SHUFFLE(0, 2, 3, 0)
                V03 = Permute(row3, 0x8D);       //_MM_SHUFFLE(2, 0, 3, 1)

                // V13 = D1X,D1W,D2Z,D2W
                V13 = Sse.Shuffle(D1, D2, 0xEC); //_MM_SHUFFLE(3, 2, 3, 0)
                V13 = Permute(V13, 0x93);        //_MM_SHUFFLE(2, 1, 0, 3)

                V00 = Sse.Multiply(V00, V10);
                V01 = Sse.Multiply(V01, V11);
                V02 = Sse.Multiply(V02, V12);
                V03 = Sse.Multiply(V03, V13);

                Vector128<T> C1 = Sse.Subtract(C0, V00);
                C0 = Sse.Add(C0, V00);
                Vector128<T> C3 = Sse.Add(C2, V01);
                C2 = Sse.Subtract(C2, V01);
                Vector128<T> C5 = Sse.Subtract(C4, V02);
                C4 = Sse.Add(C4, V02);
                Vector128<T> C7 = Sse.Add(C6, V03);
                C6 = Sse.Subtract(C6, V03);

                C0 = Sse.Shuffle(C0, C1, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C2 = Sse.Shuffle(C2, C3, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C4 = Sse.Shuffle(C4, C5, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C6 = Sse.Shuffle(C6, C7, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)

                C0 = Permute(C0, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C2 = Permute(C2, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C4 = Permute(C4, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)
                C6 = Permute(C6, 0xD8); //_MM_SHUFFLE(3, 1, 2, 0)

                // Get the determinant
                vTemp2 = row1;
                T det = Vector4.Dot(C0.AsVector4(), vTemp2.AsVector4());

                // Check determinate is not zero
                if (MathF.Abs(det) < T.Epsilon)
                {
                    result = new Matrix4x4(T.NaN, T.NaN, T.NaN, T.NaN,
                                T.NaN, T.NaN, T.NaN, T.NaN,
                                T.NaN, T.NaN, T.NaN, T.NaN,
                                T.NaN, T.NaN, T.NaN, T.NaN);
                    return false;
                }

                // Create Vector128<T> copy of the determinant and invert them.
                Vector128<T> ones = Vector128.Create(1.0f);
                Vector128<T> vTemp = Vector128.Create(det);
                vTemp = Sse.Divide(ones, vTemp);

                row1 = Sse.Multiply(C0, vTemp);
                row2 = Sse.Multiply(C2, vTemp);
                row3 = Sse.Multiply(C4, vTemp);
                row4 = Sse.Multiply(C6, vTemp);

                Unsafe.SkipInit(out result);
                ref Vector128<T> vResult = ref Unsafe.As<Matrix4x4, Vector128<T>>(ref result);

                vResult = row1;
                Unsafe.Add(ref vResult, 1) = row2;
                Unsafe.Add(ref vResult, 2) = row3;
                Unsafe.Add(ref vResult, 3) = row4;

                return true;
            }*/

            static bool SoftwareFallback(Matrix4x4<T> matrix, out Matrix4x4<T> result)
            {
                //                                       -1
                // If you have matrix M, inverse Matrix M   can compute
                //
                //     -1       1
                //    M   = --------- A
                //            det(M)
                //
                // A is adjugate (adjoint) of M, where,
                //
                //      T
                // A = C
                //
                // C is Cofactor matrix of M, where,
                //           i + j
                // C   = (-1)      * det(M  )
                //  ij                    ij
                //
                //     [ a b c d ]
                // M = [ e f g h ]
                //     [ i j k l ]
                //     [ m n o p ]
                //
                // First Row
                //           2 | f g h |
                // C   = (-1)  | j k l | = + ( f ( kp - lo ) - g ( jp - ln ) + h ( jo - kn ) )
                //  11         | n o p |
                //
                //           3 | e g h |
                // C   = (-1)  | i k l | = - ( e ( kp - lo ) - g ( ip - lm ) + h ( io - km ) )
                //  12         | m o p |
                //
                //           4 | e f h |
                // C   = (-1)  | i j l | = + ( e ( jp - ln ) - f ( ip - lm ) + h ( in - jm ) )
                //  13         | m n p |
                //
                //           5 | e f g |
                // C   = (-1)  | i j k | = - ( e ( jo - kn ) - f ( io - km ) + g ( in - jm ) )
                //  14         | m n o |
                //
                // Second Row
                //           3 | b c d |
                // C   = (-1)  | j k l | = - ( b ( kp - lo ) - c ( jp - ln ) + d ( jo - kn ) )
                //  21         | n o p |
                //
                //           4 | a c d |
                // C   = (-1)  | i k l | = + ( a ( kp - lo ) - c ( ip - lm ) + d ( io - km ) )
                //  22         | m o p |
                //
                //           5 | a b d |
                // C   = (-1)  | i j l | = - ( a ( jp - ln ) - b ( ip - lm ) + d ( in - jm ) )
                //  23         | m n p |
                //
                //           6 | a b c |
                // C   = (-1)  | i j k | = + ( a ( jo - kn ) - b ( io - km ) + c ( in - jm ) )
                //  24         | m n o |
                //
                // Third Row
                //           4 | b c d |
                // C   = (-1)  | f g h | = + ( b ( gp - ho ) - c ( fp - hn ) + d ( fo - gn ) )
                //  31         | n o p |
                //
                //           5 | a c d |
                // C   = (-1)  | e g h | = - ( a ( gp - ho ) - c ( ep - hm ) + d ( eo - gm ) )
                //  32         | m o p |
                //
                //           6 | a b d |
                // C   = (-1)  | e f h | = + ( a ( fp - hn ) - b ( ep - hm ) + d ( en - fm ) )
                //  33         | m n p |
                //
                //           7 | a b c |
                // C   = (-1)  | e f g | = - ( a ( fo - gn ) - b ( eo - gm ) + c ( en - fm ) )
                //  34         | m n o |
                //
                // Fourth Row
                //           5 | b c d |
                // C   = (-1)  | f g h | = - ( b ( gl - hk ) - c ( fl - hj ) + d ( fk - gj ) )
                //  41         | j k l |
                //
                //           6 | a c d |
                // C   = (-1)  | e g h | = + ( a ( gl - hk ) - c ( el - hi ) + d ( ek - gi ) )
                //  42         | i k l |
                //
                //           7 | a b d |
                // C   = (-1)  | e f h | = - ( a ( fl - hj ) - b ( el - hi ) + d ( ej - fi ) )
                //  43         | i j l |
                //
                //           8 | a b c |
                // C   = (-1)  | e f g | = + ( a ( fk - gj ) - b ( ek - gi ) + c ( ej - fi ) )
                //  44         | i j k |
                //
                // Cost of operation
                // 53 adds, 104 muls, and 1 div.
                T a = matrix.M11, b = matrix.M12, c = matrix.M13, d = matrix.M14;
                T e = matrix.M21, f = matrix.M22, g = matrix.M23, h = matrix.M24;
                T i = matrix.M31, j = matrix.M32, k = matrix.M33, l = matrix.M34;
                T m = matrix.M41, n = matrix.M42, o = matrix.M43, p = matrix.M44;

                T kp_lo = Operations.Subtract(Operations.Multiply(k, p), Operations.Multiply(l, o));
                T jp_ln = Operations.Subtract(Operations.Multiply(j, p), Operations.Multiply(l, n));
                T jo_kn = Operations.Subtract(Operations.Multiply(j, o), Operations.Multiply(k, n));
                T ip_lm = Operations.Subtract(Operations.Multiply(i, p), Operations.Multiply(l, m));
                T io_km = Operations.Subtract(Operations.Multiply(i, o), Operations.Multiply(k, m));
                T in_jm = Operations.Subtract(Operations.Multiply(i, n), Operations.Multiply(j, m));

                T a11 =                     Operations.Add(Operations.Subtract(Operations.Multiply(f, kp_lo), Operations.Multiply(g, jp_ln)), Operations.Multiply(h, jo_kn));
                T a12 = Operations.Negate(Operations.Add(Operations.Subtract(Operations.Multiply(e, kp_lo), Operations.Multiply(g, ip_lm)), Operations.Multiply(h, io_km)));
                T a13 =                     Operations.Add(Operations.Subtract(Operations.Multiply(e, jp_ln), Operations.Multiply(f, ip_lm)), Operations.Multiply(h, in_jm));
                T a14 = Operations.Negate(Operations.Add(Operations.Subtract(Operations.Multiply(e, jo_kn) , Operations.Multiply(f, io_km)), Operations.Multiply(g, in_jm)));

                T det = Operations.Add(Operations.Add(Operations.Add(Operations.Multiply(a, a11), Operations.Multiply(b, a12)), Operations.Multiply(c, a13)), Operations.Multiply(d, a14));

                if (!Operations.GreaterThanOrEqual(Operations.Abs(det), Constants<T>.Epsilon))
                {
                    result = new Matrix4x4<T>(Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN,
                                           Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN,
                                           Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN,
                                           Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN);
                    return false;
                }

                T invDet = Operations.Divide(Constants<T>.One, det);

                result.M11 = Operations.Multiply(a11, invDet);
                result.M21 = Operations.Multiply(a12, invDet);
                result.M31 = Operations.Multiply(a13, invDet);
                result.M41 = Operations.Multiply(a14, invDet);

                result.M12 = Operations.Negate(Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(b, kp_lo), Operations.Multiply(c, jp_ln)), Operations.Multiply(d, jo_kn)), invDet));
                result.M22 =                     Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(a, kp_lo), Operations.Multiply(c, ip_lm)), Operations.Multiply(d, io_km)), invDet);
                result.M32 = Operations.Negate(Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(a, jp_ln), Operations.Multiply(b, ip_lm)), Operations.Multiply(d, in_jm)), invDet));
                result.M42 =                     Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(a, jo_kn), Operations.Multiply(b, io_km)), Operations.Multiply(c, in_jm)), invDet);

                T gp_ho = Operations.Subtract(Operations.Multiply(g, p), Operations.Multiply(h, o));
                T fp_hn = Operations.Subtract(Operations.Multiply(f, p), Operations.Multiply(h, n));
                T fo_gn = Operations.Subtract(Operations.Multiply(f, o), Operations.Multiply(g, n));
                T ep_hm = Operations.Subtract(Operations.Multiply(e, p), Operations.Multiply(h, m));
                T eo_gm = Operations.Subtract(Operations.Multiply(e, o), Operations.Multiply(g, m));
                T en_fm = Operations.Subtract(Operations.Multiply(e, n), Operations.Multiply(f, m));
                
                result.M13 =                     Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(b,gp_ho), Operations.Multiply(c,fp_hn)), Operations.Multiply(d, fo_gn)),  invDet);
                result.M23 = Operations.Negate(Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(a,gp_ho), Operations.Multiply(c,ep_hm)), Operations.Multiply(d, eo_gm)), invDet));
                result.M33 =                     Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(a,fp_hn), Operations.Multiply(b,ep_hm)), Operations.Multiply(d, en_fm)), invDet);
                result.M43 = Operations.Negate(Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(a,fo_gn), Operations.Multiply(b,eo_gm)), Operations.Multiply(c, en_fm)), invDet));

                T gl_hk = Operations.Subtract(Operations.Multiply(g, l), Operations.Multiply(h, k));
                T fl_hj = Operations.Subtract(Operations.Multiply(f, l), Operations.Multiply(h, j));;
                T fk_gj = Operations.Subtract(Operations.Multiply(f, k), Operations.Multiply(g, j));;
                T el_hi = Operations.Subtract(Operations.Multiply(e, l), Operations.Multiply(h, i));;
                T ek_gi = Operations.Subtract(Operations.Multiply(e, k), Operations.Multiply(g, i));;
                T ej_fi = Operations.Subtract(Operations.Multiply(e, j), Operations.Multiply(f, i));;

                result.M14 = Operations.Negate(Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(b, gl_hk), Operations.Multiply(c, fl_hj)), Operations.Multiply(d, fk_gj)), invDet));
                result.M24 =                     Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(a, gl_hk), Operations.Multiply(c, el_hi)), Operations.Multiply(d, ek_gi)), invDet);
                result.M34 = Operations.Negate(Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(a, fl_hj), Operations.Multiply(b, el_hi)), Operations.Multiply(d, ej_fi)), invDet));
                result.M44 =                     Operations.Multiply(Operations.Add(Operations.Subtract(Operations.Multiply(a, fk_gj), Operations.Multiply(b, ek_gi)), Operations.Multiply(c, ej_fi)), invDet);

                return true;
            }
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4<T> Multiply(Matrix4x4<T> value1, Matrix4x4<T> value2)
            => value1 * value2;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4<T> Multiply(Matrix4x4<T> value1, T value2)
            => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4<T> Negate(Matrix4x4<T> value)
            => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4<T> Subtract(Matrix4x4<T> value1, Matrix4x4<T> value2)
            => value1 - value2;

        /*[MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Vector128<T> Permute(Vector128<T> value, byte control)
        {
            if (Avx.IsSupported)
            {
                return Avx.Permute(value, control);
            }
            else if (Sse.IsSupported)
            {
                return Sse.Shuffle(value, value, control);
            }
            else
            {
                // Redundant test so we won't prejit remainder of this method on platforms without AdvSimd.
                throw new PlatformNotSupportedException();
            }
        }*/

        /// <summary>Attempts to extract the scale, translation, and rotation components from the given scale/rotation/translation matrix.
        /// If successful, the out parameters will contained the extracted values.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="scale">The scaling component of the transformation matrix.</param>
        /// <param name="rotation">The rotation component of the transformation matrix.</param>
        /// <param name="translation">The translation component of the transformation matrix</param>
        /// <returns>True if the source matrix was successfully decomposed; False otherwise.</returns>
        public static bool Decompose(Matrix4x4<T> matrix, out Vector3<T> scale, out Quaternion<T> rotation, out Vector3<T> translation)
        {
            bool result = true;

            unsafe
            {
                fixed (Vector3<T>* scaleBase = &scale)
                {
                    T* pfScales = (T*)scaleBase;
                    T det;

                    VectorBasis vectorBasis;
                    Vector3<T>** pVectorBasis = (Vector3<T>**)&vectorBasis;

                    Matrix4x4<T> matTemp = Identity;
                    CanonicalBasis canonicalBasis = default;
                    Vector3<T>* pCanonicalBasis = &canonicalBasis.Row0;

                    canonicalBasis.Row0 = new Vector3<T>(Constants<T>.One, Constants<T>.Zero, Constants<T>.Zero);
                    canonicalBasis.Row1 = new Vector3<T>(Constants<T>.Zero, Constants<T>.One, Constants<T>.Zero);
                    canonicalBasis.Row2 = new Vector3<T>(Constants<T>.Zero, Constants<T>.Zero, Constants<T>.One);

                    translation = new Vector3<T>(
                        matrix.M41,
                        matrix.M42,
                        matrix.M43);

                    pVectorBasis[0] = (Vector3<T>*)&matTemp.M11;
                    pVectorBasis[1] = (Vector3<T>*)&matTemp.M21;
                    pVectorBasis[2] = (Vector3<T>*)&matTemp.M31;

                    *(pVectorBasis[0]) = new Vector3<T>(matrix.M11, matrix.M12, matrix.M13);
                    *(pVectorBasis[1]) = new Vector3<T>(matrix.M21, matrix.M22, matrix.M23);
                    *(pVectorBasis[2]) = new Vector3<T>(matrix.M31, matrix.M32, matrix.M33);

                    scale.X = pVectorBasis[0]->Length();
                    scale.Y = pVectorBasis[1]->Length();
                    scale.Z = pVectorBasis[2]->Length();

                    uint a, b, c;
                    #region Ranking
                    T x = pfScales[0], y = pfScales[1], z = pfScales[2];
                    if (!Operations.GreaterThanOrEqual(x, y))
                    {
                        if (!Operations.GreaterThanOrEqual(y, z))
                        {
                            a = 2;
                            b = 1;
                            c = 0;
                        }
                        else
                        {
                            a = 1;

                            if (!Operations.GreaterThanOrEqual(x, z))
                            {
                                b = 2;
                                c = 0;
                            }
                            else
                            {
                                b = 0;
                                c = 2;
                            }
                        }
                    }
                    else
                    {
                        if (!Operations.GreaterThanOrEqual(x, z))
                        {
                            a = 2;
                            b = 0;
                            c = 1;
                        }
                        else
                        {
                            a = 0;

                            if (!Operations.GreaterThanOrEqual(y, z))
                            {
                                b = 2;
                                c = 1;
                            }
                            else
                            {
                                b = 1;
                                c = 2;
                            }
                        }
                    }
                    #endregion

                    if (!Operations.GreaterThanOrEqual(pfScales[a], Operations.As<float, T>(DecomposeEpsilon)))
                    {
                        *(pVectorBasis[a]) = pCanonicalBasis[a];
                    }

                    *pVectorBasis[a] = Vector3<T>.Normalize(*pVectorBasis[a]);

                    if (!Operations.GreaterThanOrEqual(pfScales[b], Operations.As<float, T>(DecomposeEpsilon)))
                    {
                        uint cc;
                        T fAbsX, fAbsY, fAbsZ;

                        fAbsX = Operations.Abs(pVectorBasis[a]->X);
                        fAbsY = Operations.Abs(pVectorBasis[a]->Y);
                        fAbsZ = Operations.Abs(pVectorBasis[a]->Z);

                        #region Ranking
                        if (!Operations.GreaterThanOrEqual(fAbsX, fAbsY))
                        {
                            if (!Operations.GreaterThanOrEqual(fAbsY, fAbsZ))
                            {
                                cc = 0;
                            }
                            else
                            {
                                if (!Operations.GreaterThanOrEqual(fAbsX, fAbsZ))
                                {
                                    cc = 0;
                                }
                                else
                                {
                                    cc = 2;
                                }
                            }
                        }
                        else
                        {
                            if (!Operations.GreaterThanOrEqual(fAbsX, fAbsZ))
                            {
                                cc = 1;
                            }
                            else
                            {
                                if (!Operations.GreaterThanOrEqual(fAbsY, fAbsZ))
                                {
                                    cc = 1;
                                }
                                else
                                {
                                    cc = 2;
                                }
                            }
                        }
                        #endregion

                        *pVectorBasis[b] = Vector3<T>.Cross(*pVectorBasis[a], *(pCanonicalBasis + cc));
                    }

                    *pVectorBasis[b] = Vector3<T>.Normalize(*pVectorBasis[b]);

                    if (!Operations.GreaterThanOrEqual(pfScales[c], Operations.As<float, T>(DecomposeEpsilon)))
                    {
                        *pVectorBasis[c] = Vector3<T>.Cross(*pVectorBasis[a], *pVectorBasis[b]);
                    }

                    *pVectorBasis[c] = Vector3<T>.Normalize(*pVectorBasis[c]);

                    det = matTemp.GetDeterminant();

                    // use Kramer's rule to check for handedness of coordinate system
                    if (!Operations.GreaterThanOrEqual(det, Constants<T>.Zero))
                    {
                        // switch coordinate system by negating the scale and inverting the basis vector on the x-axis
                        pfScales[a] = Operations.Negate(pfScales[a]);
                        *pVectorBasis[a] = -(*pVectorBasis[a]);

                        det = Operations.Negate(det);
                    }

                    det = Operations.Subtract(det, Constants<T>.One);
                    det = Operations.Multiply(det, det);

                    if (!Operations.GreaterThanOrEqual(Operations.As<float, T>(DecomposeEpsilon), det))
                    {
                        // Non-SRT matrix encountered
                        rotation = Quaternion<T>.Identity;
                        result = false;
                    }
                    else
                    {
                        // generate the quaternion from the matrix
                        rotation = Quaternion<T>.CreateFromRotationMatrix(matTemp);
                    }
                }
            }

            return result;
        }

        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix4x4<T> Lerp(Matrix4x4<T> matrix1, Matrix4x4<T> matrix2, T amount)
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

            Matrix4x4<T> result;

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

            // Fourth row
            result.M41 = Operations.Add(matrix1.M41, Operations.Multiply(Operations.Subtract(matrix2.M41, matrix1.M41), amount));
            result.M42 = Operations.Add(matrix1.M42, Operations.Multiply(Operations.Subtract(matrix2.M42, matrix1.M42), amount));
            result.M43 = Operations.Add(matrix1.M43, Operations.Multiply(Operations.Subtract(matrix2.M43, matrix1.M43), amount));
            result.M44 = Operations.Add(matrix1.M44, Operations.Multiply(Operations.Subtract(matrix2.M44, matrix1.M44), amount));

            return result;
        }

        /// <summary>Transforms the given matrix by applying the given Quaternion rotation.</summary>
        /// <param name="value">The source matrix to transform.</param>
        /// <param name="rotation">The rotation to apply.</param>
        /// <returns>The transformed matrix.</returns>
        public static Matrix4x4<T> Transform(Matrix4x4<T> value, Quaternion<T> rotation)
        {
            // Compute rotation matrix.
            T x2 = Operations.Add(rotation.X, rotation.X);
            T y2 = Operations.Add(rotation.Y, rotation.Y);
            T z2 = Operations.Add(rotation.Z, rotation.Z);

            T wx2 = Operations.Multiply(rotation.W, x2);
            T wy2 = Operations.Multiply(rotation.W, y2);
            T wz2 = Operations.Multiply(rotation.W, z2);
            T xx2 = Operations.Multiply(rotation.X, x2);
            T xy2 = Operations.Multiply(rotation.X, y2);
            T xz2 = Operations.Multiply(rotation.X, z2);
            T yy2 = Operations.Multiply(rotation.Y, y2);
            T yz2 = Operations.Multiply(rotation.Y, z2);
            T zz2 = Operations.Multiply(rotation.Z, z2);

            T q11 = Operations.Subtract(Operations.Subtract(Constants<T>.One, yy2), zz2);
            T q21 = Operations.Subtract(xy2, wz2);
            T q31 = Operations.Add(xz2, wy2);

            T q12 = Operations.Add(xy2, wz2);
            T q22 = Operations.Subtract(Operations.Subtract(Constants<T>.One, xx2), zz2);
            T q32 = Operations.Subtract(yz2, wx2);

            T q13 = Operations.Subtract(xz2, wy2);
            T q23 = Operations.Add(yz2, wx2);
            T q33 = Operations.Subtract(Operations.Subtract(Constants<T>.One, xx2), yy2);

            Matrix4x4<T> result;

            // First row
            result.M11 = Operations.Add(Operations.Add(Operations.Multiply(value.M11, q11), Operations.Multiply(value.M12, q21)), Operations.Multiply(value.M13, q31));
            result.M12 = Operations.Add(Operations.Add(Operations.Multiply(value.M11, q12), Operations.Multiply(value.M12, q22)), Operations.Multiply(value.M13, q32));
            result.M13 = Operations.Add(Operations.Add(Operations.Multiply(value.M11, q13), Operations.Multiply(value.M12, q23)), Operations.Multiply(value.M13, q33));
            result.M14 = value.M14;

            // Second row
            result.M21 = Operations.Add(Operations.Add(Operations.Multiply(value.M21, q11), Operations.Multiply(value.M22, q21)), Operations.Multiply(value.M23, q31));
            result.M22 = Operations.Add(Operations.Add(Operations.Multiply(value.M21, q12), Operations.Multiply(value.M22, q22)), Operations.Multiply(value.M23, q32));
            result.M23 = Operations.Add(Operations.Add(Operations.Multiply(value.M21, q13), Operations.Multiply(value.M22, q23)), Operations.Multiply(value.M23, q33));
            result.M24 = value.M24;

            // Third row
            result.M31 = Operations.Add(Operations.Add(Operations.Multiply(value.M31, q11), Operations.Multiply(value.M32, q21)), Operations.Multiply(value.M33, q31));
            result.M32 = Operations.Add(Operations.Add(Operations.Multiply(value.M31, q12), Operations.Multiply(value.M32, q22)), Operations.Multiply(value.M33, q32));
            result.M33 = Operations.Add(Operations.Add(Operations.Multiply(value.M31, q13), Operations.Multiply(value.M32, q23)), Operations.Multiply(value.M33, q33));
            result.M34 = value.M34;

            // Fourth row
            result.M41 = Operations.Add(Operations.Add(Operations.Multiply(value.M41, q11), Operations.Multiply(value.M42, q21)), Operations.Multiply(value.M43, q31));
            result.M42 = Operations.Add(Operations.Add(Operations.Multiply(value.M41, q12), Operations.Multiply(value.M42, q22)), Operations.Multiply(value.M43, q32));
            result.M43 = Operations.Add(Operations.Add(Operations.Multiply(value.M41, q13), Operations.Multiply(value.M42, q23)), Operations.Multiply(value.M43, q33));
            result.M44 = value.M44;

            return result;
        }

        /// <summary>Transposes the rows and columns of a matrix.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <returns>The transposed matrix.</returns>
        public static unsafe Matrix4x4<T> Transpose(Matrix4x4<T> matrix)
        {
            /*if (AdvSimd.Arm64.IsSupported)
            {
                // This implementation is based on the DirectX Math Library XMMatrixTranspose method
                // https://github.com/microsoft/DirectXMath/blob/master/Inc/DirectXMathMatrix.inl

                Vector128<T> M11 = AdvSimd.LoadVector128(&matrix.M11);
                Vector128<T> M31 = AdvSimd.LoadVector128(&matrix.M31);

                Vector128<T> P00 = AdvSimd.Arm64.ZipLow(M11, M31);
                Vector128<T> P01 = AdvSimd.Arm64.ZipHigh(M11, M31);

                Vector128<T> M21 = AdvSimd.LoadVector128(&matrix.M21);
                Vector128<T> M41 = AdvSimd.LoadVector128(&matrix.M41);

                Vector128<T> P10 = AdvSimd.Arm64.ZipLow(M21, M41);
                Vector128<T> P11 = AdvSimd.Arm64.ZipHigh(M21, M41);

                AdvSimd.Store(&matrix.M11, AdvSimd.Arm64.ZipLow(P00, P10));
                AdvSimd.Store(&matrix.M21, AdvSimd.Arm64.ZipHigh(P00, P10));
                AdvSimd.Store(&matrix.M31, AdvSimd.Arm64.ZipLow(P01, P11));
                AdvSimd.Store(&matrix.M41, AdvSimd.Arm64.ZipHigh(P01, P11));

                return matrix;
            }
            else if (Sse.IsSupported)
            {
                Vector128<T> row1 = Sse.LoadVector128(&matrix.M11);
                Vector128<T> row2 = Sse.LoadVector128(&matrix.M21);
                Vector128<T> row3 = Sse.LoadVector128(&matrix.M31);
                Vector128<T> row4 = Sse.LoadVector128(&matrix.M41);

                Vector128<T> l12 = Sse.UnpackLow(row1, row2);
                Vector128<T> l34 = Sse.UnpackLow(row3, row4);
                Vector128<T> h12 = Sse.UnpackHigh(row1, row2);
                Vector128<T> h34 = Sse.UnpackHigh(row3, row4);

                Sse.Store(&matrix.M11, Sse.MoveLowToHigh(l12, l34));
                Sse.Store(&matrix.M21, Sse.MoveHighToLow(l34, l12));
                Sse.Store(&matrix.M31, Sse.MoveLowToHigh(h12, h34));
                Sse.Store(&matrix.M41, Sse.MoveHighToLow(h34, h12));

                return matrix;
            }*/

            Matrix4x4<T> result;

            result.M11 = matrix.M11;
            result.M12 = matrix.M21;
            result.M13 = matrix.M31;
            result.M14 = matrix.M41;
            result.M21 = matrix.M12;
            result.M22 = matrix.M22;
            result.M23 = matrix.M32;
            result.M24 = matrix.M42;
            result.M31 = matrix.M13;
            result.M32 = matrix.M23;
            result.M33 = matrix.M33;
            result.M34 = matrix.M43;
            result.M41 = matrix.M14;
            result.M42 = matrix.M24;
            result.M43 = matrix.M34;
            result.M44 = matrix.M44;

            return result;
        }

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix4x4<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether this matrix instance is equal to the other given matrix.</summary>
        /// <param name="other">The matrix to compare this instance to.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public readonly bool Equals(Matrix4x4<T> other)
            => this == other;

        /// <summary>Calculates the determinant of the matrix.</summary>
        /// <returns>The determinant of the matrix.</returns>
        public readonly T GetDeterminant()
        {
            // | a b c d |     | f g h |     | e g h |     | e f h |     | e f g |
            // | e f g h | = a | j k l | - b | i k l | + c | i j l | - d | i j k |
            // | i j k l |     | n o p |     | m o p |     | m n p |     | m n o |
            // | m n o p |
            //
            //   | f g h |
            // a | j k l | = a ( f ( kp - lo ) - g ( jp - ln ) + h ( jo - kn ) )
            //   | n o p |
            //
            //   | e g h |
            // b | i k l | = b ( e ( kp - lo ) - g ( ip - lm ) + h ( io - km ) )
            //   | m o p |
            //
            //   | e f h |
            // c | i j l | = c ( e ( jp - ln ) - f ( ip - lm ) + h ( in - jm ) )
            //   | m n p |
            //
            //   | e f g |
            // d | i j k | = d ( e ( jo - kn ) - f ( io - km ) + g ( in - jm ) )
            //   | m n o |
            //
            // Cost of operation
            // 17 adds and 28 muls.
            //
            // add: 6 + 8 + 3 = 17
            // mul: 12 + 16 = 28

            T a = M11, b = M12, c = M13, d = M14;
            T e = M21, f = M22, g = M23, h = M24;
            T i = M31, j = M32, k = M33, l = M34;
            T m = M41, n = M42, o = M43, p = M44;

            T kp_lo = Operations.Subtract(Operations.Multiply(k, p), Operations.Multiply(l, o));
            T jp_ln = Operations.Subtract(Operations.Multiply(j, p), Operations.Multiply(l, n));
            T jo_kn = Operations.Subtract(Operations.Multiply(j, o), Operations.Multiply(k, n));
            T ip_lm = Operations.Subtract(Operations.Multiply(i, p), Operations.Multiply(l, m));
            T io_km = Operations.Subtract(Operations.Multiply(i, o), Operations.Multiply(k, m));
            T in_jm = Operations.Subtract(Operations.Multiply(i, n), Operations.Multiply(j, m));

            return Operations.Add(
                Operations.Subtract(
                    Operations.Multiply(a,
                        Operations.Add(
                            Operations.Subtract(Operations.Multiply(f, kp_lo), Operations.Multiply(g, jp_ln)),
                            Operations.Multiply(h, jo_kn))),
                    Operations.Multiply(b,
                        Operations.Add(
                            Operations.Subtract(Operations.Multiply(e, kp_lo), Operations.Multiply(g, ip_lm)),
                            Operations.Multiply(h, io_km)))),
                Operations.Subtract(
                    Operations.Multiply(c,
                        Operations.Add(
                            Operations.Subtract(Operations.Multiply(e, jp_ln), Operations.Multiply(f, ip_lm)),
                            Operations.Multiply(h, in_jm))),
                    Operations.Multiply(d,
                        Operations.Add(
                            Operations.Subtract(Operations.Multiply(e, jo_kn), Operations.Multiply(f, io_km)),
                            Operations.Multiply(g, in_jm)))));
        }

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

            hash.Add(M41);
            hash.Add(M42);
            hash.Add(M43);
            hash.Add(M44);

            return hash.ToHashCode();
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1} M13:{2} M14:{3}}} {{M21:{4} M22:{5} M23:{6} M24:{7}}} {{M31:{8} M32:{9} M33:{10} M34:{11}}} {{M41:{12} M42:{13} M43:{14} M44:{15}}} }}",
                                 M11, M12, M13, M14,
                                 M21, M22, M23, M24,
                                 M31, M32, M33, M34,
                                 M41, M42, M43, M44);
        }
        
        private struct CanonicalBasis
        {
            public Vector3<T> Row0;
            public Vector3<T> Row1;
            public Vector3<T> Row2;
        };

        private struct VectorBasis
        {
            public unsafe Vector3<T>* Element0;
            public unsafe Vector3<T>* Element1;
            public unsafe Vector3<T>* Element2;
        }
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix4x4<Half>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, Half>(from.M11),Operations.As<T, Half>(from.M12),
                Operations.As<T, Half>(from.M13),Operations.As<T, Half>(from.M14),
                Operations.As<T, Half>(from.M21),Operations.As<T, Half>(from.M22),
                Operations.As<T, Half>(from.M23),Operations.As<T, Half>(from.M24),
                Operations.As<T, Half>(from.M31),Operations.As<T, Half>(from.M32),
                Operations.As<T, Half>(from.M33),Operations.As<T, Half>(from.M34),
                Operations.As<T, Half>(from.M41),Operations.As<T, Half>(from.M42),
                Operations.As<T, Half>(from.M43),Operations.As<T, Half>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix4x4<float>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, float>(from.M11),Operations.As<T, float>(from.M12),
                Operations.As<T, float>(from.M13),Operations.As<T, float>(from.M14),
                Operations.As<T, float>(from.M21),Operations.As<T, float>(from.M22),
                Operations.As<T, float>(from.M23),Operations.As<T, float>(from.M24),
                Operations.As<T, float>(from.M31),Operations.As<T, float>(from.M32),
                Operations.As<T, float>(from.M33),Operations.As<T, float>(from.M34),
                Operations.As<T, float>(from.M41),Operations.As<T, float>(from.M42),
                Operations.As<T, float>(from.M43),Operations.As<T, float>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix4x4<double>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, double>(from.M11),Operations.As<T, double>(from.M12),
                Operations.As<T, double>(from.M13),Operations.As<T, double>(from.M14),
                Operations.As<T, double>(from.M21),Operations.As<T, double>(from.M22),
                Operations.As<T, double>(from.M23),Operations.As<T, double>(from.M24),
                Operations.As<T, double>(from.M31),Operations.As<T, double>(from.M32),
                Operations.As<T, double>(from.M33),Operations.As<T, double>(from.M34),
                Operations.As<T, double>(from.M41),Operations.As<T, double>(from.M42),
                Operations.As<T, double>(from.M43),Operations.As<T, double>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix4x4<decimal>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, decimal>(from.M11),Operations.As<T, decimal>(from.M12),
                Operations.As<T, decimal>(from.M13),Operations.As<T, decimal>(from.M14),
                Operations.As<T, decimal>(from.M21),Operations.As<T, decimal>(from.M22),
                Operations.As<T, decimal>(from.M23),Operations.As<T, decimal>(from.M24),
                Operations.As<T, decimal>(from.M31),Operations.As<T, decimal>(from.M32),
                Operations.As<T, decimal>(from.M33),Operations.As<T, decimal>(from.M34),
                Operations.As<T, decimal>(from.M41),Operations.As<T, decimal>(from.M42),
                Operations.As<T, decimal>(from.M43),Operations.As<T, decimal>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix4x4<sbyte>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, sbyte>(from.M11),Operations.As<T, sbyte>(from.M12),
                Operations.As<T, sbyte>(from.M13),Operations.As<T, sbyte>(from.M14),
                Operations.As<T, sbyte>(from.M21),Operations.As<T, sbyte>(from.M22),
                Operations.As<T, sbyte>(from.M23),Operations.As<T, sbyte>(from.M24),
                Operations.As<T, sbyte>(from.M31),Operations.As<T, sbyte>(from.M32),
                Operations.As<T, sbyte>(from.M33),Operations.As<T, sbyte>(from.M34),
                Operations.As<T, sbyte>(from.M41),Operations.As<T, sbyte>(from.M42),
                Operations.As<T, sbyte>(from.M43),Operations.As<T, sbyte>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix4x4<byte>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, byte>(from.M11),Operations.As<T, byte>(from.M12),
                Operations.As<T, byte>(from.M13),Operations.As<T, byte>(from.M14),
                Operations.As<T, byte>(from.M21),Operations.As<T, byte>(from.M22),
                Operations.As<T, byte>(from.M23),Operations.As<T, byte>(from.M24),
                Operations.As<T, byte>(from.M31),Operations.As<T, byte>(from.M32),
                Operations.As<T, byte>(from.M33),Operations.As<T, byte>(from.M34),
                Operations.As<T, byte>(from.M41),Operations.As<T, byte>(from.M42),
                Operations.As<T, byte>(from.M43),Operations.As<T, byte>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix4x4<ushort>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, ushort>(from.M11),Operations.As<T, ushort>(from.M12),
                Operations.As<T, ushort>(from.M13),Operations.As<T, ushort>(from.M14),
                Operations.As<T, ushort>(from.M21),Operations.As<T, ushort>(from.M22),
                Operations.As<T, ushort>(from.M23),Operations.As<T, ushort>(from.M24),
                Operations.As<T, ushort>(from.M31),Operations.As<T, ushort>(from.M32),
                Operations.As<T, ushort>(from.M33),Operations.As<T, ushort>(from.M34),
                Operations.As<T, ushort>(from.M41),Operations.As<T, ushort>(from.M42),
                Operations.As<T, ushort>(from.M43),Operations.As<T, ushort>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix4x4<short>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, short>(from.M11),Operations.As<T, short>(from.M12),
                Operations.As<T, short>(from.M13),Operations.As<T, short>(from.M14),
                Operations.As<T, short>(from.M21),Operations.As<T, short>(from.M22),
                Operations.As<T, short>(from.M23),Operations.As<T, short>(from.M24),
                Operations.As<T, short>(from.M31),Operations.As<T, short>(from.M32),
                Operations.As<T, short>(from.M33),Operations.As<T, short>(from.M34),
                Operations.As<T, short>(from.M41),Operations.As<T, short>(from.M42),
                Operations.As<T, short>(from.M43),Operations.As<T, short>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix4x4<uint>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, uint>(from.M11),Operations.As<T, uint>(from.M12),
                Operations.As<T, uint>(from.M13),Operations.As<T, uint>(from.M14),
                Operations.As<T, uint>(from.M21),Operations.As<T, uint>(from.M22),
                Operations.As<T, uint>(from.M23),Operations.As<T, uint>(from.M24),
                Operations.As<T, uint>(from.M31),Operations.As<T, uint>(from.M32),
                Operations.As<T, uint>(from.M33),Operations.As<T, uint>(from.M34),
                Operations.As<T, uint>(from.M41),Operations.As<T, uint>(from.M42),
                Operations.As<T, uint>(from.M43),Operations.As<T, uint>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix4x4<int>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, int>(from.M11),Operations.As<T, int>(from.M12),
                Operations.As<T, int>(from.M13),Operations.As<T, int>(from.M14),
                Operations.As<T, int>(from.M21),Operations.As<T, int>(from.M22),
                Operations.As<T, int>(from.M23),Operations.As<T, int>(from.M24),
                Operations.As<T, int>(from.M31),Operations.As<T, int>(from.M32),
                Operations.As<T, int>(from.M33),Operations.As<T, int>(from.M34),
                Operations.As<T, int>(from.M41),Operations.As<T, int>(from.M42),
                Operations.As<T, int>(from.M43),Operations.As<T, int>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix4x4<ulong>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, ulong>(from.M11),Operations.As<T, ulong>(from.M12),
                Operations.As<T, ulong>(from.M13),Operations.As<T, ulong>(from.M14),
                Operations.As<T, ulong>(from.M21),Operations.As<T, ulong>(from.M22),
                Operations.As<T, ulong>(from.M23),Operations.As<T, ulong>(from.M24),
                Operations.As<T, ulong>(from.M31),Operations.As<T, ulong>(from.M32),
                Operations.As<T, ulong>(from.M33),Operations.As<T, ulong>(from.M34),
                Operations.As<T, ulong>(from.M41),Operations.As<T, ulong>(from.M42),
                Operations.As<T, ulong>(from.M43),Operations.As<T, ulong>(from.M44)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix4x4{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix4x4<long>(Matrix4x4<T> from)
            => new
            (
                Operations.As<T, long>(from.M11),Operations.As<T, long>(from.M12),
                Operations.As<T, long>(from.M13),Operations.As<T, long>(from.M14),
                Operations.As<T, long>(from.M21),Operations.As<T, long>(from.M22),
                Operations.As<T, long>(from.M23),Operations.As<T, long>(from.M24),
                Operations.As<T, long>(from.M31),Operations.As<T, long>(from.M32),
                Operations.As<T, long>(from.M33),Operations.As<T, long>(from.M34),
                Operations.As<T, long>(from.M41),Operations.As<T, long>(from.M42),
                Operations.As<T, long>(from.M43),Operations.As<T, long>(from.M44)
            );
    }
}
