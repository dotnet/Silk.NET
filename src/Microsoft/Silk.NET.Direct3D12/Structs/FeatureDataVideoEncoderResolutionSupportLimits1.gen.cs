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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS1")]
    public unsafe partial struct FeatureDataVideoEncoderResolutionSupportLimits1
    {
        public FeatureDataVideoEncoderResolutionSupportLimits1
        (
            uint? maxSubregionsNumber = null,
            uint? maxIntraRefreshFrameDuration = null,
            uint? subregionBlockPixelsSize = null,
            uint? qPMapRegionPixelsSize = null,
            FeatureDataVideoEncoderResolutionSupportQpmap? qPMap = null,
            FeatureDataVideoEncoderResolutionSupportDirtyRegions? dirtyRegions = null,
            FeatureDataVideoEncoderResolutionSupportMotionSearch? motionSearch = null,
            FeatureDataVideoEncoderResolutionSupportFrameAnalysis? frameAnalysis = null
        ) : this()
        {
            if (maxSubregionsNumber is not null)
            {
                MaxSubregionsNumber = maxSubregionsNumber.Value;
            }

            if (maxIntraRefreshFrameDuration is not null)
            {
                MaxIntraRefreshFrameDuration = maxIntraRefreshFrameDuration.Value;
            }

            if (subregionBlockPixelsSize is not null)
            {
                SubregionBlockPixelsSize = subregionBlockPixelsSize.Value;
            }

            if (qPMapRegionPixelsSize is not null)
            {
                QPMapRegionPixelsSize = qPMapRegionPixelsSize.Value;
            }

            if (qPMap is not null)
            {
                QPMap = qPMap.Value;
            }

            if (dirtyRegions is not null)
            {
                DirtyRegions = dirtyRegions.Value;
            }

            if (motionSearch is not null)
            {
                MotionSearch = motionSearch.Value;
            }

            if (frameAnalysis is not null)
            {
                FrameAnalysis = frameAnalysis.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxSubregionsNumber")]
        public uint MaxSubregionsNumber;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxIntraRefreshFrameDuration")]
        public uint MaxIntraRefreshFrameDuration;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SubregionBlockPixelsSize")]
        public uint SubregionBlockPixelsSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "QPMapRegionPixelsSize")]
        public uint QPMapRegionPixelsSize;

        [NativeName("Type", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP")]
        [NativeName("Type.Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP")]
        [NativeName("Name", "QPMap")]
        public FeatureDataVideoEncoderResolutionSupportQpmap QPMap;

        [NativeName("Type", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_DIRTY_REGIONS")]
        [NativeName("Type.Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_DIRTY_REGIONS")]
        [NativeName("Name", "DirtyRegions")]
        public FeatureDataVideoEncoderResolutionSupportDirtyRegions DirtyRegions;

        [NativeName("Type", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_MOTION_SEARCH")]
        [NativeName("Type.Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_MOTION_SEARCH")]
        [NativeName("Name", "MotionSearch")]
        public FeatureDataVideoEncoderResolutionSupportMotionSearch MotionSearch;

        [NativeName("Type", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_FRAME_ANALYSIS")]
        [NativeName("Type.Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_FRAME_ANALYSIS")]
        [NativeName("Name", "FrameAnalysis")]
        public FeatureDataVideoEncoderResolutionSupportFrameAnalysis FrameAnalysis;
    }
}
