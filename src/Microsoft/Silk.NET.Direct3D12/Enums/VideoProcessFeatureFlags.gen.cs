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
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_NONE")]
        VideoProcessFeatureFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_FILL")]
        VideoProcessFeatureFlagAlphaFill = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_LUMA_KEY")]
        VideoProcessFeatureFlagLumaKey = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_STEREO")]
        VideoProcessFeatureFlagStereo = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_ROTATION")]
        VideoProcessFeatureFlagRotation = 0x8,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_FLIP")]
        VideoProcessFeatureFlagFlip = 0x10,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_BLENDING")]
        VideoProcessFeatureFlagAlphaBlending = 0x20,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAG_PIXEL_ASPECT_RATIO")]
        VideoProcessFeatureFlagPixelAspectRatio = 0x40,
    }
}
