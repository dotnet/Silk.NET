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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12video_L6390_C5")]
    public unsafe partial struct VideoEncoderLevelSettingUnion
    {
        public VideoEncoderLevelSettingUnion
        (
            VideoEncoderLevelsH264* pH264LevelSetting = null,
            VideoEncoderLevelTierConstraintsHevc* pHEVCLevelSetting = null
        ) : this()
        {
            if (pH264LevelSetting is not null)
            {
                PH264LevelSetting = pH264LevelSetting;
            }

            if (pHEVCLevelSetting is not null)
            {
                PHEVCLevelSetting = pHEVCLevelSetting;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_LEVELS_H264 *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_LEVELS_H264 *")]
        [NativeName("Name", "pH264LevelSetting")]
        public VideoEncoderLevelsH264* PH264LevelSetting;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC *")]
        [NativeName("Name", "pHEVCLevelSetting")]
        public VideoEncoderLevelTierConstraintsHevc* PHEVCLevelSetting;
    }
}
