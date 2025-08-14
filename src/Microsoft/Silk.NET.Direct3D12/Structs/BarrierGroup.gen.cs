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
    [NativeName("Name", "D3D12_BARRIER_GROUP")]
    public unsafe partial struct BarrierGroup
    {
        public BarrierGroup
        (
            BarrierType? type = null,
            uint? numBarriers = null,
            BarrierGroupUnion? anonymous = null,
            GlobalBarrier* pGlobalBarriers = null,
            TextureBarrier* pTextureBarriers = null,
            BufferBarrier* pBufferBarriers = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (numBarriers is not null)
            {
                NumBarriers = numBarriers.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

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


        [NativeName("Type", "D3D12_BARRIER_TYPE")]
        [NativeName("Type.Name", "D3D12_BARRIER_TYPE")]
        [NativeName("Name", "Type")]
        public BarrierType Type;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "NumBarriers")]
        public uint NumBarriers;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L22050_C5")]
        [NativeName("Name", "anonymous1")]
        public BarrierGroupUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref GlobalBarrier* PGlobalBarriers
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PGlobalBarriers;
        }
#else
        public GlobalBarrier* PGlobalBarriers
        {
            get => Anonymous.PGlobalBarriers;
            set => Anonymous.PGlobalBarriers = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TextureBarrier* PTextureBarriers
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PTextureBarriers;
        }
#else
        public TextureBarrier* PTextureBarriers
        {
            get => Anonymous.PTextureBarriers;
            set => Anonymous.PTextureBarriers = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref BufferBarrier* PBufferBarriers
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PBufferBarriers;
        }
#else
        public BufferBarrier* PBufferBarriers
        {
            get => Anonymous.PBufferBarriers;
            set => Anonymous.PBufferBarriers = value;
        }
#endif

    }
}
