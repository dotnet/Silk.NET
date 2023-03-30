// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BUFFER_PRECISION")]
    public enum BufferPrecision : int
    {
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
