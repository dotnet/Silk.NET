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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT")]
    public unsafe partial struct VideoEncoderCodecConfigurationSupport
    {
        public VideoEncoderCodecConfigurationSupport
        (
            uint? dataSize = null,
            VideoEncoderCodecConfigurationSupportUnion? anonymous = null,
            VideoEncoderCodecConfigurationSupportH264* pH264Support = null,
            VideoEncoderCodecConfigurationSupportHevc* pHEVCSupport = null,
            VideoEncoderAV1CodecConfigurationSupport* pAV1Support = null
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

            if (pH264Support is not null)
            {
                PH264Support = pH264Support;
            }

            if (pHEVCSupport is not null)
            {
                PHEVCSupport = pHEVCSupport;
            }

            if (pAV1Support is not null)
            {
                PAV1Support = pAV1Support;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L7321_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderCodecConfigurationSupportUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderCodecConfigurationSupportH264* PH264Support
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PH264Support;
        }
#else
        public VideoEncoderCodecConfigurationSupportH264* PH264Support
        {
            get => Anonymous.PH264Support;
            set => Anonymous.PH264Support = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderCodecConfigurationSupportHevc* PHEVCSupport
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PHEVCSupport;
        }
#else
        public VideoEncoderCodecConfigurationSupportHevc* PHEVCSupport
        {
            get => Anonymous.PHEVCSupport;
            set => Anonymous.PHEVCSupport = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderAV1CodecConfigurationSupport* PAV1Support
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PAV1Support;
        }
#else
        public VideoEncoderAV1CodecConfigurationSupport* PAV1Support
        {
            get => Anonymous.PAV1Support;
            set => Anonymous.PAV1Support = value;
        }
#endif

    }
}
