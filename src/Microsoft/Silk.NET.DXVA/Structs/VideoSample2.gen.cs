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
    [NativeName("Name", "_DXVA_VideoSample2")]
    public unsafe partial struct VideoSample2
    {
        public VideoSample2
        (
            long? rtStart = null,
            long? rtEnd = null,
            uint? sampleFormat = null,
            uint? sampleFlags = null,
            void* lpDDSSrcSurface = null,
            Silk.NET.Maths.Box2D<int>? rcSrc = null,
            Silk.NET.Maths.Box2D<int>? rcDst = null
        ) : this()
        {
            if (rtStart is not null)
            {
                RtStart = rtStart.Value;
            }

            if (rtEnd is not null)
            {
                RtEnd = rtEnd.Value;
            }

            if (sampleFormat is not null)
            {
                SampleFormat = sampleFormat.Value;
            }

            if (sampleFlags is not null)
            {
                SampleFlags = sampleFlags.Value;
            }

            if (lpDDSSrcSurface is not null)
            {
                LpDDSSrcSurface = lpDDSSrcSurface;
            }

            if (rcSrc is not null)
            {
                RcSrc = rcSrc.Value;
            }

            if (rcDst is not null)
            {
                RcDst = rcDst.Value;
            }
        }


        [NativeName("Type", "REFERENCE_TIME")]
        [NativeName("Type.Name", "REFERENCE_TIME")]
        [NativeName("Name", "rtStart")]
        public long RtStart;

        [NativeName("Type", "REFERENCE_TIME")]
        [NativeName("Type.Name", "REFERENCE_TIME")]
        [NativeName("Name", "rtEnd")]
        public long RtEnd;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SampleFormat")]
        public uint SampleFormat;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SampleFlags")]
        public uint SampleFlags;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "lpDDSSrcSurface")]
        public void* LpDDSSrcSurface;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "rcSrc")]
        public Silk.NET.Maths.Box2D<int> RcSrc;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "rcDst")]
        public Silk.NET.Maths.Box2D<int> RcDst;
        
        [NativeName("Type", "DXVA_AYUVsample2[16]")]
        [NativeName("Type.Name", "DXVA_AYUVsample2[16]")]
        [NativeName("Name", "Palette")]
        public PaletteBuffer Palette;

        public struct PaletteBuffer
        {
            public AYUVsample2 Element0;
            public AYUVsample2 Element1;
            public AYUVsample2 Element2;
            public AYUVsample2 Element3;
            public AYUVsample2 Element4;
            public AYUVsample2 Element5;
            public AYUVsample2 Element6;
            public AYUVsample2 Element7;
            public AYUVsample2 Element8;
            public AYUVsample2 Element9;
            public AYUVsample2 Element10;
            public AYUVsample2 Element11;
            public AYUVsample2 Element12;
            public AYUVsample2 Element13;
            public AYUVsample2 Element14;
            public AYUVsample2 Element15;
            public ref AYUVsample2 this[int index]
            {
                get
                {
                    if (index > 15 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (AYUVsample2* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<AYUVsample2> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 16);
#endif
        }

    }
}
