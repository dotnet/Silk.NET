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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS")]
    public unsafe partial struct VideoEncoderRateControlConfigurationParams
    {
        public VideoEncoderRateControlConfigurationParams
        (
            uint? dataSize = null,
            VideoEncoderRateControlConfigurationParamsUnion? anonymous = null,
            VideoEncoderRateControlCqp* pConfigurationCQP = null,
            VideoEncoderRateControlCbr* pConfigurationCBR = null,
            VideoEncoderRateControlVbr* pConfigurationVBR = null,
            VideoEncoderRateControlQvbr* pConfigurationQVBR = null,
            VideoEncoderRateControlCqp1* pConfigurationCQP1 = null,
            VideoEncoderRateControlCbr1* pConfigurationCBR1 = null,
            VideoEncoderRateControlVbr1* pConfigurationVBR1 = null,
            VideoEncoderRateControlQvbr1* pConfigurationQVBR1 = null,
            VideoEncoderRateControlAbsoluteQPMap* pConfigurationAbsoluteQPMap = null
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

            if (pConfigurationCQP is not null)
            {
                PConfigurationCQP = pConfigurationCQP;
            }

            if (pConfigurationCBR is not null)
            {
                PConfigurationCBR = pConfigurationCBR;
            }

            if (pConfigurationVBR is not null)
            {
                PConfigurationVBR = pConfigurationVBR;
            }

            if (pConfigurationQVBR is not null)
            {
                PConfigurationQVBR = pConfigurationQVBR;
            }

            if (pConfigurationCQP1 is not null)
            {
                PConfigurationCQP1 = pConfigurationCQP1;
            }

            if (pConfigurationCBR1 is not null)
            {
                PConfigurationCBR1 = pConfigurationCBR1;
            }

            if (pConfigurationVBR1 is not null)
            {
                PConfigurationVBR1 = pConfigurationVBR1;
            }

            if (pConfigurationQVBR1 is not null)
            {
                PConfigurationQVBR1 = pConfigurationQVBR1;
            }

            if (pConfigurationAbsoluteQPMap is not null)
            {
                PConfigurationAbsoluteQPMap = pConfigurationAbsoluteQPMap;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L6919_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderRateControlConfigurationParamsUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderRateControlCqp* PConfigurationCQP
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PConfigurationCQP;
        }
#else
        public VideoEncoderRateControlCqp* PConfigurationCQP
        {
            get => Anonymous.PConfigurationCQP;
            set => Anonymous.PConfigurationCQP = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderRateControlCbr* PConfigurationCBR
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PConfigurationCBR;
        }
#else
        public VideoEncoderRateControlCbr* PConfigurationCBR
        {
            get => Anonymous.PConfigurationCBR;
            set => Anonymous.PConfigurationCBR = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderRateControlVbr* PConfigurationVBR
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PConfigurationVBR;
        }
#else
        public VideoEncoderRateControlVbr* PConfigurationVBR
        {
            get => Anonymous.PConfigurationVBR;
            set => Anonymous.PConfigurationVBR = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderRateControlQvbr* PConfigurationQVBR
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PConfigurationQVBR;
        }
#else
        public VideoEncoderRateControlQvbr* PConfigurationQVBR
        {
            get => Anonymous.PConfigurationQVBR;
            set => Anonymous.PConfigurationQVBR = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderRateControlCqp1* PConfigurationCQP1
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PConfigurationCQP1;
        }
#else
        public VideoEncoderRateControlCqp1* PConfigurationCQP1
        {
            get => Anonymous.PConfigurationCQP1;
            set => Anonymous.PConfigurationCQP1 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderRateControlCbr1* PConfigurationCBR1
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PConfigurationCBR1;
        }
#else
        public VideoEncoderRateControlCbr1* PConfigurationCBR1
        {
            get => Anonymous.PConfigurationCBR1;
            set => Anonymous.PConfigurationCBR1 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderRateControlVbr1* PConfigurationVBR1
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PConfigurationVBR1;
        }
#else
        public VideoEncoderRateControlVbr1* PConfigurationVBR1
        {
            get => Anonymous.PConfigurationVBR1;
            set => Anonymous.PConfigurationVBR1 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderRateControlQvbr1* PConfigurationQVBR1
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PConfigurationQVBR1;
        }
#else
        public VideoEncoderRateControlQvbr1* PConfigurationQVBR1
        {
            get => Anonymous.PConfigurationQVBR1;
            set => Anonymous.PConfigurationQVBR1 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderRateControlAbsoluteQPMap* PConfigurationAbsoluteQPMap
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PConfigurationAbsoluteQPMap;
        }
#else
        public VideoEncoderRateControlAbsoluteQPMap* PConfigurationAbsoluteQPMap
        {
            get => Anonymous.PConfigurationAbsoluteQPMap;
            set => Anonymous.PConfigurationAbsoluteQPMap = value;
        }
#endif

    }
}
