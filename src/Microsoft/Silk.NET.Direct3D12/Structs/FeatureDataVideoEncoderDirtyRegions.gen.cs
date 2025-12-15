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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_DIRTY_REGIONS")]
    public unsafe partial struct FeatureDataVideoEncoderDirtyRegions
    {
        public FeatureDataVideoEncoderDirtyRegions
        (
            uint? nodeIndex = null,
            VideoEncoderInputMapSessionInfo? sessionInfo = null,
            VideoEncoderInputMapSource? mapSource = null,
            VideoEncoderDirtyRegionsMapValuesMode? mapValuesType = null,
            VideoEncoderDirtyRegionsSupportFlags? supportFlags = null,
            uint? mapSourcePreferenceRanking = null
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

            if (mapSource is not null)
            {
                MapSource = mapSource.Value;
            }

            if (mapValuesType is not null)
            {
                MapValuesType = mapValuesType.Value;
            }

            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }

            if (mapSourcePreferenceRanking is not null)
            {
                MapSourcePreferenceRanking = mapSourcePreferenceRanking.Value;
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

        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE")]
        [NativeName("Name", "MapSource")]
        public VideoEncoderInputMapSource MapSource;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE")]
        [NativeName("Name", "MapValuesType")]
        public VideoEncoderDirtyRegionsMapValuesMode MapValuesType;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoEncoderDirtyRegionsSupportFlags SupportFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MapSourcePreferenceRanking")]
        public uint MapSourcePreferenceRanking;
    }
}
