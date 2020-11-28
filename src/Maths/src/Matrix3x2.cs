using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Silk.NET.Numerics
{
    /// <summary>A structure encapsulating a 3x2 matrix.</summary>
    public struct Matrix3x2<T>
        : IEquatable<Matrix3x2<T>>
        where T : unmanaged, IFormattable, IComparable<T>, IEquatable<T>
    {
        private const float RotationEpsilon = 0.001f * MathF.PI / 180f;     // 0.1% of a degree

        private static readonly Matrix3x2<T> _identity = new(
            Constants<T>.One, Constants<T>.Zero,
            Constants<T>.Zero, Constants<T>.One,
            Constants<T>.Zero, Constants<T>.Zero
        );

        /// <summary>The first element of the first row</summary>
        public T M11;

        /// <summary>The second element of the first row</summary>
        public T M12;

        /// <summary>The first element of the second row</summary>
        public T M21;

        /// <summary>The second element of the second row</summary>
        public T M22;

        /// <summary>The first element of the third row</summary>
        public T M31;

        /// <summary>The second element of the third row</summary>
        public T M32;

        /// <summary>Constructs a Matrix3x2 from the given components.</summary>
        public Matrix3x2(T m11, T m12,
            T m21, T m22,
            T m31, T m32)
        {
            M11 = m11;
            M12 = m12;

            M21 = m21;
            M22 = m22;

            M31 = m31;
            M32 = m32;
        }
        
        /// <summary>Constructs a Matrix3x2 from the given Matrix4x3.</summary>
        /// <param name="value">The source Matrix4x3.</param>
        public Matrix3x2(Matrix4x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;

            M21 = value.M21;
            M22 = value.M22;

            M31 = value.M31;
            M32 = value.M32;
        }
        
        /// <summary>Constructs a Matrix3x2 from the given Matrix3x4.</summary>
        /// <param name="value">The source Matrix3x4.</param>
        public Matrix3x2(Matrix3x4<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;

            M21 = value.M21;
            M22 = value.M22;

            M31 = value.M31;
            M32 = value.M32;
        }
        
        /// <summary>Constructs a Matrix3x2 from the given Matrix3x3.</summary>
        /// <param name="value">The source Matrix3x3.</param>
        public Matrix3x2(Matrix3x3<T> value)
        {
            M11 = value.M11;
            M12 = value.M12;

            M21 = value.M21;
            M22 = value.M22;

            M31 = value.M31;
            M32 = value.M32;
        }

        /// <summary>Returns the multiplicative identity matrix.</summary>
        public static Matrix3x2<T> Identity => _identity;

        /// <summary>Returns whether the matrix is the identity matrix.</summary>
        public readonly bool IsIdentity => this == Identity;

        /// <summary>Gets or sets the translation component of this matrix.</summary>
        public Vector2<T> Translation
        {
            readonly get => new(M31, M32);

            set
            {
                M31 = value.X;
                M32 = value.Y;
            }
        }

        /// <summary>Adds each matrix element in value1 with its corresponding element in value2.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The matrix containing the summed values.</returns>
        public static Matrix3x2<T> operator +(Matrix3x2<T> value1, Matrix3x2<T> value2)
        {
            Matrix3x2<T> m;

            m.M11 = Operations.Add(value1.M11, value2.M11);
            m.M12 = Operations.Add(value1.M12, value2.M12);

            m.M21 = Operations.Add(value1.M21, value2.M21);
            m.M22 = Operations.Add(value1.M22, value2.M22);

            m.M31 = Operations.Add(value1.M31, value2.M31);
            m.M32 = Operations.Add(value1.M32, value2.M32);

            return m;
        }

        /// <summary>Returns a boolean indicating whether the given matrices are equal.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>True if the matrices are equal; False otherwise.</returns>
        public static bool operator ==(Matrix3x2<T> value1, Matrix3x2<T> value2)
        {
            // Check diagonal element first for early out.
            return (Operations.Equal(value1.M11, value2.M11)
                 && Operations.Equal(value1.M22, value2.M22)
                 && Operations.Equal(value1.M12, value2.M12)
                 && Operations.Equal(value1.M21, value2.M21)
                 && Operations.Equal(value1.M31, value2.M31)
                 && Operations.Equal(value1.M32, value2.M32));
        }

        /// <summary>Returns a boolean indicating whether the given matrices are not equal.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>True if the matrices are not equal; False if they are equal.</returns>
        public static bool operator !=(Matrix3x2<T> value1, Matrix3x2<T> value2)
            => !(value1 == value2);

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3x3<T> operator *(Matrix3x2<T> value1, Matrix2x3<T> value2)
        {
            Matrix3x3<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21));
            m.M12 = Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22));
            m.M13 = Operations.Add(Operations.Multiply(value1.M11, value2.M13), Operations.Multiply(value1.M12, value2.M23));

            // Second row
            m.M21 = Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21));
            m.M22 = Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22));
            m.M23 = Operations.Add(Operations.Multiply(value1.M21, value2.M13), Operations.Multiply(value1.M22, value2.M23));

            // Third row
            m.M31 = Operations.Add(Operations.Multiply(value1.M31, value2.M11), Operations.Multiply(value1.M32, value2.M21));
            m.M32 = Operations.Add(Operations.Multiply(value1.M31, value2.M12), Operations.Multiply(value1.M32, value2.M22));
            m.M33 = Operations.Add(Operations.Multiply(value1.M31, value2.M13), Operations.Multiply(value1.M32, value2.M23));

            return m;
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3x2<T> operator *(Matrix3x2<T> value1, Matrix2x2<T> value2)
        {
            Matrix3x2<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21));
            m.M12 = Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22));

            // Second row
            m.M21 = Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21));
            m.M22 = Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22));

            // Third row
            m.M31 = Operations.Add(Operations.Multiply(value1.M31, value2.M11), Operations.Multiply(value1.M32, value2.M21));
            m.M32 = Operations.Add(Operations.Multiply(value1.M31, value2.M12), Operations.Multiply(value1.M32, value2.M22));

            return m;
        }
        
        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        public static unsafe Matrix3x2<T> operator *(Matrix3x3<T> value1, Matrix3x2<T> value2)
        {
            Matrix3x2<T> m;

            // First row
            m.M11 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M11), Operations.Multiply(value1.M12, value2.M21)), Operations.Multiply(value1.M13, value2.M31));
            m.M12 = Operations.Add(Operations.Add(Operations.Multiply(value1.M11, value2.M12), Operations.Multiply(value1.M12, value2.M22)), Operations.Multiply(value1.M13, value2.M32));

            // Second row
            m.M21 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M11), Operations.Multiply(value1.M22, value2.M21)), Operations.Multiply(value1.M23, value2.M31));
            m.M22 = Operations.Add(Operations.Add(Operations.Multiply(value1.M21, value2.M12), Operations.Multiply(value1.M22, value2.M22)), Operations.Multiply(value1.M23, value2.M32));

            // Third row
            m.M31 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M11), Operations.Multiply(value1.M32, value2.M21)), Operations.Multiply(value1.M33, value2.M31));
            m.M32 = Operations.Add(Operations.Add(Operations.Multiply(value1.M31, value2.M12), Operations.Multiply(value1.M32, value2.M22)), Operations.Multiply(value1.M33, value2.M32));

            return m;
        }

        /// <summary>Scales all elements in a matrix by the given scalar factor.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling value to use.</param>
        /// <returns>The resulting matrix.</returns>
        public static Matrix3x2<T> operator *(Matrix3x2<T> value1, T value2)
        {
            Matrix3x2<T> m;

            m.M11 = Operations.Multiply(value1.M11, value2);
            m.M12 = Operations.Multiply(value1.M12, value2);

            m.M21 = Operations.Multiply(value1.M21, value2);
            m.M22 = Operations.Multiply(value1.M22, value2);

            m.M31 = Operations.Multiply(value1.M31, value2);
            m.M32 = Operations.Multiply(value1.M32, value2);

            return m;
        }

        /// <summary>Subtracts each matrix element in value2 from its corresponding element in value1.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The matrix containing the resulting values.</returns>
        public static Matrix3x2<T> operator -(Matrix3x2<T> value1, Matrix3x2<T> value2)
        {
            Matrix3x2<T> m;

            m.M11 = Operations.Subtract(value1.M11, value2.M11);
            m.M12 = Operations.Subtract(value1.M12, value2.M12);

            m.M21 = Operations.Subtract(value1.M21, value2.M21);
            m.M22 = Operations.Subtract(value1.M22, value2.M22);

            m.M31 = Operations.Subtract(value1.M31, value2.M31);
            m.M32 = Operations.Subtract(value1.M32, value2.M32);

            return m;
        }

        /// <summary>Negates the given matrix by multiplying all values by -1.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        public static Matrix3x2<T> operator -(Matrix3x2<T> value)
        {
            Matrix3x2<T> m;

            m.M11 = Operations.Negate(value.M11);
            m.M12 = Operations.Negate(value.M12);

            m.M21 = Operations.Negate(value.M21);
            m.M22 = Operations.Negate(value.M22);

            m.M31 = Operations.Negate(value.M31);
            m.M32 = Operations.Negate(value.M32);

            return m;
        }

        /// <summary>Adds each matrix element in value1 with its corresponding element in value2.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The matrix containing the summed values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x2<T> Add(Matrix3x2<T> value1, Matrix3x2<T> value2)
            => value1 + value2;

        /// <summary>Creates a rotation matrix using the given rotation in radians.</summary>
        /// <param name="radians">The amount of rotation, in radians.</param>
        /// <returns>A rotation matrix.</returns>
        public static Matrix3x2<T> CreateRotation(T radians)
        {
            radians = Operations.IEEERemainder(radians, Constants<T>.Tau);

            T c, s;

            if (Operations.GreaterThan(radians, Operations.As<float, T>(-RotationEpsilon)) && !Operations.GreaterThanOrEqual(radians, Operations.As<float, T>(RotationEpsilon)))
            {
                // Exact case for zero rotation.
                c = Constants<T>.One;
                s = Constants<T>.Zero;
            }
            else if (Operations.GreaterThan(radians, Operations.As<float, T>(MathF.PI / 2 - RotationEpsilon)) && !Operations.GreaterThanOrEqual(radians, Operations.As<float, T>(MathF.PI / 2 + RotationEpsilon)))
            {
                // Exact case for 90 degree rotation.
                c = Constants<T>.Zero;
                s = Constants<T>.One;
            }
            else if (!Operations.GreaterThanOrEqual(radians, Operations.As<float, T>(-MathF.PI + RotationEpsilon)) || Operations.GreaterThan(radians, Operations.As<float, T>(MathF.PI - RotationEpsilon)))
            {
                // Exact case for 180 degree rotation.
                c = Constants<T>.MinusOne;
                s = Constants<T>.Zero;
            }
            else if (Operations.GreaterThan(radians, Operations.As<float, T>(-MathF.PI / 2 - RotationEpsilon)) && !Operations.GreaterThanOrEqual(radians, Operations.As<float, T>(-MathF.PI / 2 + RotationEpsilon)))
            {
                // Exact case for 270 degree rotation.
                c = Constants<T>.Zero;
                s = Constants<T>.MinusOne;
            }
            else
            {
                // Arbitrary rotation.
                c = Operations.Cos(radians);
                s = Operations.Sin(radians);
            }

            // [  c  s ]
            // [ -s  c ]
            // [  0  0 ]
            Matrix3x2<T> result = Identity;

            result.M11 = c;
            result.M12 = s;
            result.M21 = Operations.Negate(s);
            result.M22 = c;

            return result;
        }

        /// <summary>Creates a rotation matrix using the given rotation in radians and a center point.</summary>
        /// <param name="radians">The amount of rotation, in radians.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>A rotation matrix.</returns>
        public static Matrix3x2<T> CreateRotation(T radians, Vector2<T> centerPoint)
        {
            Matrix3x2<T> result;

            radians = Operations.IEEERemainder(radians, Operations.As<float, T>(MathF.PI * 2));

            T c, s;

            if (Operations.GreaterThan(radians, Operations.As<float, T>(-RotationEpsilon)) && !Operations.GreaterThanOrEqual(radians, Operations.As<float, T>(RotationEpsilon)))
            {
                // Exact case for zero rotation.
                c = Constants<T>.One;
                s = Constants<T>.Zero;
            }
            else if (Operations.GreaterThan(radians, Operations.As<float, T>(MathF.PI / 2 - RotationEpsilon)) && !Operations.GreaterThanOrEqual(radians, Operations.As<float, T>(MathF.PI / 2 + RotationEpsilon)))
            {
                // Exact case for 90 degree rotation.
                c = Constants<T>.Zero;
                s = Constants<T>.One;
            }
            else if (!Operations.GreaterThanOrEqual(radians, Operations.As<float, T>(-MathF.PI + RotationEpsilon)) || Operations.GreaterThan(radians, Operations.As<float, T>(MathF.PI - RotationEpsilon)))
            {
                // Exact case for 180 degree rotation.
                c = Constants<T>.MinusOne;
                s = Constants<T>.Zero;
            }
            else if (Operations.GreaterThan(radians, Operations.As<float, T>(-MathF.PI / 2 - RotationEpsilon)) && !Operations.GreaterThanOrEqual(radians, Operations.As<float, T>(-MathF.PI / 2 + RotationEpsilon)))
            {
                // Exact case for 270 degree rotation.
                c = Constants<T>.Zero;
                s = Constants<T>.MinusOne;
            }
            else
            {
                // Arbitrary rotation.
                c = Operations.Cos(radians);
                s = Operations.Sin(radians);
            }

            T x = Operations.Add(Operations.Multiply(centerPoint.X, Operations.Subtract(Constants<T>.One, c)), Operations.Multiply(centerPoint.Y, s));
            T y = Operations.Subtract(Operations.Multiply(centerPoint.Y, Operations.Subtract(Constants<T>.One, c)), Operations.Multiply(centerPoint.X, s));

            // [  c  s ]
            // [ -s  c ]
            // [  x  y ]
            result.M11 = c;
            result.M12 = s;
            result.M21 = Operations.Negate(s);
            result.M22 = c;
            result.M31 = x;
            result.M32 = y;

            return result;
        }

        /// <summary>Creates a scale matrix from the given vector scale.</summary>
        /// <param name="scales">The scale to use.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3x2<T> CreateScale(Vector2<T> scales)
        {
            Matrix3x2<T> result = Identity;

            result.M11 = scales.X;
            result.M22 = scales.Y;

            return result;
        }

        /// <summary>Creates a scale matrix from the given X and Y components.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3x2<T> CreateScale(T xScale, T yScale)
        {
            Matrix3x2<T> result = Identity;

            result.M11 = xScale;
            result.M22 = yScale;

            return result;
        }

        /// <summary>Creates a scale matrix that is offset by a given center point.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3x2<T> CreateScale(T xScale, T yScale, Vector2<T> centerPoint)
        {
            Matrix3x2<T> result = Identity;

            T tx = Operations.Multiply(centerPoint.X, Operations.Subtract(Constants<T>.One, xScale));
            T ty = Operations.Multiply(centerPoint.Y, Operations.Subtract(Constants<T>.One, yScale));

            result.M11 = xScale;
            result.M22 = yScale;
            result.M31 = tx;
            result.M32 = ty;

            return result;
        }

        /// <summary>Creates a scale matrix from the given vector scale with an offset from the given center point.</summary>
        /// <param name="scales">The scale to use.</param>
        /// <param name="centerPoint">The center offset.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3x2<T> CreateScale(Vector2<T> scales, Vector2<T> centerPoint)
        {
            Matrix3x2<T> result = Identity;

            T tx = Operations.Multiply(centerPoint.X, Operations.Subtract(Constants<T>.One, scales.X));
            T ty = Operations.Multiply(centerPoint.Y, Operations.Subtract(Constants<T>.One, scales.Y));

            result.M11 = scales.X;
            result.M22 = scales.Y;
            result.M31 = tx;
            result.M32 = ty;

            return result;
        }

        /// <summary>Creates a scale matrix that scales uniformly with the given scale.</summary>
        /// <param name="scale">The uniform scale to use.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3x2<T> CreateScale(T scale)
        {
            Matrix3x2<T> result = Identity;

            result.M11 = scale;
            result.M22 = scale;

            return result;
        }

        /// <summary>Creates a scale matrix that scales uniformly with the given scale with an offset from the given center.</summary>
        /// <param name="scale">The uniform scale to use.</param>
        /// <param name="centerPoint">The center offset.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3x2<T> CreateScale(T scale, Vector2<T> centerPoint)
        {
            Matrix3x2<T> result = Identity;

            T tx = Operations.Multiply(centerPoint.X, Operations.Subtract(Constants<T>.One, scale));
            T ty = Operations.Multiply(centerPoint.Y, Operations.Subtract(Constants<T>.One, scale));

            result.M11 = scale;
            result.M22 = scale;
            result.M31 = tx;
            result.M32 = ty;

            return result;
        }

        /// <summary>Creates a skew matrix from the given angles in radians.</summary>
        /// <param name="radiansX">The X angle, in radians.</param>
        /// <param name="radiansY">The Y angle, in radians.</param>
        /// <returns>A skew matrix.</returns>
        public static Matrix3x2<T> CreateSkew(T radiansX, T radiansY)
        {
            Matrix3x2<T> result = Identity;

            T xTan = Operations.Tan(radiansX);
            T yTan = Operations.Tan(radiansY);

            result.M12 = yTan;
            result.M21 = xTan;

            return result;
        }

        /// <summary>Creates a skew matrix from the given angles in radians and a center point.</summary>
        /// <param name="radiansX">The X angle, in radians.</param>
        /// <param name="radiansY">The Y angle, in radians.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>A skew matrix.</returns>
        public static Matrix3x2<T> CreateSkew(T radiansX, T radiansY, Vector2<T> centerPoint)
        {
            Matrix3x2<T> result = Identity;

            T xTan = Operations.Tan(radiansX);
            T yTan = Operations.Tan(radiansY);

            T tx = Operations.Negate(Operations.Multiply(centerPoint.Y, xTan));
            T ty = Operations.Negate(Operations.Multiply(centerPoint.X, yTan));

            result.M12 = yTan;
            result.M21 = xTan;

            result.M31 = tx;
            result.M32 = ty;

            return result;
        }

        /// <summary>Creates a translation matrix from the given vector.</summary>
        /// <param name="position">The translation position.</param>                        `
        /// <returns>A translation matrix.</returns>
        public static Matrix3x2<T> CreateTranslation(Vector2<T> position)
        {
            Matrix3x2<T> result = Identity;

            result.M31 = position.X;
            result.M32 = position.Y;

            return result;
        }

        /// <summary>Creates a translation matrix from the given X and Y components.</summary>
        /// <param name="xPosition">The X position.</param>
        /// <param name="yPosition">The Y position.</param>
        /// <returns>A translation matrix.</returns>
        public static Matrix3x2<T> CreateTranslation(T xPosition, T yPosition)
        {
            Matrix3x2<T> result = Identity;

            result.M31 = xPosition;
            result.M32 = yPosition;

            return result;
        }

        /// <summary>Attempts to invert the given matrix. If the operation succeeds, the inverted matrix is stored in the result parameter.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="result">The output matrix.</param>
        /// <returns>True if the operation succeeded, False otherwise.</returns>
        public static bool Invert(Matrix3x2<T> matrix, out Matrix3x2<T> result)
        {
            T det = Operations.Subtract(Operations.Multiply(matrix.M11, matrix.M22), Operations.Multiply(matrix.M21, matrix.M12));

            if (!Operations.GreaterThanOrEqual(Operations.Abs(det), Constants<T>.Epsilon))
            {
                result = new(Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN, Constants<T>.NaN);
                return false;
            }

            T invDet = Operations.Divide(Constants<T>.One, det);

            result.M11 = Operations.Multiply(matrix.M22, invDet);
            result.M12 = Operations.Negate(Operations.Multiply(matrix.M12, invDet));

            result.M21 = Operations.Negate(Operations.Multiply(matrix.M21, invDet));
            result.M22 = Operations.Multiply(matrix.M11, invDet);

            result.M31 = Operations.Multiply(Operations.Subtract(Operations.Multiply(matrix.M21, matrix.M32), Operations.Multiply(matrix.M31, matrix.M22)), invDet);
            result.M32 = Operations.Multiply(Operations.Subtract(Operations.Multiply(matrix.M31, matrix.M12), Operations.Multiply(matrix.M11, matrix.M32)), invDet);

            return true;
        }

        /// <summary>Linearly interpolates from matrix1 to matrix2, based on the third parameter.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weighting of matrix2.</param>
        /// <returns>The interpolated matrix.</returns>
        public static Matrix3x2<T> Lerp(Matrix3x2<T> matrix1, Matrix3x2<T> matrix2, T amount)
        {
            Matrix3x2<T> result;

            // First row
            result.M11 = Operations.Add(matrix1.M11, Operations.Multiply(Operations.Subtract(matrix2.M11, matrix1.M11), amount));
            result.M12 = Operations.Add(matrix1.M12, Operations.Multiply(Operations.Subtract(matrix2.M12, matrix1.M12), amount));

            // Second row
            result.M21 = Operations.Add(matrix1.M21, Operations.Multiply(Operations.Subtract(matrix2.M21, matrix1.M21), amount));
            result.M22 = Operations.Add(matrix1.M22, Operations.Multiply(Operations.Subtract(matrix2.M22, matrix1.M22), amount));

            // Third row
            result.M31 = Operations.Add(matrix1.M31, Operations.Multiply(Operations.Subtract(matrix2.M31, matrix1.M31), amount));
            result.M32 = Operations.Add(matrix1.M32, Operations.Multiply(Operations.Subtract(matrix2.M32, matrix1.M32), amount));

            return result;
        }

        /// <summary>Multiplies two matrices together and returns the resulting matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The product matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x2<T> Multiply(Matrix3x2<T> value1, Matrix2x2<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies two matrices together and returns the resulting matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The product matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3<T> Multiply(Matrix3x2<T> value1, Matrix2x3<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies two matrices together and returns the resulting matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The product matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2<T> Multiply(Matrix2x3<T> value1, Matrix3x2<T> value2)
            => value1 * value2;
        
        /// <summary>Multiplies two matrices together and returns the resulting matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The product matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x3<T> Multiply(Matrix2x3<T> value1, Matrix3x3<T> value2)
            => value1 * value2;

        /// <summary>Scales all elements in a matrix by the given scalar factor.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling value to use.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x2<T> Multiply(Matrix3x2<T> value1, T value2)
            => value1 * value2;

        /// <summary>Negates the given matrix by multiplying all values by -1.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x2<T> Negate(Matrix3x2<T> value)
            => -value;

        /// <summary>Subtracts each matrix element in value2 from its corresponding element in value1.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The matrix containing the resulting values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x2<T> Subtract(Matrix3x2<T> value1, Matrix3x2<T> value2)
            => value1 - value2;

        /// <summary>Returns a boolean indicating whether the given Object is equal to this matrix instance.</summary>
        /// <param name="obj">The Object to compare against.</param>
        /// <returns>True if the Object is equal to this matrix; False otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly bool Equals(object? obj)
            => (obj is Matrix3x2<T> other) && Equals(other);

        /// <summary>Returns a boolean indicating whether the matrix is equal to the other given matrix.</summary>
        /// <param name="other">The other matrix to test equality against.</param>
        /// <returns>True if this matrix is equal to other; False otherwise.</returns>
        public readonly bool Equals(Matrix3x2<T> other)
        {
            return this == other;
        }

        /// <summary>Calculates the determinant for this matrix.
        /// The determinant is calculated by expanding the matrix with a third column whose values are (0,0,1).</summary>
        /// <returns>The determinant.</returns>
        public readonly T GetDeterminant()
        {
            // There isn't actually any such thing as a determinant for a non-square matrix,
            // but this 3x2 type is really just an optimization of a 3x3 where we happen to
            // know the rightmost column is always (0, 0, 1). So we expand to 3x3 format:
            //
            //  [ M11, M12, 0 ]
            //  [ M21, M22, 0 ]
            //  [ M31, M32, 1 ]
            //
            // Sum the diagonal products:
            //  (M11 * M22 * 1) + (M12 * 0 * M31) + (0 * M21 * M32)
            //
            // Subtract the opposite diagonal products:
            //  (M31 * M22 * 0) + (M32 * 0 * M11) + (1 * M21 * M12)
            //
            // Collapse out the constants and oh look, this is just a 2x2 determinant!

            return Operations.Subtract(Operations.Multiply(M11, M22), Operations.Multiply(M21, M12));
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code.</returns>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(M11, M12, M21, M22, M31, M32);
        }

        /// <summary>Returns a String representing this matrix instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{{ {{M11:{0} M12:{1}}} {{M21:{2} M22:{3}}} {{M31:{4} M32:{5}}} }}",
                                 M11, M12,
                                 M21, M22,
                                 M31, M32);
        }

        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="Half"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="Half"/> matrix</returns>
        public static explicit operator Matrix3x2<Half>(Matrix3x2<T> from)
            => new(
                Operations.As<T, Half>(from.M11), Operations.As<T, Half>(from.M12),
                Operations.As<T, Half>(from.M21), Operations.As<T, Half>(from.M22),
                Operations.As<T, Half>(from.M31), Operations.As<T, Half>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="float"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="float"/> matrix</returns>
        public static explicit operator Matrix3x2<float>(Matrix3x2<T> from)
            => new(
                Operations.As<T, float>(from.M11), Operations.As<T, float>(from.M12),
                Operations.As<T, float>(from.M21), Operations.As<T, float>(from.M22),
                Operations.As<T, float>(from.M31), Operations.As<T, float>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="double"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="double"/> matrix</returns>
        public static explicit operator Matrix3x2<double>(Matrix3x2<T> from)
            => new(
                Operations.As<T, double>(from.M11), Operations.As<T, double>(from.M12),
                Operations.As<T, double>(from.M21), Operations.As<T, double>(from.M22),
                Operations.As<T, double>(from.M31), Operations.As<T, double>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="decimal"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="decimal"/> matrix</returns>
        public static explicit operator Matrix3x2<decimal>(Matrix3x2<T> from)
            => new(
                Operations.As<T, decimal>(from.M11), Operations.As<T, decimal>(from.M12),
                Operations.As<T, decimal>(from.M21), Operations.As<T, decimal>(from.M22),
                Operations.As<T, decimal>(from.M31), Operations.As<T, decimal>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="sbyte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="sbyte"/> matrix</returns>
        public static explicit operator Matrix3x2<sbyte>(Matrix3x2<T> from)
            => new(
                Operations.As<T, sbyte>(from.M11), Operations.As<T, sbyte>(from.M12),
                Operations.As<T, sbyte>(from.M21), Operations.As<T, sbyte>(from.M22),
                Operations.As<T, sbyte>(from.M31), Operations.As<T, sbyte>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="byte"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="byte"/> matrix</returns>
        public static explicit operator Matrix3x2<byte>(Matrix3x2<T> from)
            => new(
                Operations.As<T, byte>(from.M11), Operations.As<T, byte>(from.M12),
                Operations.As<T, byte>(from.M21), Operations.As<T, byte>(from.M22),
                Operations.As<T, byte>(from.M31), Operations.As<T, byte>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ushort"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ushort"/> matrix</returns>
        public static explicit operator Matrix3x2<ushort>(Matrix3x2<T> from)
            => new(
                Operations.As<T, ushort>(from.M11), Operations.As<T, ushort>(from.M12),
                Operations.As<T, ushort>(from.M21), Operations.As<T, ushort>(from.M22),
                Operations.As<T, ushort>(from.M31), Operations.As<T, ushort>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="short"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="short"/> matrix</returns>
        public static explicit operator Matrix3x2<short>(Matrix3x2<T> from)
            => new(
                Operations.As<T, short>(from.M11), Operations.As<T, short>(from.M12),
                Operations.As<T, short>(from.M21), Operations.As<T, short>(from.M22),
                Operations.As<T, short>(from.M31), Operations.As<T, short>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="uint"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="uint"/> matrix</returns>
        public static explicit operator Matrix3x2<uint>(Matrix3x2<T> from)
            => new(
                Operations.As<T, uint>(from.M11), Operations.As<T, uint>(from.M12),
                Operations.As<T, uint>(from.M21), Operations.As<T, uint>(from.M22),
                Operations.As<T, uint>(from.M31), Operations.As<T, uint>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="int"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="int"/> matrix</returns>
        public static explicit operator Matrix3x2<int>(Matrix3x2<T> from)
            => new(
                Operations.As<T, int>(from.M11), Operations.As<T, int>(from.M12),
                Operations.As<T, int>(from.M21), Operations.As<T, int>(from.M22),
                Operations.As<T, int>(from.M31), Operations.As<T, int>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="ulong"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="ulong"/> matrix</returns>
        public static explicit operator Matrix3x2<ulong>(Matrix3x2<T> from)
            => new(
                Operations.As<T, ulong>(from.M11), Operations.As<T, ulong>(from.M12),
                Operations.As<T, ulong>(from.M21), Operations.As<T, ulong>(from.M22),
                Operations.As<T, ulong>(from.M31), Operations.As<T, ulong>(from.M32)
            );
        
        /// <summary>
        /// Converts a <see cref="Matrix3x2{T}"/> into one with a <typeparamref name="T"/> of <see cref="long"/>
        /// </summary>
        /// <param name="from">The source matrix</param>
        /// <returns>The <see cref="long"/> matrix</returns>
        public static explicit operator Matrix3x2<long>(Matrix3x2<T> from)
            => new(
                Operations.As<T, long>(from.M11), Operations.As<T, long>(from.M12),
                Operations.As<T, long>(from.M21), Operations.As<T, long>(from.M22),
                Operations.As<T, long>(from.M31), Operations.As<T, long>(from.M32)
            );
    }
}
