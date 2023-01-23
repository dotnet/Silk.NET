// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT")]
    public enum VideoProcessorStereoFormat : int
    {
        [Obsolete("Deprecated in favour of \"Mono\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO")]
        VideoProcessorStereoFormatMono = 0x0,
        [Obsolete("Deprecated in favour of \"Horizontal\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_HORIZONTAL")]
        VideoProcessorStereoFormatHorizontal = 0x1,
        [Obsolete("Deprecated in favour of \"Vertical\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_VERTICAL")]
        VideoProcessorStereoFormatVertical = 0x2,
        [Obsolete("Deprecated in favour of \"Separate\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE")]
        VideoProcessorStereoFormatSeparate = 0x3,
        [Obsolete("Deprecated in favour of \"MonoOffset\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO_OFFSET")]
        VideoProcessorStereoFormatMonoOffset = 0x4,
        [Obsolete("Deprecated in favour of \"RowInterleaved\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_ROW_INTERLEAVED")]
        VideoProcessorStereoFormatRowInterleaved = 0x5,
        [Obsolete("Deprecated in favour of \"ColumnInterleaved\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_COLUMN_INTERLEAVED")]
        VideoProcessorStereoFormatColumnInterleaved = 0x6,
        [Obsolete("Deprecated in favour of \"Checkerboard\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_CHECKERBOARD")]
        VideoProcessorStereoFormatCheckerboard = 0x7,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO")]
        Mono = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_HORIZONTAL")]
        Horizontal = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_VERTICAL")]
        Vertical = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_SEPARATE")]
        Separate = 0x3,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_MONO_OFFSET")]
        MonoOffset = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_ROW_INTERLEAVED")]
        RowInterleaved = 0x5,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_COLUMN_INTERLEAVED")]
        ColumnInterleaved = 0x6,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FORMAT_CHECKERBOARD")]
        Checkerboard = 0x7,
    }
}
