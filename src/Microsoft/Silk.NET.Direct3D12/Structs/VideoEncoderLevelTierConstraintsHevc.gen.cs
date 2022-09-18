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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC")]
    public unsafe partial struct VideoEncoderLevelTierConstraintsHevc
    {
        public VideoEncoderLevelTierConstraintsHevc
        (
            VideoEncoderLevelsHevc? level = null,
            VideoEncoderTierHevc? tier = null
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


        [NativeName("Type", "D3D12_VIDEO_ENCODER_LEVELS_HEVC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_LEVELS_HEVC")]
        [NativeName("Name", "Level")]
        public VideoEncoderLevelsHevc Level;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_TIER_HEVC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_TIER_HEVC")]
        [NativeName("Name", "Tier")]
        public VideoEncoderTierHevc Tier;
    }
}
