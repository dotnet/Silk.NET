// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAGS")]
    public enum VideoEncoderAV1ReferenceWarpedMotionTransformationFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_NONE")]
        VideoEncoderAV1ReferenceWarpedMotionTransformationFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Identity\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_IDENTITY")]
        VideoEncoderAV1ReferenceWarpedMotionTransformationFlagIdentity = 0x1,
        [Obsolete("Deprecated in favour of \"Translation\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_TRANSLATION")]
        VideoEncoderAV1ReferenceWarpedMotionTransformationFlagTranslation = 0x2,
        [Obsolete("Deprecated in favour of \"Rotzoom\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_ROTZOOM")]
        VideoEncoderAV1ReferenceWarpedMotionTransformationFlagRotzoom = 0x4,
        [Obsolete("Deprecated in favour of \"Affine\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_AFFINE")]
        VideoEncoderAV1ReferenceWarpedMotionTransformationFlagAffine = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_IDENTITY")]
        Identity = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_TRANSLATION")]
        Translation = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_ROTZOOM")]
        Rotzoom = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAG_AFFINE")]
        Affine = 0x8,
    }
}
