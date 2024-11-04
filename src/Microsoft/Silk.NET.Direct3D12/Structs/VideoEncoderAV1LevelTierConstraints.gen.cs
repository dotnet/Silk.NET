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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_LEVEL_TIER_CONSTRAINTS")]
    public unsafe partial struct VideoEncoderAV1LevelTierConstraints
    {
        public VideoEncoderAV1LevelTierConstraints
        (
            VideoEncoderAV1Levels? level = null,
            VideoEncoderAV1Tier? tier = null
        ) : this()
        {
            if (level is not null)
            {
                Level = level.Value;
            }

            if (tier is not null)
            {
                Tier = tier.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_LEVELS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_LEVELS")]
        [NativeName("Name", "Level")]
        public VideoEncoderAV1Levels Level;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_TIER")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_TIER")]
        [NativeName("Name", "Tier")]
        public VideoEncoderAV1Tier Tier;
    }
}
