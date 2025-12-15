// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT")]
    public unsafe partial struct VideoEncoderCodecAV1PictureControlSupport
    {
        public VideoEncoderCodecAV1PictureControlSupport
        (
            VideoEncoderAV1CompPredictionType? predictionMode = null,
            uint? maxUniqueReferencesPerFrame = null,
            VideoEncoderAV1FrameTypeFlags? supportedFrameTypes = null,
            VideoEncoderAV1ReferenceWarpedMotionTransformationFlags? supportedReferenceWarpedMotionFlags = null
        ) : this()
        {
            if (predictionMode is not null)
            {
                PredictionMode = predictionMode.Value;
            }

            if (maxUniqueReferencesPerFrame is not null)
            {
                MaxUniqueReferencesPerFrame = maxUniqueReferencesPerFrame.Value;
            }

            if (supportedFrameTypes is not null)
            {
                SupportedFrameTypes = supportedFrameTypes.Value;
            }

            if (supportedReferenceWarpedMotionFlags is not null)
            {
                SupportedReferenceWarpedMotionFlags = supportedReferenceWarpedMotionFlags.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE")]
        [NativeName("Name", "PredictionMode")]
        public VideoEncoderAV1CompPredictionType PredictionMode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxUniqueReferencesPerFrame")]
        public uint MaxUniqueReferencesPerFrame;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS")]
        [NativeName("Name", "SupportedFrameTypes")]
        public VideoEncoderAV1FrameTypeFlags SupportedFrameTypes;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAGS")]
        [NativeName("Name", "SupportedReferenceWarpedMotionFlags")]
        public VideoEncoderAV1ReferenceWarpedMotionTransformationFlags SupportedReferenceWarpedMotionFlags;
    }
}
