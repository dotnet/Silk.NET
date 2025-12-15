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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT")]
    public unsafe partial struct FeatureDataVideoDecodeSupport
    {
        public FeatureDataVideoDecodeSupport
        (
            uint? nodeIndex = null,
            VideoDecodeConfiguration? configuration = null,
            uint? width = null,
            uint? height = null,
            Silk.NET.DXGI.Format? decodeFormat = null,
            Silk.NET.DXGI.Rational? frameRate = null,
            uint? bitRate = null,
            VideoDecodeSupportFlags? supportFlags = null,
            VideoDecodeConfigurationFlags? configurationFlags = null,
            VideoDecodeTier? decodeTier = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (configuration is not null)
            {
                Configuration = configuration.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (decodeFormat is not null)
            {
                DecodeFormat = decodeFormat.Value;
            }

            if (frameRate is not null)
            {
                FrameRate = frameRate.Value;
            }

            if (bitRate is not null)
            {
                BitRate = bitRate.Value;
            }

            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }

            if (configurationFlags is not null)
            {
                ConfigurationFlags = configurationFlags.Value;
            }

            if (decodeTier is not null)
            {
                DecodeTier = decodeTier.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Name", "Configuration")]
        public VideoDecodeConfiguration Configuration;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "DecodeFormat")]
        public Silk.NET.DXGI.Format DecodeFormat;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "FrameRate")]
        public Silk.NET.DXGI.Rational FrameRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BitRate")]
        public uint BitRate;

        [NativeName("Type", "D3D12_VIDEO_DECODE_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoDecodeSupportFlags SupportFlags;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS")]
        [NativeName("Name", "ConfigurationFlags")]
        public VideoDecodeConfigurationFlags ConfigurationFlags;

        [NativeName("Type", "D3D12_VIDEO_DECODE_TIER")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_TIER")]
        [NativeName("Name", "DecodeTier")]
        public VideoDecodeTier DecodeTier;
    }
}
