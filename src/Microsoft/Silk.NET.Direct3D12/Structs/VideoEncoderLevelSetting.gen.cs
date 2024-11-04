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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_LEVEL_SETTING")]
    public unsafe partial struct VideoEncoderLevelSetting
    {
        public VideoEncoderLevelSetting
        (
            uint? dataSize = null,
            VideoEncoderLevelSettingUnion? anonymous = null,
            VideoEncoderLevelsH264* pH264LevelSetting = null,
            VideoEncoderLevelTierConstraintsHevc* pHEVCLevelSetting = null,
            VideoEncoderAV1LevelTierConstraints* pAV1LevelSetting = null
        ) : this()
        {
            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (pH264LevelSetting is not null)
            {
                PH264LevelSetting = pH264LevelSetting;
            }

            if (pHEVCLevelSetting is not null)
            {
                PHEVCLevelSetting = pHEVCLevelSetting;
            }

            if (pAV1LevelSetting is not null)
            {
                PAV1LevelSetting = pAV1LevelSetting;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L7041_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderLevelSettingUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderLevelsH264* PH264LevelSetting
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PH264LevelSetting;
        }
#else
        public VideoEncoderLevelsH264* PH264LevelSetting
        {
            get => Anonymous.PH264LevelSetting;
            set => Anonymous.PH264LevelSetting = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderLevelTierConstraintsHevc* PHEVCLevelSetting
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PHEVCLevelSetting;
        }
#else
        public VideoEncoderLevelTierConstraintsHevc* PHEVCLevelSetting
        {
            get => Anonymous.PHEVCLevelSetting;
            set => Anonymous.PHEVCLevelSetting = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderAV1LevelTierConstraints* PAV1LevelSetting
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PAV1LevelSetting;
        }
#else
        public VideoEncoderAV1LevelTierConstraints* PAV1LevelSetting
        {
            get => Anonymous.PAV1LevelSetting;
            set => Anonymous.PAV1LevelSetting = value;
        }
#endif

    }
}
