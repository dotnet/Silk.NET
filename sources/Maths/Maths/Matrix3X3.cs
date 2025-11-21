// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Silk.NET.Maths
{
    /// <summary>A structure encapsulating a 3x3 matrix.</summary>
    [Serializable]
    [DataContract]
    public partial struct Matrix3X3<T>
    {
        /// <summary>Constructs a <see cref="Matrix3X3{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public Matrix3X3(Matrix3X2<T> value)
        {
            Row1 = new(value.M11, value.M12, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero);
            Row3 = new(value.M31, value.M32, T.One);
        }

        /// <summary>Constructs a <see cref="Matrix3X3{T}"/> from the given <see cref="Matrix4X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X3{T}"/>.</param>
        public Matrix3X3(Matrix4X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
        }

        /// <summary>Constructs a <see cref="Matrix3X3{T}"/> from the given <see cref="Matrix3X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X4{T}"/>.</param>
        public Matrix3X3(Matrix3X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
        }

        /// <summary>Constructs a <see cref="Matrix3X3{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public Matrix3X3(Matrix3X3<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
        }

        /// <summary>Constructs a <see cref="Matrix3X3{T}"/> from the given <see cref="Matrix2X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix2X4{T}"/>.</param>
        public Matrix3X3(Matrix2X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = Vector3D<T>.UnitZ;
        }

        /// <summary>Constructs a <see cref="Matrix3X3{T}"/> from the given <see cref="Matrix4X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X2{T}"/>.</param>
        public Matrix3X3(Matrix4X2<T> value)
        {
            Row1 = new(value.M11, value.M12, T.Zero);
            Row2 = new(value.M21, value.M22, T.Zero);
            Row3 = new(value.M31, value.M32, T.One);
        }

        /// <summary>Constructs a <see cref="Matrix3X3{T}"/> from the given <see cref="Matrix4X4{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix4X4{T}"/>.</param>
        public Matrix3X3(Matrix4X4<T> value)
        {
            Row1 = new(value.M11, value.M12, value.M13);
            Row2 = new(value.M21, value.M22, value.M23);
            Row3 = new(value.M31, value.M32, value.M33);
        }

        /// <summary>Calculates the determinant of the matrix.</summary>
        /// <returns>The determinant of the matrix.</returns>
        public readonly T GetDeterminant()
        {
            //   | a b c |
            //   | d e f | = ( a ( ei - fh ) - b ( di - fg ) + c ( dh - eg ) )
            //   | g h i |

            T a = Row1.X, b = Row1.Y, c = Row1.Z;
            T d = Row2.X, e = Row2.Y, f = Row2.Z;
            T g = Row3.X, h = Row3.Y, i = Row3.Z;

            return Scalar.Add(
                Scalar.Subtract(
                    Scalar.Multiply(a, Scalar.Subtract(Scalar.Multiply(e, i), Scalar.Multiply(f, h))),
                    Scalar.Multiply(b, Scalar.Subtract(Scalar.Multiply(d, i), Scalar.Multiply(f, g)))),
                Scalar.Multiply(c, Scalar.Subtract(Scalar.Multiply(d, h), Scalar.Multiply(e, g))));
        }
    }
}
