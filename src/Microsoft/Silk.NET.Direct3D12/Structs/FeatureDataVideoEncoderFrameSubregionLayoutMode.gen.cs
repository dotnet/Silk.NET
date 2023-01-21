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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
    public unsafe partial struct FeatureDataVideoEncoderFrameSubregionLayoutMode
    {
        public FeatureDataVideoEncoderFrameSubregionLayoutMode
        (
            uint? nodeIndex = null,
            VideoEncoderCodec? codec = null,
            VideoEncoderProfileDesc? profile = null,
            VideoEncoderLevelSetting? level = null,
            VideoEncoderFrameSubregionLayoutMode? subregionMode = null,
            Silk.NET.Core.Bool32? isSupported = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (codec is not null)
            {
                Codec = codec.Value;
            }

            if (profile is not null)
            {
                Profile = profile.Value;
            }

            if (level is not null)
            {
                Level = level.Value;
            }

            if (subregionMode is not null)
            {
                SubregionMode = subregionMode.Value;
            }

            if (isSupported is not null)
            {
                IsSupported = isSupported.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Name", "Codec")]
        public VideoEncoderCodec Codec;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Name", "Profile")]
        public VideoEncoderProfileDesc Profile;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_LEVEL_SETTING")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_LEVEL_SETTING")]
        [NativeName("Name", "Level")]
        public VideoEncoderLevelSetting Level;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        [NativeName("Name", "SubregionMode")]
        public VideoEncoderFrameSubregionLayoutMode SubregionMode;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IsSupported")]
        public Silk.NET.Core.Bool32 IsSupported;
    }
}
