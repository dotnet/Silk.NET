// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    public static partial class Scalar
    {
        [MethodImpl(MaxOpt)]
        private static float CoreFastPow(float x, float y)
        {
            // improvements can be made here, namely by actually porting a full impl
            // see https://github.com/amd/aocl-libm-ose/blob/master/src/optmized/powf.c

            return Exp(y * Log(x));
        }
    }
}
