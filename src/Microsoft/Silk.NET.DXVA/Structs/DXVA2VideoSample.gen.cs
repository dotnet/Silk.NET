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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_VideoSample")]
    public unsafe partial struct DXVA2VideoSample
    {
        public DXVA2VideoSample
        (
            long? start = null,
            long? end = null,
            DXVA2ExtendedFormat? sampleFormat = null,
            Silk.NET.Direct3D9.IDirect3DSurface9* srcSurface = null,
            Silk.NET.Maths.Box2D<int>? srcRect = null,
            Silk.NET.Maths.Box2D<int>? dstRect = null,
            DXVA2Fixed32? planarAlpha = null,
            uint? sampleData = null
        ) : this()
        {
            if (start is not null)
            {
                Start = start.Value;
            }

            if (end is not null)
            {
                End = end.Value;
            }

            if (sampleFormat is not null)
            {
                SampleFormat = sampleFormat.Value;
            }

            if (srcSurface is not null)
            {
                SrcSurface = srcSurface;
            }

            if (srcRect is not null)
            {
                SrcRect = srcRect.Value;
            }

            if (dstRect is not null)
            {
                DstRect = dstRect.Value;
            }

            if (planarAlpha is not null)
            {
                PlanarAlpha = planarAlpha.Value;
            }

            if (sampleData is not null)
            {
                SampleData = sampleData.Value;
            }
        }


        [NativeName("Type", "REFERENCE_TIME")]
        [NativeName("Type.Name", "REFERENCE_TIME")]
        [NativeName("Name", "Start")]
        public long Start;

        [NativeName("Type", "REFERENCE_TIME")]
        [NativeName("Type.Name", "REFERENCE_TIME")]
        [NativeName("Name", "End")]
        public long End;

        [NativeName("Type", "DXVA2_ExtendedFormat")]
        [NativeName("Type.Name", "DXVA2_ExtendedFormat")]
        [NativeName("Name", "SampleFormat")]
        public DXVA2ExtendedFormat SampleFormat;

        [NativeName("Type", "IDirect3DSurface9 *")]
        [NativeName("Type.Name", "IDirect3DSurface9 *")]
        [NativeName("Name", "SrcSurface")]
        public Silk.NET.Direct3D9.IDirect3DSurface9* SrcSurface;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "SrcRect")]
        public Silk.NET.Maths.Box2D<int> SrcRect;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "DstRect")]
        public Silk.NET.Maths.Box2D<int> DstRect;
        
        [NativeName("Type", "DXVA2_AYUVSample8[16]")]
        [NativeName("Type.Name", "DXVA2_AYUVSample8[16]")]
        [NativeName("Name", "Pal")]
        public PalBuffer Pal;

        public struct PalBuffer
        {
            public DXVA2AYUVSample8 Element0;
            public DXVA2AYUVSample8 Element1;
            public DXVA2AYUVSample8 Element2;
            public DXVA2AYUVSample8 Element3;
            public DXVA2AYUVSample8 Element4;
            public DXVA2AYUVSample8 Element5;
            public DXVA2AYUVSample8 Element6;
            public DXVA2AYUVSample8 Element7;
            public DXVA2AYUVSample8 Element8;
            public DXVA2AYUVSample8 Element9;
            public DXVA2AYUVSample8 Element10;
            public DXVA2AYUVSample8 Element11;
            public DXVA2AYUVSample8 Element12;
            public DXVA2AYUVSample8 Element13;
            public DXVA2AYUVSample8 Element14;
            public DXVA2AYUVSample8 Element15;
            public ref DXVA2AYUVSample8 this[int index]
            {
                get
                {
                    if (index > 15 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (DXVA2AYUVSample8* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<DXVA2AYUVSample8> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 16);
#endif
        }


        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "PlanarAlpha")]
        public DXVA2Fixed32 PlanarAlpha;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SampleData")]
        public uint SampleData;
    }
}
