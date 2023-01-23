// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS")]
    public enum VideoProcessorStereoCaps : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"MonoOffset\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_MONO_OFFSET")]
        VideoProcessorStereoCapsMonoOffset = 0x1,
        [Obsolete("Deprecated in favour of \"RowInterleaved\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_ROW_INTERLEAVED")]
        VideoProcessorStereoCapsRowInterleaved = 0x2,
        [Obsolete("Deprecated in favour of \"ColumnInterleaved\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_COLUMN_INTERLEAVED")]
        VideoProcessorStereoCapsColumnInterleaved = 0x4,
        [Obsolete("Deprecated in favour of \"Checkerboard\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_CHECKERBOARD")]
        VideoProcessorStereoCapsCheckerboard = 0x8,
        [Obsolete("Deprecated in favour of \"FlipMode\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_FLIP_MODE")]
        VideoProcessorStereoCapsFlipMode = 0x10,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_MONO_OFFSET")]
        MonoOffset = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_ROW_INTERLEAVED")]
        RowInterleaved = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_COLUMN_INTERLEAVED")]
        ColumnInterleaved = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_CHECKERBOARD")]
        Checkerboard = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_CAPS_FLIP_MODE")]
        FlipMode = 0x10,
    }
}
