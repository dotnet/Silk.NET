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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_MOTION_SEARCH")]
    public unsafe partial struct FeatureDataVideoEncoderMotionSearch
    {
        public FeatureDataVideoEncoderMotionSearch
        (
            uint? nodeIndex = null,
            VideoEncoderInputMapSessionInfo? sessionInfo = null,
            VideoEncoderFrameMotionSearchMode? motionSearchMode = null,
            VideoEncoderInputMapSource? mapSource = null,
            Silk.NET.Core.Bool32? bidirectionalRefFrameEnabled = null,
            VideoEncoderMotionSearchSupportFlags? supportFlags = null,
            uint? maxMotionHints = null,
            uint? minDeviation = null,
            uint? maxDeviation = null,
            uint? mapSourcePreferenceRanking = null,
            VideoEncoderFrameInputMotionUnitPrecisionSupportFlags? motionUnitPrecisionSupport = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (sessionInfo is not null)
            {
                SessionInfo = sessionInfo.Value;
            }

            if (motionSearchMode is not null)
            {
                MotionSearchMode = motionSearchMode.Value;
            }

            if (mapSource is not null)
            {
                MapSource = mapSource.Value;
            }

            if (bidirectionalRefFrameEnabled is not null)
            {
                BidirectionalRefFrameEnabled = bidirectionalRefFrameEnabled.Value;
            }

            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }

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

            if (motionUnitPrecisionSupport is not null)
            {
                MotionUnitPrecisionSupport = motionUnitPrecisionSupport.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO")]
        [NativeName("Name", "SessionInfo")]
        public VideoEncoderInputMapSessionInfo SessionInfo;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE")]
        [NativeName("Name", "MotionSearchMode")]
        public VideoEncoderFrameMotionSearchMode MotionSearchMode;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE")]
        [NativeName("Name", "MapSource")]
        public VideoEncoderInputMapSource MapSource;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "BidirectionalRefFrameEnabled")]
        public Silk.NET.Core.Bool32 BidirectionalRefFrameEnabled;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_MOTION_SEARCH_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoEncoderMotionSearchSupportFlags SupportFlags;

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
        [NativeName("Name", "MotionUnitPrecisionSupport")]
        public VideoEncoderFrameInputMotionUnitPrecisionSupportFlags MotionUnitPrecisionSupport;
    }
}
