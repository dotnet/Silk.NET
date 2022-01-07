// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_FRAME_FORMAT")]
    public enum VideoFrameFormat : int
    {
        [NativeName("Name", "D3D11_VIDEO_FRAME_FORMAT_PROGRESSIVE")]
        VideoFrameFormatProgressive = 0x0,
        [NativeName("Name", "D3D11_VIDEO_FRAME_FORMAT_INTERLACED_TOP_FIELD_FIRST")]
        VideoFrameFormatInterlacedTopFieldFirst = 0x1,
        [NativeName("Name", "D3D11_VIDEO_FRAME_FORMAT_INTERLACED_BOTTOM_FIELD_FIRST")]
        VideoFrameFormatInterlacedBottomFieldFirst = 0x2,
    }
}
