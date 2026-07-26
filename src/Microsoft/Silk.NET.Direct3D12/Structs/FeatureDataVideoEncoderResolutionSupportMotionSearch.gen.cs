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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_MOTION_SEARCH")]
    public unsafe partial struct FeatureDataVideoEncoderResolutionSupportMotionSearch
    {
        public FeatureDataVideoEncoderResolutionSupportMotionSearch
        (
            uint? maxMotionHints = null,
            uint? minDeviation = null,
            uint? maxDeviation = null,
            uint? mapSourcePreferenceRanking = null,
            VideoEncoderFrameInputMotionUnitPrecisionSupportFlags? motionUnitPrecisionSupportFlags = null,
            VideoEncoderMotionSearchSupportFlags? supportFlags = null
        ) : this()
        {
            if (maxMotionHints is not null)
            {
                MaxMotionHints = maxMotionHints.Value;
            }

            if (minDeviation is not null)
            {
                MinDeviation = minDeviation.Value;
            }

            if (maxDeviation is not null)
            {
                MaxDeviation = maxDeviation.Value;
            }

            if (mapSourcePreferenceRanking is not null)
            {
                MapSourcePreferenceRanking = mapSourcePreferenceRanking.Value;
            }

            if (motionUnitPrecisionSupportFlags is not null)
            {
                MotionUnitPrecisionSupportFlags = motionUnitPrecisionSupportFlags.Value;
            }

            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxMotionHints")]
        public uint MaxMotionHints;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinDeviation")]
        public uint MinDeviation;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxDeviation")]
        public uint MaxDeviation;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MapSourcePreferenceRanking")]
        public uint MapSourcePreferenceRanking;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION_SUPPORT_FLAGS")]
        [NativeName("Name", "MotionUnitPrecisionSupportFlags")]
        public VideoEncoderFrameInputMotionUnitPrecisionSupportFlags MotionUnitPrecisionSupportFlags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoEncoderMotionSearchSupportFlags SupportFlags;
    }
}
