// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngTimeProperties")]
    public enum PngTimeProperties : int
    {
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
