// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngFilterOption")]
    public enum WICPngFilterOption : int
    {
        [Obsolete("Deprecated in favour of \"PngFilterUnspecified\"")]
        [NativeName("Name", "WICPngFilterUnspecified")]
        WicpngFilterUnspecified = 0x0,
        [Obsolete("Deprecated in favour of \"PngFilterNone\"")]
        [NativeName("Name", "WICPngFilterNone")]
        WicpngFilterNone = 0x1,
        [Obsolete("Deprecated in favour of \"PngFilterSub\"")]
        [NativeName("Name", "WICPngFilterSub")]
        WicpngFilterSub = 0x2,
        [Obsolete("Deprecated in favour of \"PngFilterUp\"")]
        [NativeName("Name", "WICPngFilterUp")]
        WicpngFilterUp = 0x3,
        [Obsolete("Deprecated in favour of \"PngFilterAverage\"")]
        [NativeName("Name", "WICPngFilterAverage")]
        WicpngFilterAverage = 0x4,
        [Obsolete("Deprecated in favour of \"PngFilterPaeth\"")]
        [NativeName("Name", "WICPngFilterPaeth")]
        WicpngFilterPaeth = 0x5,
        [Obsolete("Deprecated in favour of \"PngFilterAdaptive\"")]
        [NativeName("Name", "WICPngFilterAdaptive")]
        WicpngFilterAdaptive = 0x6,
        [Obsolete("Deprecated in favour of \"NgfilteroptionForceDword\"")]
        [NativeName("Name", "WICPNGFILTEROPTION_FORCE_DWORD")]
        WicpngfilteroptionForceDword = 0x7FFFFFFF,
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
