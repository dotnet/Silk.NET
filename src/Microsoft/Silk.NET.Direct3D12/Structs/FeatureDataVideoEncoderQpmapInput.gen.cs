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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_QPMAP_INPUT")]
    public unsafe partial struct FeatureDataVideoEncoderQpmapInput
    {
        public FeatureDataVideoEncoderQpmapInput
        (
            uint? nodeIndex = null,
            VideoEncoderInputMapSessionInfo? sessionInfo = null,
            VideoEncoderInputMapSource? mapSource = null,
            Silk.NET.Core.Bool32? isSupported = null,
            uint? mapSourcePreferenceRanking = null,
            uint? blockSize = null
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

            if (isSupported is not null)
            {
                IsSupported = isSupported.Value;
            }

            if (mapSourcePreferenceRanking is not null)
            {
                MapSourcePreferenceRanking = mapSourcePreferenceRanking.Value;
            }

            if (blockSize is not null)
            {
                BlockSize = blockSize.Value;
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

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IsSupported")]
        public Silk.NET.Core.Bool32 IsSupported;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MapSourcePreferenceRanking")]
        public uint MapSourcePreferenceRanking;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BlockSize")]
        public uint BlockSize;
    }
}
