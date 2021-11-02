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
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Divide<T>(Vector64<T> left, Vector64<T> right) where T : unmanaged
        {

                return Other(left, right);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> left, Vector64<T> right)
            {
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Divide(GetElement(left, i), GetElement(right, i)));
                }

                return vec;
            }

        }
    }
}
