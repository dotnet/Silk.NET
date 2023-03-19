// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_OUTPUT_RATE")]
    public enum HDOutputRate : int
    {
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "DXVAHD_OUTPUT_RATE_NORMAL")]
        HDOutputRateNormal = 0x0,
        [Obsolete("Deprecated in favour of \"Half\"")]
        [NativeName("Name", "DXVAHD_OUTPUT_RATE_HALF")]
        HDOutputRateHalf = 0x1,
        [Obsolete("Deprecated in favour of \"Custom\"")]
        [NativeName("Name", "DXVAHD_OUTPUT_RATE_CUSTOM")]
        HDOutputRateCustom = 0x2,
        [NativeName("Name", "DXVAHD_OUTPUT_RATE_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "DXVAHD_OUTPUT_RATE_HALF")]
        Half = 0x1,
        [NativeName("Name", "DXVAHD_OUTPUT_RATE_CUSTOM")]
        Custom = 0x2,
    }
}
