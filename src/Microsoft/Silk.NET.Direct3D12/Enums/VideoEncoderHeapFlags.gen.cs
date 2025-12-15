// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAGS")]
    public enum VideoEncoderHeapFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_NONE")]
        VideoEncoderHeapFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"AllowSubregionNotificationArrayOfBuffers\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_ALLOW_SUBREGION_NOTIFICATION_ARRAY_OF_BUFFERS")]
        VideoEncoderHeapFlagAllowSubregionNotificationArrayOfBuffers = 0x1,
        [Obsolete("Deprecated in favour of \"AllowSubregionNotificationSingleBuffer\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_ALLOW_SUBREGION_NOTIFICATION_SINGLE_BUFFER")]
        VideoEncoderHeapFlagAllowSubregionNotificationSingleBuffer = 0x2,
        [Obsolete("Deprecated in favour of \"AllowDirtyRegions\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_ALLOW_DIRTY_REGIONS")]
        VideoEncoderHeapFlagAllowDirtyRegions = 0x4,
        [Obsolete("Deprecated in favour of \"AllowRateControlFrameAnalysis\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_ALLOW_RATE_CONTROL_FRAME_ANALYSIS")]
        VideoEncoderHeapFlagAllowRateControlFrameAnalysis = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_ALLOW_SUBREGION_NOTIFICATION_ARRAY_OF_BUFFERS")]
        AllowSubregionNotificationArrayOfBuffers = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_ALLOW_SUBREGION_NOTIFICATION_SINGLE_BUFFER")]
        AllowSubregionNotificationSingleBuffer = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_ALLOW_DIRTY_REGIONS")]
        AllowDirtyRegions = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_FLAG_ALLOW_RATE_CONTROL_FRAME_ANALYSIS")]
        AllowRateControlFrameAnalysis = 0x8,
    }
}
