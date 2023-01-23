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
    [NativeName("Name", "__AnonymousRecord_d3d12video_L6740_C5")]
    public unsafe partial struct VideoEncoderCodecConfigurationUnion
    {
        public VideoEncoderCodecConfigurationUnion
        (
            VideoEncoderCodecConfigurationH264* pH264Config = null,
            VideoEncoderCodecConfigurationHevc* pHEVCConfig = null
        ) : this()
        {
            if (pH264Config is not null)
            {
                PH264Config = pH264Config;
            }

            if (pHEVCConfig is not null)
            {
                PHEVCConfig = pHEVCConfig;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264 *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264 *")]
        [NativeName("Name", "pH264Config")]
        public VideoEncoderCodecConfigurationH264* PH264Config;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC *")]
        [NativeName("Name", "pHEVCConfig")]
        public VideoEncoderCodecConfigurationHevc* PHEVCConfig;
    }
}
