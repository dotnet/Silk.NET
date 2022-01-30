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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264")]
    public unsafe partial struct VideoEncoderCodecConfigurationSupportH264
    {
        public VideoEncoderCodecConfigurationSupportH264
        (
            VideoEncoderCodecConfigurationSupportH264Flags? supportFlags = null,
            VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlags? disableDeblockingFilterSupportedModes = null
        ) : this()
        {
            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }

            if (disableDeblockingFilterSupportedModes is not null)
            {
                DisableDeblockingFilterSupportedModes = disableDeblockingFilterSupportedModes.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoEncoderCodecConfigurationSupportH264Flags SupportFlags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_SLICES_DEBLOCKING_MODE_FLAGS")]
        [NativeName("Name", "DisableDeblockingFilterSupportedModes")]
        public VideoEncoderCodecConfigurationH264SlicesDeblockingModeFlags DisableDeblockingFilterSupportedModes;
    }
}
