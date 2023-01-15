// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_MIN_PRECISION")]
    public enum D3DMinPrecision : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D3D_MIN_PRECISION_DEFAULT")]
        D3DMinPrecisionDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Float16\"")]
        [NativeName("Name", "D3D_MIN_PRECISION_FLOAT_16")]
        D3DMinPrecisionFloat16 = 0x1,
        [Obsolete("Deprecated in favour of \"Float28\"")]
        [NativeName("Name", "D3D_MIN_PRECISION_FLOAT_2_8")]
        D3DMinPrecisionFloat28 = 0x2,
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "D3D_MIN_PRECISION_RESERVED")]
        D3DMinPrecisionReserved = 0x3,
        [Obsolete("Deprecated in favour of \"Sint16\"")]
        [NativeName("Name", "D3D_MIN_PRECISION_SINT_16")]
        D3DMinPrecisionSint16 = 0x4,
        [Obsolete("Deprecated in favour of \"Uint16\"")]
        [NativeName("Name", "D3D_MIN_PRECISION_UINT_16")]
        D3DMinPrecisionUint16 = 0x5,
        [Obsolete("Deprecated in favour of \"Any16\"")]
        [NativeName("Name", "D3D_MIN_PRECISION_ANY_16")]
        D3DMinPrecisionAny16 = 0xF0,
        [Obsolete("Deprecated in favour of \"Any10\"")]
        [NativeName("Name", "D3D_MIN_PRECISION_ANY_10")]
        D3DMinPrecisionAny10 = 0xF1,
        [NativeName("Name", "D3D_MIN_PRECISION_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "D3D_MIN_PRECISION_FLOAT_16")]
        Float16 = 0x1,
        [NativeName("Name", "D3D_MIN_PRECISION_FLOAT_2_8")]
        Float28 = 0x2,
        [NativeName("Name", "D3D_MIN_PRECISION_RESERVED")]
        Reserved = 0x3,
        [NativeName("Name", "D3D_MIN_PRECISION_SINT_16")]
        Sint16 = 0x4,
        [NativeName("Name", "D3D_MIN_PRECISION_UINT_16")]
        Uint16 = 0x5,
        [NativeName("Name", "D3D_MIN_PRECISION_ANY_16")]
        Any16 = 0xF0,
        [NativeName("Name", "D3D_MIN_PRECISION_ANY_10")]
        Any10 = 0xF1,
    }
}
