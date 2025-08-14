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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO")]
    public unsafe partial struct VideoEncoderAV1ReferencePictureWarpedMotionInfo
    {
        public VideoEncoderAV1ReferencePictureWarpedMotionInfo
        (
            VideoEncoderAV1ReferenceWarpedMotionTransformation? transformationType = null,
            Silk.NET.Core.Bool32? invalidAffineSet = null
        ) : this()
        {
            if (transformationType is not null)
            {
                TransformationType = transformationType.Value;
            }

            if (invalidAffineSet is not null)
            {
                InvalidAffineSet = invalidAffineSet.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION")]
        [NativeName("Name", "TransformationType")]
        public VideoEncoderAV1ReferenceWarpedMotionTransformation TransformationType;
        [NativeName("Type", "INT[8]")]
        [NativeName("Type.Name", "INT[8]")]
        [NativeName("Name", "TransformationMatrix")]
        public fixed int TransformationMatrix[8];

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "InvalidAffineSet")]
        public Silk.NET.Core.Bool32 InvalidAffineSet;
    }
}
