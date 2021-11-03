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
    public static unsafe partial class Simd128
    {
        // these two should ONLY be used in the constant-sized unrolled loops.
        // unfortunately there is an issue otherwise. See https://sharplab.io/#v2:EYLgxg9gTgpgtADwGwBYA0AXEBDAzgWwB8ABAJgEYBYAKGIAYACY8gOgCUBXAOwwEt8YLAJI8ovLrl5hcAbho1iAZiakGAYRoBvGg11MUDACoxcGABQBKHXu3U99hgDNoDM+IwNeDALwM6MzwYAHgYANRgwDGhyUgAOIMcAGwhsDAA+FjUIbgwA3gBqfKs7B1KAOQgAeQAHNws5Et0AX2tdVv0GCpq3Hk9i+1tS3V5HVzMOdwtAtN8AegAqccn52fDI6LiE5NSMrJyp2dnguDgGbkh8AV6wPAx2oaZyAE5LBvsW6iagA
        [MethodImpl(Scalar.MaxOpt)]
        private static Vector128<T> WithElement<T>(Vector128<T> vector, int index, T value) where T : unmanaged
        {
            Vector128<T> result = vector;
            ref T e0 = ref Unsafe.As<Vector128<T>, T>(ref result);
            Unsafe.Add(ref e0, index) = value;
            return result;
        }

        [MethodImpl(Scalar.MaxOpt)]
        private static T GetElement<T>(Vector128<T> vector, int index) where T : unmanaged
        {
            ref T e0 = ref Unsafe.As<Vector128<T>, T>(ref vector);
            return Unsafe.Add(ref e0, index);
        }

        
    }
}
#endif
