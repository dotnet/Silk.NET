// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_BUFFER_PRECISION")]
    public enum BufferPrecision : int
    {
        [Obsolete("Deprecated in favour of \"PrecisionUnknown\"")]
        [NativeName("Name", "D2D1_BUFFER_PRECISION_UNKNOWN")]
        BufferPrecisionUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Precision8BpcUnorm\"")]
        [NativeName("Name", "D2D1_BUFFER_PRECISION_8BPC_UNORM")]
        BufferPrecision8BpcUnorm = 0x1,
        [Obsolete("Deprecated in favour of \"Precision8BpcUnormSrgb\"")]
        [NativeName("Name", "D2D1_BUFFER_PRECISION_8BPC_UNORM_SRGB")]
        BufferPrecision8BpcUnormSrgb = 0x2,
        [Obsolete("Deprecated in favour of \"Precision16BpcUnorm\"")]
        [NativeName("Name", "D2D1_BUFFER_PRECISION_16BPC_UNORM")]
        BufferPrecision16BpcUnorm = 0x3,
        [Obsolete("Deprecated in favour of \"Precision16BpcFloat\"")]
        [NativeName("Name", "D2D1_BUFFER_PRECISION_16BPC_FLOAT")]
        BufferPrecision16BpcFloat = 0x4,
        [Obsolete("Deprecated in favour of \"Precision32BpcFloat\"")]
        [NativeName("Name", "D2D1_BUFFER_PRECISION_32BPC_FLOAT")]
        BufferPrecision32BpcFloat = 0x5,
        [Obsolete("Deprecated in favour of \"PrecisionForceDword\"")]
        [NativeName("Name", "D2D1_BUFFER_PRECISION_FORCE_DWORD")]
        BufferPrecisionForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_BUFFER_PRECISION_UNKNOWN")]
        PrecisionUnknown = 0x0,
        [NativeName("Name", "D2D1_BUFFER_PRECISION_8BPC_UNORM")]
        Precision8BpcUnorm = 0x1,
        [NativeName("Name", "D2D1_BUFFER_PRECISION_8BPC_UNORM_SRGB")]
        Precision8BpcUnormSrgb = 0x2,
        [NativeName("Name", "D2D1_BUFFER_PRECISION_16BPC_UNORM")]
        Precision16BpcUnorm = 0x3,
        [NativeName("Name", "D2D1_BUFFER_PRECISION_16BPC_FLOAT")]
        Precision16BpcFloat = 0x4,
        [NativeName("Name", "D2D1_BUFFER_PRECISION_32BPC_FLOAT")]
        Precision32BpcFloat = 0x5,
        [NativeName("Name", "D2D1_BUFFER_PRECISION_FORCE_DWORD")]
        PrecisionForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
