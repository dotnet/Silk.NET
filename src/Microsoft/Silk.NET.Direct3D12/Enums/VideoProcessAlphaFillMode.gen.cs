// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE")]
    public enum VideoProcessAlphaFillMode
    {
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_OPAQUE")]
        VideoProcessAlphaFillModeOpaque = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_BACKGROUND")]
        VideoProcessAlphaFillModeBackground = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_DESTINATION")]
        VideoProcessAlphaFillModeDestination = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_SOURCE_STREAM")]
        VideoProcessAlphaFillModeSourceStream = 0x3,
    }
}
