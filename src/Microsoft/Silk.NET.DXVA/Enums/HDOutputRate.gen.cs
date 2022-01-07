// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_OUTPUT_RATE")]
    public enum HDOutputRate : int
    {
        [NativeName("Name", "DXVAHD_OUTPUT_RATE_NORMAL")]
        HDOutputRateNormal = 0x0,
        [NativeName("Name", "DXVAHD_OUTPUT_RATE_HALF")]
        HDOutputRateHalf = 0x1,
        [NativeName("Name", "DXVAHD_OUTPUT_RATE_CUSTOM")]
        HDOutputRateCustom = 0x2,
    }
}
