// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix4X4{T}"/>
    /// </summary>
    public static partial class Matrix5X4
    {
        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector4D<T> Multiply<T>(Vector4D<T> value1, Matrix5X4<T> value2)
            where T : INumberBase<T>
            => value1 * value2;
    }
}
