// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngFilterOption")]
    public enum PngFilterOption : int
    {
        [NativeName("Name", "WICPngFilterUnspecified")]
        PngFilterUnspecified = 0x0,
        [NativeName("Name", "WICPngFilterNone")]
        PngFilterNone = 0x1,
        [NativeName("Name", "WICPngFilterSub")]
        PngFilterSub = 0x2,
        [NativeName("Name", "WICPngFilterUp")]
        PngFilterUp = 0x3,
        [NativeName("Name", "WICPngFilterAverage")]
        PngFilterAverage = 0x4,
        [NativeName("Name", "WICPngFilterPaeth")]
        PngFilterPaeth = 0x5,
        [NativeName("Name", "WICPngFilterAdaptive")]
        PngFilterAdaptive = 0x6,
        [NativeName("Name", "WICPNGFILTEROPTION_FORCE_DWORD")]
        NgfilteroptionForceDword = 0x7FFFFFFF,
    }
}
