// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_FRAME_FORMAT")]
    public enum HDFrameFormat : int
    {
        [NativeName("Name", "DXVAHD_FRAME_FORMAT_PROGRESSIVE")]
        HDFrameFormatProgressive = 0x0,
        [NativeName("Name", "DXVAHD_FRAME_FORMAT_INTERLACED_TOP_FIELD_FIRST")]
        HDFrameFormatInterlacedTopFieldFirst = 0x1,
        [NativeName("Name", "DXVAHD_FRAME_FORMAT_INTERLACED_BOTTOM_FIELD_FIRST")]
        HDFrameFormatInterlacedBottomFieldFirst = 0x2,
    }
}
