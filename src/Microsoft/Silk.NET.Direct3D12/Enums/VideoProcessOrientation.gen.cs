// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION")]
    public enum VideoProcessOrientation : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_DEFAULT")]
        VideoProcessOrientationDefault = 0x0,
        [Obsolete("Deprecated in favour of \"FlipHorizontal\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_HORIZONTAL")]
        VideoProcessOrientationFlipHorizontal = 0x1,
        [Obsolete("Deprecated in favour of \"Clockwise90\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90")]
        VideoProcessOrientationClockwise90 = 0x2,
        [Obsolete("Deprecated in favour of \"Clockwise90FlipHorizontal\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90_FLIP_HORIZONTAL")]
        VideoProcessOrientationClockwise90FlipHorizontal = 0x3,
        [Obsolete("Deprecated in favour of \"Clockwise180\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_180")]
        VideoProcessOrientationClockwise180 = 0x4,
        [Obsolete("Deprecated in favour of \"FlipVertical\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_VERTICAL")]
        VideoProcessOrientationFlipVertical = 0x5,
        [Obsolete("Deprecated in favour of \"Clockwise270\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270")]
        VideoProcessOrientationClockwise270 = 0x6,
        [Obsolete("Deprecated in favour of \"Clockwise270FlipHorizontal\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270_FLIP_HORIZONTAL")]
        VideoProcessOrientationClockwise270FlipHorizontal = 0x7,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_HORIZONTAL")]
        FlipHorizontal = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90")]
        Clockwise90 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90_FLIP_HORIZONTAL")]
        Clockwise90FlipHorizontal = 0x3,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_180")]
        Clockwise180 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_VERTICAL")]
        FlipVertical = 0x5,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270")]
        Clockwise270 = 0x6,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270_FLIP_HORIZONTAL")]
        Clockwise270FlipHorizontal = 0x7,
    }
}
