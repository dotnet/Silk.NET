// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_MIN_PRECISION")]
    public enum MinPrecision
    {
        [NativeName("Name", "D3D_MIN_PRECISION_DEFAULT")]
        MinPrecisionDefault = 0x0,
        [NativeName("Name", "D3D_MIN_PRECISION_FLOAT_16")]
        MinPrecisionFloat16 = 0x1,
        [NativeName("Name", "D3D_MIN_PRECISION_FLOAT_2_8")]
        MinPrecisionFloat28 = 0x2,
        [NativeName("Name", "D3D_MIN_PRECISION_RESERVED")]
        MinPrecisionReserved = 0x3,
        [NativeName("Name", "D3D_MIN_PRECISION_SINT_16")]
        MinPrecisionSint16 = 0x4,
        [NativeName("Name", "D3D_MIN_PRECISION_UINT_16")]
        MinPrecisionUint16 = 0x5,
        [NativeName("Name", "D3D_MIN_PRECISION_ANY_16")]
        MinPrecisionAny16 = 0xF0,
        [NativeName("Name", "D3D_MIN_PRECISION_ANY_10")]
        MinPrecisionAny10 = 0xF1,
    }
}
