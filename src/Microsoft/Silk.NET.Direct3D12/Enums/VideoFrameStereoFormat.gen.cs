// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_FRAME_STEREO_FORMAT")]
    public enum VideoFrameStereoFormat : int
    {
        [NativeName("Name", "D3D12_VIDEO_FRAME_STEREO_FORMAT_NONE")]
        VideoFrameStereoFormatNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_FRAME_STEREO_FORMAT_MONO")]
        VideoFrameStereoFormatMono = 0x1,
        [NativeName("Name", "D3D12_VIDEO_FRAME_STEREO_FORMAT_HORIZONTAL")]
        VideoFrameStereoFormatHorizontal = 0x2,
        [NativeName("Name", "D3D12_VIDEO_FRAME_STEREO_FORMAT_VERTICAL")]
        VideoFrameStereoFormatVertical = 0x3,
        [NativeName("Name", "D3D12_VIDEO_FRAME_STEREO_FORMAT_SEPARATE")]
        VideoFrameStereoFormatSeparate = 0x4,
    }
}
