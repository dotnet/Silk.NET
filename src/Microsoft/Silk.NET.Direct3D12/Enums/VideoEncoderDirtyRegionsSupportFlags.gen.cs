// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAGS")]
    public enum VideoEncoderDirtyRegionsSupportFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAG_NONE")]
        VideoEncoderDirtyRegionsSupportFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"RepeatFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAG_REPEAT_FRAME")]
        VideoEncoderDirtyRegionsSupportFlagRepeatFrame = 0x1,
        [Obsolete("Deprecated in favour of \"DirtyRegions\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAG_DIRTY_REGIONS")]
        VideoEncoderDirtyRegionsSupportFlagDirtyRegions = 0x2,
        [Obsolete("Deprecated in favour of \"DirtyRegionsRequireFullRow\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAG_DIRTY_REGIONS_REQUIRE_FULL_ROW")]
        VideoEncoderDirtyRegionsSupportFlagDirtyRegionsRequireFullRow = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAG_REPEAT_FRAME")]
        RepeatFrame = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAG_DIRTY_REGIONS")]
        DirtyRegions = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAG_DIRTY_REGIONS_REQUIRE_FULL_ROW")]
        DirtyRegionsRequireFullRow = 0x4,
    }
}
