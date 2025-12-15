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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS")]
    public unsafe partial struct VideoEncoderDirtyRegions
    {
        public VideoEncoderDirtyRegions
        (
            VideoEncoderInputMapSource? mapSource = null,
            VideoEncoderDirtyRegionsUnion? anonymous = null,
            ID3D12Resource* pOpaqueLayoutBuffer = null,
            VideoEncoderDirtyRectInfo* pCPUBuffer = null
        ) : this()
        {
            if (mapSource is not null)
            {
                MapSource = mapSource.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (pOpaqueLayoutBuffer is not null)
            {
                POpaqueLayoutBuffer = pOpaqueLayoutBuffer;
            }

            if (pCPUBuffer is not null)
            {
                PCPUBuffer = pCPUBuffer;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE")]
        [NativeName("Name", "MapSource")]
        public VideoEncoderInputMapSource MapSource;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L10067_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderDirtyRegionsUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ID3D12Resource* POpaqueLayoutBuffer
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].POpaqueLayoutBuffer;
        }
#else
        public ID3D12Resource* POpaqueLayoutBuffer
        {
            get => Anonymous.POpaqueLayoutBuffer;
            set => Anonymous.POpaqueLayoutBuffer = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderDirtyRectInfo* PCPUBuffer
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PCPUBuffer;
        }
#else
        public VideoEncoderDirtyRectInfo* PCPUBuffer
        {
            get => Anonymous.PCPUBuffer;
            set => Anonymous.PCPUBuffer = value;
        }
#endif

    }
}
