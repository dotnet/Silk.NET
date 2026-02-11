// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix3X2{T}"/>
    /// </summary>
    public static partial class Matrix3X2
    {
        private const float RotationEpsilon = 0.001f * MathF.PI / 180f;     // 0.1% of a degree

        /// <summary>Creates a rotation matrix using the given rotation in radians.</summary>
        /// <param name="radians">The amount of rotation, in radians.</param>
        /// <returns>A rotation matrix.</returns>
        public static Matrix3X2<T> CreateRotation<T>(T radians)
            where T : IFloatingPointIeee754<T>
        {
            radians = T.Ieee754Remainder(radians, T.Tau);

            T c, s;

            if ((radians > T.CreateTruncating(-RotationEpsilon)) && !(radians >= T.CreateTruncating(RotationEpsilon)))
            {
                // Exact case for zero rotation.
                c = T.One;
                s = T.Zero;
            }
            else if ((radians > T.CreateTruncating(
                MathF.PI
                / 2 - RotationEpsilon)) && !(radians >= T.CreateTruncating(
                MathF.PI
                / 2 + RotationEpsilon)))
            {
                // Exact case for 90 degree rotation.
                c = T.Zero;
                s = T.One;
            }
            else if (!(radians >= T.CreateTruncating(-
                MathF.PI
                                                                             + RotationEpsilon)) || (radians > T.CreateTruncating(
                MathF.PI
                - RotationEpsilon)))
            {
                // Exact case for 180 degree rotation.
                c = -T.One;
                s = T.Zero;
            }
            else if ((radians > T.CreateTruncating(-
                MathF.PI
                / 2 - RotationEpsilon)) && !(radians >= T.CreateTruncating(-
                MathF.PI
                / 2 + RotationEpsilon)))
            {
                // Exact case for 270 degree rotation.
                c = T.Zero;
                s = -T.One;
            }
            else
            {
                // Arbitrary rotation.
                c = T.Cos(radians);
                s = T.Sin(radians);
            }

            // [  c  s ]
            // [ -s  c ]
            // [  0  0 ]
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            result.M11 = c;
            result.M12 = s;
            result.M21 = -s;
            result.M22 = c;

            return result;
        }

        /// <summary>Creates a rotation matrix using the given rotation in radians and a center point.</summary>
        /// <param name="radians">The amount of rotation, in radians.</param>
        /// <param name="centerPoint">The center point.</param>
        /// <returns>A rotation matrix.</returns>
        public static Matrix3X2<T> CreateRotation<T>(T radians, Vector2D<T> centerPoint)
            where T : IFloatingPointIeee754<T>
        {
            radians = T.Ieee754Remainder(radians, T.Tau);

            T c, s;

            if ((radians > T.CreateTruncating(-RotationEpsilon)) && !(radians >= T.CreateTruncating(RotationEpsilon)))
            {
                // Exact case for zero rotation.
                c = T.One;
                s = T.Zero;
            }
            else if ((radians > T.CreateTruncating(
                MathF.PI
                / 2 - RotationEpsilon)) && !(radians >= T.CreateTruncating(
                MathF.PI
                / 2 + RotationEpsilon)))
            {
                // Exact case for 90 degree rotation.
                c = T.Zero;
                s = T.One;
            }
            else if (!(radians >= T.CreateTruncating(-
                MathF.PI
                                                                             + RotationEpsilon)) || (radians > T.CreateTruncating(
                MathF.PI
                - RotationEpsilon)))
            {
                // Exact case for 180 degree rotation.
                c = -T.One;
                s = T.Zero;
            }
            else if ((radians > T.CreateTruncating(-
                MathF.PI
                / 2 - RotationEpsilon)) && !(radians >= T.CreateTruncating(-
                MathF.PI
                / 2 + RotationEpsilon)))
            {
                // Exact case for 270 degree rotation.
                c = T.Zero;
                s = -T.One;
            }
            else
            {
                // Arbitrary rotation.
                c = T.Cos(radians);
                s = T.Sin(radians);
            }

            T x = (centerPoint.X * (T.One - c)) + (centerPoint.Y * s);
            T y = (centerPoint.Y * (T.One - c)) - (centerPoint.X * s);

            // [  c  s ]
            // [ -s  c ]
            // [  x  y ]
            return new(
                new(c, s),
                new(-s, c),
                new(x, y));
        }

        /// <summary>Creates a scale matrix from the given vector scale.</summary>
        /// <param name="scales">The scale to use.</param>
        /// <returns>A scaling matrix.</returns>
        public static Matrix3X2<T> CreateScale<T>(Vector2D<T> scales)
            where T : INumberBase<T>
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
            where T : INumberBase<T>
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
            where T : INumberBase<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T tx = centerPoint.X * (T.One - xScale);
            T ty = centerPoint.Y * (T.One - yScale);

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
            where T : INumberBase<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T tx = centerPoint.X * (T.One - scales.X);
            T ty = centerPoint.Y * (T.One - scales.Y);

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
            where T : INumberBase<T>
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
            where T : INumberBase<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T tx = centerPoint.X * (T.One - scale);
            T ty = centerPoint.Y * (T.One - scale);

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
            where T : ITrigonometricFunctions<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T xTan = T.Tan(radiansX);
            T yTan = T.Tan(radiansY);

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
            where T : ITrigonometricFunctions<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            T xTan = T.Tan(radiansX);
            T yTan = T.Tan(radiansY);

            T tx = -(centerPoint.Y * xTan);
            T ty = -(centerPoint.X * yTan);

            result.M12 = yTan;
            result.M21 = xTan;

            result.M31 = tx;
            result.M32 = ty;

            return result;
        }

        /// <summary>Creates a translation matrix from the given vector.</summary>
        /// <param name="position">The translation position.</param>
        /// <returns>A translation matrix.</returns>
        public static Matrix3X2<T> CreateTranslation<T>(Vector2D<T> position)
            where T : INumberBase<T>
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
            where T : INumberBase<T>
        {
            Matrix3X2<T> result = Matrix3X2<T>.Identity;

            result.M31 = xPosition;
            result.M32 = yPosition;

            return result;
        }

        /// <summary>Attempts to invert the given matrix. If the operation succeeds, the inverted matrix is stored in the result parameter.</summary>
        /// <param name="matrix">The source matrix.</param>
        /// <param name="result">The output matrix.</param>
        /// <returns><c>true</c> if the operation succeeded, False otherwise.</returns>
        public static bool Invert<T>(Matrix3X2<T> matrix, out Matrix3X2<T> result)
            where T : IFloatingPointIeee754<T>
        {
            T det = (matrix.M11 * matrix.M22) - (matrix.M21 * matrix.M12);

            if (!(T.Abs(det) >= T.Epsilon))
            {
                result = new(T.NaN, T.NaN, T.NaN, T.NaN, T.NaN, T.NaN);
                return false;
            }

            T invDet = T.One / det;

            result = default;

            result.M11 = matrix.M22 * invDet;
            result.M12 = -(matrix.M12 * invDet);

            result.M21 = -(matrix.M21 * invDet);
            result.M22 = matrix.M11 * invDet;

            result.M31 = ((matrix.M21 * matrix.M32) - (matrix.M31 * matrix.M22)) * invDet;
            result.M32 = ((matrix.M31 * matrix.M12) - (matrix.M11 * matrix.M32)) * invDet;

            return true;
        }
    }
}
