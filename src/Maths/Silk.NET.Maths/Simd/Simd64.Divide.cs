// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if INTRINSICS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
#if SSE
using System.Runtime.Intrinsics.X86;
#endif
#if AdvSIMD
using System.Runtime.Intrinsics.Arm;
#endif

namespace Silk.NET.Maths
{
    public static unsafe partial class Simd64
    {
        /// <summary>
        /// Performs hardware-accelerated Divide on 64-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Divide<T>(Vector64<T> left, Vector64<T> right) where T : unmanaged
        {
            return Other8byte(left, right);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other8byte(Vector64<T> left, Vector64<T> right)
            {
                if (sizeof(T) == 8)
                {
                    var res = Scalar.Divide(Unsafe.As<Vector64<T>, T>(ref left), Unsafe.As<Vector64<T>, T>(ref right));
                    return Unsafe.As<T, Vector64<T>>(ref res);
                }
                return Other(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> left, Vector64<T> right)
            {
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    vec = vec.WithElement(i, Scalar.Divide(left.GetElement(i), right.GetElement(i)));
                }
                return vec;
            }
        }
    }
}
#endif
