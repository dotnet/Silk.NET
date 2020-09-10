// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            uint nodeIndex = default,
            VideoDecodeConfiguration configuration = default,
            uint width = default,
            uint height = default,
            Silk.NET.DXGI.Format decodeFormat = default,
            Silk.NET.DXGI.Rational frameRate = default,
            uint bitRate = default,
            VideoDecodeSupportFlags supportFlags = default,
            VideoDecodeConfigurationFlags configurationFlags = default,
            VideoDecodeTier decodeTier = default
        )
        {
            NodeIndex = nodeIndex;
            Configuration = configuration;
            Width = width;
            Height = height;
            DecodeFormat = decodeFormat;
            FrameRate = frameRate;
            BitRate = bitRate;
            SupportFlags = supportFlags;
            ConfigurationFlags = configurationFlags;
            DecodeTier = decodeTier;
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
