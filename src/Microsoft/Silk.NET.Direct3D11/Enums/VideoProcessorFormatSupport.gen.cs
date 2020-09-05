// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT")]
    public enum VideoProcessorFormatSupport
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT_INPUT")]
        VideoProcessorFormatSupportInput = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FORMAT_SUPPORT_OUTPUT")]
        VideoProcessorFormatSupportOutput = 0x2,
    }
}
