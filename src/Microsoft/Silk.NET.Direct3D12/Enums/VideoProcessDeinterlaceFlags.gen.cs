// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS")]
    public enum VideoProcessDeinterlaceFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE")]
        VideoProcessDeinterlaceFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Bob\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB")]
        VideoProcessDeinterlaceFlagBob = 0x1,
        [Obsolete("Deprecated in favour of \"Custom\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM")]
        VideoProcessDeinterlaceFlagCustom = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB")]
        Bob = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM")]
        Custom = unchecked((int) 0xFFFFFFFF80000000),
    }
}
