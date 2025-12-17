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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12video_L10067_C5")]
    public unsafe partial struct VideoEncoderDirtyRegionsUnion
    {
        public VideoEncoderDirtyRegionsUnion
        (
            ID3D12Resource* pOpaqueLayoutBuffer = null,
            VideoEncoderDirtyRectInfo* pCPUBuffer = null
        ) : this()
        {
            if (pOpaqueLayoutBuffer is not null)
            {
                POpaqueLayoutBuffer = pOpaqueLayoutBuffer;
            }

            if (pCPUBuffer is not null)
            {
                PCPUBuffer = pCPUBuffer;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pOpaqueLayoutBuffer")]
        public ID3D12Resource* POpaqueLayoutBuffer;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO *")]
        [NativeName("Name", "pCPUBuffer")]
        public VideoEncoderDirtyRectInfo* PCPUBuffer;
    }
}
