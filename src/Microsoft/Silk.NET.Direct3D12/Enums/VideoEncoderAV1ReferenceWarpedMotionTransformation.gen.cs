// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION")]
    public enum VideoEncoderAV1ReferenceWarpedMotionTransformation : int
    {
        [Obsolete("Deprecated in favour of \"Identity\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_IDENTITY")]
        VideoEncoderAV1ReferenceWarpedMotionTransformationIdentity = 0x0,
        [Obsolete("Deprecated in favour of \"Translation\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_TRANSLATION")]
        VideoEncoderAV1ReferenceWarpedMotionTransformationTranslation = 0x1,
        [Obsolete("Deprecated in favour of \"Rotzoom\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_ROTZOOM")]
        VideoEncoderAV1ReferenceWarpedMotionTransformationRotzoom = 0x2,
        [Obsolete("Deprecated in favour of \"Affine\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_AFFINE")]
        VideoEncoderAV1ReferenceWarpedMotionTransformationAffine = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_IDENTITY")]
        Identity = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_TRANSLATION")]
        Translation = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_ROTZOOM")]
        Rotzoom = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_AFFINE")]
        Affine = 0x3,
    }
}
