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
    [NativeName("Name", "__AnonymousRecord_d3d12_L22050_C5")]
    public unsafe partial struct BarrierGroupUnion
    {
        public BarrierGroupUnion
        (
            GlobalBarrier* pGlobalBarriers = null,
            TextureBarrier* pTextureBarriers = null,
            BufferBarrier* pBufferBarriers = null
        ) : this()
        {
            if (pGlobalBarriers is not null)
            {
                PGlobalBarriers = pGlobalBarriers;
            }

            if (pTextureBarriers is not null)
            {
                PTextureBarriers = pTextureBarriers;
            }

            if (pBufferBarriers is not null)
            {
                PBufferBarriers = pBufferBarriers;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_GLOBAL_BARRIER *")]
        [NativeName("Type.Name", "const D3D12_GLOBAL_BARRIER *")]
        [NativeName("Name", "pGlobalBarriers")]
        public GlobalBarrier* PGlobalBarriers;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_TEXTURE_BARRIER *")]
        [NativeName("Type.Name", "const D3D12_TEXTURE_BARRIER *")]
        [NativeName("Name", "pTextureBarriers")]
        public TextureBarrier* PTextureBarriers;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_BUFFER_BARRIER *")]
        [NativeName("Type.Name", "const D3D12_BUFFER_BARRIER *")]
        [NativeName("Name", "pBufferBarriers")]
        public BufferBarrier* PBufferBarriers;
    }
}
