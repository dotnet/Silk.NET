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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_VECTORS")]
    public unsafe partial struct VideoEncoderFrameMotionVectors
    {
        public VideoEncoderFrameMotionVectors
        (
            VideoEncoderInputMapSource? mapSource = null,
            VideoEncoderFrameMotionVectorsUnion? anonymous = null,
            ID3D12Resource* pOpaqueLayoutBuffer = null,
            VideoEncoderMoveregionInfo* pCPUBuffer = null
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
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L10111_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderFrameMotionVectorsUnion Anonymous;
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
        public ref VideoEncoderMoveregionInfo* PCPUBuffer
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PCPUBuffer;
        }
#else
        public VideoEncoderMoveregionInfo* PCPUBuffer
        {
            get => Anonymous.PCPUBuffer;
            set => Anonymous.PCPUBuffer = value;
        }
#endif

    }
}
