// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS")]
    public enum VideoProcessDeinterlaceFlags
    {
        [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE")]
        VideoProcessDeinterlaceFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB")]
        VideoProcessDeinterlaceFlagBob = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM")]
        VideoProcessDeinterlaceFlagCustom = unchecked((int)0xFFFFFFFF80000000),
    }
}
