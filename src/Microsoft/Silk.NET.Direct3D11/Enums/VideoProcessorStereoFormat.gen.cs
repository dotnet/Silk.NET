// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT")]
    public enum VideoProcessorStereoFormat : int
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO")]
        VideoProcessorStereoFormatMono = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_HORIZONTAL")]
        VideoProcessorStereoFormatHorizontal = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_VERTICAL")]
        VideoProcessorStereoFormatVertical = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE")]
        VideoProcessorStereoFormatSeparate = 0x3,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO_OFFSET")]
        VideoProcessorStereoFormatMonoOffset = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_ROW_INTERLEAVED")]
        VideoProcessorStereoFormatRowInterleaved = 0x5,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_COLUMN_INTERLEAVED")]
        VideoProcessorStereoFormatColumnInterleaved = 0x6,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_CHECKERBOARD")]
        VideoProcessorStereoFormatCheckerboard = 0x7,
    }
}
