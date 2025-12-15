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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR")]
    public unsafe partial struct VideoEncoderAV1ReferencePictureDescriptor
    {
        public VideoEncoderAV1ReferencePictureDescriptor
        (
            uint? reconstructedPictureResourceIndex = null,
            uint? temporalLayerIndexPlus1 = null,
            uint? spatialLayerIndexPlus1 = null,
            VideoEncoderAV1FrameType? frameType = null,
            VideoEncoderAV1ReferencePictureWarpedMotionInfo? warpedMotionInfo = null,
            uint? orderHint = null,
            uint? pictureIndex = null
        ) : this()
        {
            if (reconstructedPictureResourceIndex is not null)
            {
                ReconstructedPictureResourceIndex = reconstructedPictureResourceIndex.Value;
            }

            if (temporalLayerIndexPlus1 is not null)
            {
                TemporalLayerIndexPlus1 = temporalLayerIndexPlus1.Value;
            }

            if (spatialLayerIndexPlus1 is not null)
            {
                SpatialLayerIndexPlus1 = spatialLayerIndexPlus1.Value;
            }

            if (frameType is not null)
            {
                FrameType = frameType.Value;
            }

            if (warpedMotionInfo is not null)
            {
                WarpedMotionInfo = warpedMotionInfo.Value;
            }

            if (orderHint is not null)
            {
                OrderHint = orderHint.Value;
            }

            if (pictureIndex is not null)
            {
                PictureIndex = pictureIndex.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ReconstructedPictureResourceIndex")]
        public uint ReconstructedPictureResourceIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TemporalLayerIndexPlus1")]
        public uint TemporalLayerIndexPlus1;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SpatialLayerIndexPlus1")]
        public uint SpatialLayerIndexPlus1;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE")]
        [NativeName("Name", "FrameType")]
        public VideoEncoderAV1FrameType FrameType;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO")]
        [NativeName("Name", "WarpedMotionInfo")]
        public VideoEncoderAV1ReferencePictureWarpedMotionInfo WarpedMotionInfo;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OrderHint")]
        public uint OrderHint;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PictureIndex")]
        public uint PictureIndex;
    }
}
