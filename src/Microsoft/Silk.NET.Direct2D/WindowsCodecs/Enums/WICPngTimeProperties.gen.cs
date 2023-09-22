// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngTimeProperties")]
    public enum WICPngTimeProperties : int
    {
        [Obsolete("Deprecated in favour of \"Year\"")]
        [NativeName("Name", "WICPngTimeYear")]
        WicpngTimeYear = 0x1,
        [Obsolete("Deprecated in favour of \"Month\"")]
        [NativeName("Name", "WICPngTimeMonth")]
        WicpngTimeMonth = 0x2,
        [Obsolete("Deprecated in favour of \"Day\"")]
        [NativeName("Name", "WICPngTimeDay")]
        WicpngTimeDay = 0x3,
        [Obsolete("Deprecated in favour of \"Hour\"")]
        [NativeName("Name", "WICPngTimeHour")]
        WicpngTimeHour = 0x4,
        [Obsolete("Deprecated in favour of \"Minute\"")]
        [NativeName("Name", "WICPngTimeMinute")]
        WicpngTimeMinute = 0x5,
        [Obsolete("Deprecated in favour of \"Second\"")]
        [NativeName("Name", "WICPngTimeSecond")]
        WicpngTimeSecond = 0x6,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICPngTimeProperties_FORCE_DWORD")]
        WicpngTimePropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICPngTimeYear")]
        Year = 0x1,
        [NativeName("Name", "WICPngTimeMonth")]
        Month = 0x2,
        [NativeName("Name", "WICPngTimeDay")]
        Day = 0x3,
        [NativeName("Name", "WICPngTimeHour")]
        Hour = 0x4,
        [NativeName("Name", "WICPngTimeMinute")]
        Minute = 0x5,
        [NativeName("Name", "WICPngTimeSecond")]
        Second = 0x6,
        [NativeName("Name", "WICPngTimeProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
