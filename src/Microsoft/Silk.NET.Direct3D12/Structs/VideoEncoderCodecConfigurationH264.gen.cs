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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264")]
    public unsafe partial struct VideoEncoderCodecConfigurationH264
    {
        public VideoEncoderCodecConfigurationH264
        (
            VideoEncoderCodecConfigurationH264Flags? configurationFlags = null,
            VideoEncoderCodecConfigurationH264DirectModes? directModeConfig = null,
            VideoEncoderCodecConfigurationH264SlicesDeblockingModes? disableDeblockingFilterConfig = null
        ) : this()
        {
            if (configurationFlags is not null)
            {
                ConfigurationFlags = configurationFlags.Value;
            }

            if (directModeConfig is not null)
            {
                DirectModeConfig = directModeConfig.Value;
            }

            if (disableDeblockingFilterConfig is not null)
            {
                DisableDeblockingFilterConfig = disableDeblockingFilterConfig.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS")]
        [NativeName("Name", "ConfigurationFlags")]
        public VideoEncoderCodecConfigurationH264Flags ConfigurationFlags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES")]
        [NativeName("Name", "DirectModeConfig")]
        public VideoEncoderCodecConfigurationH264DirectModes DirectModeConfig;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODES")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODES")]
        [NativeName("Name", "DisableDeblockingFilterConfig")]
        public VideoEncoderCodecConfigurationH264SlicesDeblockingModes DisableDeblockingFilterConfig;
    }
}
