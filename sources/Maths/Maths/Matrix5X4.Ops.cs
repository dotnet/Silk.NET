// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix4X4{T}"/>
    /// </summary>
    public static partial class Matrix5X4
    {
        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public static Matrix5X4<T> CreateFromAffine<T>(Matrix3X2<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, T.Zero, T.Zero),
                new(value.M21, value.M22, T.Zero, T.Zero),
                Vector4D<T>.UnitZ,
                Vector4D<T>.UnitW,
                new(value.M31, value.M32, T.Zero, T.Zero)
            );

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public static Matrix5X4<T> CreateFromLinear<T>(Matrix3X3<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, value.M13, T.Zero),
                new(value.M21, value.M22, value.M23, T.Zero),
                Vector4D<T>.UnitZ,
                Vector4D<T>.UnitW,
                new(value.M31, value.M32, value.M33, T.Zero)
            );

        /// <summary>Constructs a <see cref="Matrix5X4{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public static Matrix5X4<T> CreateFromHomogenous<T>(Matrix3X3<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, T.Zero, value.M13),
                new(value.M21, value.M22, T.Zero, value.M23),
                Vector4D<T>.UnitZ,
                Vector4D<T>.UnitW,
                new(value.M31, value.M32, T.Zero, value.M33)
            );

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="left">The vector.</param>
        /// <param name="right">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector4D<T> Multiply<T>(Vector4D<T> left, Matrix5X4<T> right)
            where T : INumberBase<T> =>
            left * right;
    }
}
