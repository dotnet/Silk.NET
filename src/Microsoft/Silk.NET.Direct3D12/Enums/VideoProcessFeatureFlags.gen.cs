// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAGS")]
    public enum VideoProcessFeatureFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_NONE")]
        VideoProcessFeatureFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"AlphaFill\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_FILL")]
        VideoProcessFeatureFlagAlphaFill = 0x1,
        [Obsolete("Deprecated in favour of \"LumaKey\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_LUMA_KEY")]
        VideoProcessFeatureFlagLumaKey = 0x2,
        [Obsolete("Deprecated in favour of \"Stereo\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_STEREO")]
        VideoProcessFeatureFlagStereo = 0x4,
        [Obsolete("Deprecated in favour of \"Rotation\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_ROTATION")]
        VideoProcessFeatureFlagRotation = 0x8,
        [Obsolete("Deprecated in favour of \"Flip\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_FLIP")]
        VideoProcessFeatureFlagFlip = 0x10,
        [Obsolete("Deprecated in favour of \"AlphaBlending\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_BLENDING")]
        VideoProcessFeatureFlagAlphaBlending = 0x20,
        [Obsolete("Deprecated in favour of \"PixelAspectRatio\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_PIXEL_ASPECT_RATIO")]
        VideoProcessFeatureFlagPixelAspectRatio = 0x40,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_FILL")]
        AlphaFill = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_LUMA_KEY")]
        LumaKey = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_STEREO")]
        Stereo = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_ROTATION")]
        Rotation = 0x8,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_FLIP")]
        Flip = 0x10,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_BLENDING")]
        AlphaBlending = 0x20,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_PIXEL_ASPECT_RATIO")]
        PixelAspectRatio = 0x40,
    }
}
