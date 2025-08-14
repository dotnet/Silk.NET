// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICJpegXLAnimProperties")]
    public enum JpegXLAnimProperties : int
    {
        [NativeName("Name", "WICJpegXLAnimLoopCount")]
        LoopCount = 0x1,
        [NativeName("Name", "WICJpegXLAnimFrameTicksPerSecondNumerator")]
        FrameTicksPerSecondNumerator = 0x2,
        [NativeName("Name", "WICJpegXLAnimFrameTicksPerSecondDenominator")]
        FrameTicksPerSecondDenominator = 0x3,
        [NativeName("Name", "WICJpegXLAnimProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
