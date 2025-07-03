// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix4X2{T}"/>
    /// </summary>
    public static partial class Matrix4X2
    {
        /*[MethodImpl((MethodImplOptions)768)]
        private static Vector128<T> Permute<T>(Vector128<T> value, byte control)
            where T : INumberBase<T>
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
    }
}
