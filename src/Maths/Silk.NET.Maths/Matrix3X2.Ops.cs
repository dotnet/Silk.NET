// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix3X2{T}"/>
    /// </summary>
    public static class Matrix3X2
    {
#if MATHF
        private const float RotationEpsilon = 0.001f * MathF.PI / 180f;     // 0.1% of a degree
#else
        private const float RotationEpsilon = 0.001f * ((float) Math.PI) / 180f;     // 0.1% of a degree
#endif

        /// <summary>Adds each matrix element in value1 with its corresponding element in value2.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The matrix containing the summed values.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3X2<T> Add<T>(Matrix3X2<T> value1, Matrix3X2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 + value2;

        /// <summary>Creates a rotation matrix using the given rotation in radians.</summary>
        /// <param name="radians">The amount of rotation, in radians.</param>
        /// <returns>A rotation matrix.</returns>
        public static Matrix3X2<T> CreateRotation<T>(T radians)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            radians = Scalar.IEEERemainder(radians, Scalar<T>.Tau);

            T c, s;

            if (Scalar.GreaterThan(radians, Scalar.As<float, T>(-RotationEpsilon)) && !Scalar.GreaterThanOrEqual(radians, Scalar.As<float, T>(RotationEpsilon)))
            {
                // Exact case for zero rotation.
                c = Scalar<T>.One;
                s = Scalar<T>.Zero;
            }
            else if (Scalar.GreaterThan(radians, Scalar.As<float, T>(
#if MATHF
                MathF.PI
#else
                ((float) Math.PI)
#endif
                / 2 - RotationEpsilon)) && !Scalar.GreaterThanOrEqual(radians, Scalar.As<float, T>(
#if MATHF
                MathF.PI
#else
                ((float) Math.PI)
#endif
                / 2 + RotationEpsilon)))
            {
                // Exact case for 90 degree rotation.
                c = Scalar<T>.Zero;
                s = Scalar<T>.One;
            }
            else if (!Scalar.GreaterThanOrEqual(radians, Scalar.As<float, T>(-
#if MATHF
                MathF.PI
#else
                                                                                 ((float) Math.PI)
#endif
                                                                             + RotationEpsilon)) || Scalar.GreaterThan(radians, Scalar.As<float, T>(
#if MATHF
                MathF.PI
#else
                ((float) Math.PI)
#endif
                - RotationEpsilon)))
            {
                // Exact case for 180 degree rotation.
                c = Scalar<T>.MinusOne;
                s = Scalar<T>.Zero;
            }
            else if (Scalar.GreaterThan(radians, Scalar.As<float, T>(-
#if MATHF
                MathF.PI
#else
                    ((float) Math.PI)
#endif
                / 2 - RotationEpsilon)) && !Scalar.GreaterThanOrEqual(radians, Scalar.As<float, T>(-
#if MATHF
                MathF.PI
#else
                    ((float) Math.PI)
#endif
                / 2 + RotationEpsilon)))
            {
                // Exact case for 270 degree rotation.
                c = Scalar<T>.Zero;
                s = Scalar<T>.MinusOne;
            }
            else
            {
                // Arbitrary rotation.
                c = Scalar.Cos(radians);
                s = Scalar.Sin(radians);
            }

            // [  c  s ]
            // [ -s  c ]
            // [  0  0 ]
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            result.M11 = c;
            result.M12 = s;
            result.M21 = Scalar.Negate(s);
            result.M22 = c;

            return result;
        }

        /// <summary>Creates a rotation matrix using the given rotation in radians and a center point.</summary>
        /// <param name="radians">The amount of rotation, in radians.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>A rotation matrix.</returns>
        public static Matrix3X2<T> CreateRotation<T>(T radians, Vector2D<T> centerPoint)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            radians = Scalar.IEEERemainder(radians, Scalar<T>.Tau);

            T c, s;

            if (Scalar.GreaterThan(radians, Scalar.As<float, T>(-RotationEpsilon)) && !Scalar.GreaterThanOrEqual(radians, Scalar.As<float, T>(RotationEpsilon)))
            {
                // Exact case for zero rotation.
                c = Scalar<T>.One;
                s = Scalar<T>.Zero;
            }
            else if (Scalar.GreaterThan(radians, Scalar.As<float, T>(
#if MATHF
                MathF.PI
#else
                ((float) Math.PI)
#endif
                / 2 - RotationEpsilon)) && !Scalar.GreaterThanOrEqual(radians, Scalar.As<float, T>(
#if MATHF
                MathF.PI
#else
                ((float) Math.PI)
#endif
                / 2 + RotationEpsilon)))
            {
                // Exact case for 90 degree rotation.
                c = Scalar<T>.Zero;
                s = Scalar<T>.One;
            }
            else if (!Scalar.GreaterThanOrEqual(radians, Scalar.As<float, T>(-
#if MATHF
                MathF.PI
#else
                                                                                 ((float) Math.PI)
#endif
                                                                             + RotationEpsilon)) || Scalar.GreaterThan(radians, Scalar.As<float, T>(
#if MATHF
                MathF.PI
#else
                ((float) Math.PI)
#endif    
                - RotationEpsilon)))
            {
                // Exact case for 180 degree rotation.
                c = Scalar<T>.MinusOne;
                s = Scalar<T>.Zero;
            }
            else if (Scalar.GreaterThan(radians, Scalar.As<float, T>(-
#if MATHF
                MathF.PI
#else
                    ((float) Math.PI)
#endif
                / 2 - RotationEpsilon)) && !Scalar.GreaterThanOrEqual(radians, Scalar.As<float, T>(-
#if MATHF
                MathF.PI
#else
                    ((float) Math.PI)
#endif
                / 2 + RotationEpsilon)))
            {
                // Exact case for 270 degree rotation.
                c = Scalar<T>.Zero;
                s = Scalar<T>.MinusOne;
            }
            else
            {
                // Arbitrary rotation.
                c = Scalar.Cos(radians);
                s = Scalar.Sin(radians);
            }

            T x = Scalar.Add(Scalar.Multiply(centerPoint.X, Scalar.Subtract(Scalar<T>.One, c)), Scalar.Multiply(centerPoint.Y, s));
            T y = Scalar.Subtract(Scalar.Multiply(centerPoint.Y, Scalar.Subtract(Scalar<T>.One, c)), Scalar.Multiply(centerPoint.X, s));

            // [  c  s ]
            // [ -s  c ]
            // [  x  y ]
            return new(
                new(c, s),
                new(Scalar.Negate(s), c),
                new(x, y));
        }

        /// <summary>Creates a scale matrix from the given vector scale.</summary>
        /// <param name="scales">The scale to use.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3X2<T> CreateScale<T>(Vector2D<T> scales)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            result.M11 = scales.X;
            result.M22 = scales.Y;

            return result;
        }

        /// <summary>Creates a scale matrix from the given X and Y components.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3X2<T> CreateScale<T>(T xScale, T yScale)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            result.M11 = xScale;
            result.M22 = yScale;

            return result;
        }

        /// <summary>Creates a scale matrix that is offset by a given center point.</summary>
        /// <param name="xScale">Value to scale by on the X-axis.</param>
        /// <param name="yScale">Value to scale by on the Y-axis.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3X2<T> CreateScale<T>(T xScale, T yScale, Vector2D<T> centerPoint)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T tx = Scalar.Multiply(centerPoint.X, Scalar.Subtract(Scalar<T>.One, xScale));
            T ty = Scalar.Multiply(centerPoint.Y, Scalar.Subtract(Scalar<T>.One, yScale));

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
        public static Matrix3X2<T> CreateScale<T>(Vector2D<T> scales, Vector2D<T> centerPoint)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T tx = Scalar.Multiply(centerPoint.X, Scalar.Subtract(Scalar<T>.One, scales.X));
            T ty = Scalar.Multiply(centerPoint.Y, Scalar.Subtract(Scalar<T>.One, scales.Y));

            result.M11 = scales.X;
            result.M22 = scales.Y;
            result.M31 = tx;
            result.M32 = ty;

            return result;
        }

        /// <summary>Creates a scale matrix that scales uniformly with the given scale.</summary>
        /// <param name="scale">The uniform scale to use.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3X2<T> CreateScale<T>(T scale)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            result.M11 = scale;
            result.M22 = scale;

            return result;
        }

        /// <summary>Creates a scale matrix that scales uniformly with the given scale with an offset from the given center.</summary>
        /// <param name="scale">The uniform scale to use.</param>
        /// <param name="centerPoint">The center offset.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3X2<T> CreateScale<T>(T scale, Vector2D<T> centerPoint)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T tx = Scalar.Multiply(centerPoint.X, Scalar.Subtract(Scalar<T>.One, scale));
            T ty = Scalar.Multiply(centerPoint.Y, Scalar.Subtract(Scalar<T>.One, scale));

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
        public static Matrix3X2<T> CreateSkew<T>(T radiansX, T radiansY)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T xTan = Scalar.Tan(radiansX);
            T yTan = Scalar.Tan(radiansY);

            result.M12 = yTan;
            result.M21 = xTan;

            return result;
        }

        /// <summary>Creates a skew matrix from the given angles in radians and a center point.</summary>
        /// <param name="radiansX">The X angle, in radians.</param>
        /// <param name="radiansY">The Y angle, in radians.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>A skew matrix.</returns>
        public static Matrix3X2<T> CreateSkew<T>(T radiansX, T radiansY, Vector2D<T> centerPoint)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T xTan = Scalar.Tan(radiansX);
            T yTan = Scalar.Tan(radiansY);

            T tx = Scalar.Negate(Scalar.Multiply(centerPoint.Y, xTan));
            T ty = Scalar.Negate(Scalar.Multiply(centerPoint.X, yTan));

            result.M12 = yTan;
            result.M21 = xTan;

            result.M31 = tx;
            result.M32 = ty;

            return result;
        }

        /// <summary>Creates a translation matrix from the given vector.</summary>
        /// <param name="position">The translation position.</param>                        `
        /// <returns>A translation matrix.</returns>
        public static Matrix3X2<T> CreateTranslation<T>(Vector2D<T> position)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            result.M31 = position.X;
            result.M32 = position.Y;

            return result;
        }

        /// <summary>Creates a translation matrix from the given X and Y components.</summary>
        /// <param name="xPosition">The X position.</param>
        /// <param name="yPosition">The Y position.</param>
        /// <returns>A translation matrix.</returns>
        public static Matrix3X2<T> CreateTranslation<T>(T xPosition, T yPosition)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            result.M31 = xPosition;
            result.M32 = yPosition;

            return result;
        }

        /// <summary>Attempts to invert the given matrix. If the operation succeeds, the inverted matrix is stored in the result parameter.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="result">The output matrix.</param>
        /// <returns>True if the operation succeeded, False otherwise.</returns>
        public static bool Invert<T>(Matrix3X2<T> matrix, out Matrix3X2<T> result)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            T det = Scalar.Subtract(Scalar.Multiply(matrix.M11, matrix.M22), Scalar.Multiply(matrix.M21, matrix.M12));

            if (!Scalar.GreaterThanOrEqual(Scalar.Abs(det), Scalar<T>.Epsilon))
            {
                result = new(Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN, Scalar<T>.NaN);
                return false;
            }

            T invDet = Scalar.Reciprocal(det);

            result = default;

            result.M11 = Scalar.Multiply(matrix.M22, invDet);
            result.M12 = Scalar.Negate(Scalar.Multiply(matrix.M12, invDet));

            result.M21 = Scalar.Negate(Scalar.Multiply(matrix.M21, invDet));
            result.M22 = Scalar.Multiply(matrix.M11, invDet);

            result.M31 = Scalar.Multiply(Scalar.Subtract(Scalar.Multiply(matrix.M21, matrix.M32), Scalar.Multiply(matrix.M31, matrix.M22)), invDet);
            result.M32 = Scalar.Multiply(Scalar.Subtract(Scalar.Multiply(matrix.M31, matrix.M12), Scalar.Multiply(matrix.M11, matrix.M32)), invDet);

            return true;
        }

        /// <summary>Linearly interpolates from matrix1 to matrix2, based on the third parameter.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weighting of matrix2.</param>
        /// <returns>The interpolated matrix.</returns>
        public static Matrix3X2<T> Lerp<T>(Matrix3X2<T> matrix1, Matrix3X2<T> matrix2, T amount)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return new(Vector2D.Lerp(matrix1.Row1, matrix2.Row1, amount),
                Vector2D.Lerp(matrix1.Row2, matrix2.Row2, amount),
                Vector2D.Lerp(matrix1.Row3, matrix2.Row3, amount));
        }

        /// <summary>Multiplies two matrices together and returns the resulting matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The product matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3X2<T> Multiply<T>(Matrix3X2<T> value1, Matrix2X2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2D<T> Multiply<T>(Vector3D<T> value1, Matrix3X2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies two matrices together and returns the resulting matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The product matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3X3<T> Multiply<T>(Matrix3X2<T> value1, Matrix2X3<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies two matrices together and returns the resulting matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The product matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2X2<T> Multiply<T>(Matrix2X3<T> value1, Matrix3X2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies two matrices together and returns the resulting matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The product matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2X3<T> Multiply<T>(Matrix2X3<T> value1, Matrix3X3<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Multiplies two matrices together and returns the resulting matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The product matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3X2<T> Multiply<T>(Matrix3X3<T> value1, Matrix3X2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Scales all elements in a matrix by the given scalar factor.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling value to use.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3X2<T> Multiply<T>(Matrix3X2<T> value1, T value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 * value2;

        /// <summary>Negates the given matrix by multiplying all values by -1.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3X2<T> Negate<T>(Matrix3X2<T> value)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => -value;

        /// <summary>Subtracts each matrix element in value2 from its corresponding element in value1.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The matrix containing the resulting values.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3X2<T> Subtract<T>(Matrix3X2<T> value1, Matrix3X2<T> value2)
            where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
            => value1 - value2;
    }
}
