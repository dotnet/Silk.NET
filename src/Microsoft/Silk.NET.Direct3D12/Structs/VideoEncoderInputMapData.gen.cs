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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA")]
    public unsafe partial struct VideoEncoderInputMapData
    {
        public VideoEncoderInputMapData
        (
            VideoEncoderInputMapType? mapType = null,
            VideoEncoderInputMapDataUnion? anonymous = null,
            VideoEncoderInputMapDataQuantizationMatrix? quantization = null,
            VideoEncoderInputMapDataDirtyRegions? dirtyRegions = null,
            VideoEncoderInputMapDataMotionVectors? motionVectors = null
        ) : this()
        {
            if (mapType is not null)
            {
                MapType = mapType.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (quantization is not null)
            {
                Quantization = quantization.Value;
            }

            if (dirtyRegions is not null)
            {
                DirtyRegions = dirtyRegions.Value;
            }

            if (motionVectors is not null)
            {
                MotionVectors = motionVectors.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE")]
        [NativeName("Name", "MapType")]
        public VideoEncoderInputMapType MapType;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L10281_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderInputMapDataUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderInputMapDataQuantizationMatrix Quantization
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Quantization;
        }
#else
        public VideoEncoderInputMapDataQuantizationMatrix Quantization
        {
            get => Anonymous.Quantization;
            set => Anonymous.Quantization = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderInputMapDataDirtyRegions DirtyRegions
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].DirtyRegions;
        }
#else
        public VideoEncoderInputMapDataDirtyRegions DirtyRegions
        {
            get => Anonymous.DirtyRegions;
            set => Anonymous.DirtyRegions = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderInputMapDataMotionVectors MotionVectors
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].MotionVectors;
        }
#else
        public VideoEncoderInputMapDataMotionVectors MotionVectors
        {
            get => Anonymous.MotionVectors;
            set => Anonymous.MotionVectors = value;
        }
#endif

    }
}
