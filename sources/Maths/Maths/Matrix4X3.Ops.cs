// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix4X3{T}"/>
    /// </summary>
    public static partial class Matrix4X3
    {
        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X2{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X2{T}"/>.</param>
        public static Matrix4X3<T> CreateFromAffine<T>(Matrix3X2<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, T.Zero),
                new(value.M21, value.M22, T.Zero),
                Vector3D<T>.UnitZ,
                new(value.M31, value.M32, T.Zero)
            );

        /// <summary>Constructs a <see cref="Matrix4X3{T}"/> from the given <see cref="Matrix3X3{T}"/>.</summary>
        /// <param name="value">The source <see cref="Matrix3X3{T}"/>.</param>
        public static Matrix4X3<T> CreateFromAffine<T>(Matrix3X3<T> value)
            where T : INumber<T> => new
            (
                new(value.M11, value.M12, value.M13),
                new(value.M21, value.M22, value.M23),
                Vector3D<T>.UnitZ,
                new(value.M31, value.M32, value.M33)
            );
    }
}
