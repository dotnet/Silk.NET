// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAGS")]
    public enum VideoEncoderMotionSearchSupportFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAG_NONE")]
        VideoEncoderMotionSearchSupportFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Supported\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAG_SUPPORTED")]
        VideoEncoderMotionSearchSupportFlagSupported = 0x1,
        [Obsolete("Deprecated in favour of \"MultipleHints\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAG_MULTIPLE_HINTS")]
        VideoEncoderMotionSearchSupportFlagMultipleHints = 0x2,
        [Obsolete("Deprecated in favour of \"GpuTextureMultipleReferences\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAG_GPU_TEXTURE_MULTIPLE_REFERENCES")]
        VideoEncoderMotionSearchSupportFlagGpuTextureMultipleReferences = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAG_SUPPORTED")]
        Supported = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAG_MULTIPLE_HINTS")]
        MultipleHints = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAG_GPU_TEXTURE_MULTIPLE_REFERENCES")]
        GpuTextureMultipleReferences = 0x4,
    }
}
