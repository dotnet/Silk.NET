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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
    public unsafe partial struct VideoEncoderCodecConfiguration
    {
        public VideoEncoderCodecConfiguration
        (
            uint? dataSize = null,
            VideoEncoderCodecConfigurationUnion? anonymous = null,
            VideoEncoderCodecConfigurationH264* pH264Config = null,
            VideoEncoderCodecConfigurationHevc* pHEVCConfig = null,
            VideoEncoderAV1CodecConfiguration* pAV1Config = null
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

            if (pH264Config is not null)
            {
                PH264Config = pH264Config;
            }

            if (pHEVCConfig is not null)
            {
                PHEVCConfig = pHEVCConfig;
            }

            if (pAV1Config is not null)
            {
                PAV1Config = pAV1Config;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L7452_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderCodecConfigurationUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderCodecConfigurationH264* PH264Config
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PH264Config;
        }
#else
        public VideoEncoderCodecConfigurationH264* PH264Config
        {
            get => Anonymous.PH264Config;
            set => Anonymous.PH264Config = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderCodecConfigurationHevc* PHEVCConfig
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PHEVCConfig;
        }
#else
        public VideoEncoderCodecConfigurationHevc* PHEVCConfig
        {
            get => Anonymous.PHEVCConfig;
            set => Anonymous.PHEVCConfig = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderAV1CodecConfiguration* PAV1Config
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PAV1Config;
        }
#else
        public VideoEncoderAV1CodecConfiguration* PAV1Config
        {
            get => Anonymous.PAV1Config;
            set => Anonymous.PAV1Config = value;
        }
#endif

    }
}
