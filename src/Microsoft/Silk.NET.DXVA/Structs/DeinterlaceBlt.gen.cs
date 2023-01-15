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
    [NativeName("Name", "_DXVA_DeinterlaceBlt")]
    public unsafe partial struct DeinterlaceBlt
    {
        public DeinterlaceBlt
        (
            uint? size = null,
            uint? reserved = null,
            long? rtTarget = null,
            Silk.NET.Maths.Box2D<int>? dstRect = null,
            Silk.NET.Maths.Box2D<int>? srcRect = null,
            uint? numSourceSurfaces = null,
            float? alpha = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }

            if (rtTarget is not null)
            {
                RtTarget = rtTarget.Value;
            }

            if (dstRect is not null)
            {
                DstRect = dstRect.Value;
            }

            if (srcRect is not null)
            {
                SrcRect = srcRect.Value;
            }

            if (numSourceSurfaces is not null)
            {
                NumSourceSurfaces = numSourceSurfaces.Value;
            }

            if (alpha is not null)
            {
                Alpha = alpha.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Reserved")]
        public uint Reserved;

        [NativeName("Type", "REFERENCE_TIME")]
        [NativeName("Type.Name", "REFERENCE_TIME")]
        [NativeName("Name", "rtTarget")]
        public long RtTarget;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "DstRect")]
        public Silk.NET.Maths.Box2D<int> DstRect;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "SrcRect")]
        public Silk.NET.Maths.Box2D<int> SrcRect;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumSourceSurfaces")]
        public uint NumSourceSurfaces;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Alpha")]
        public float Alpha;
        
        [NativeName("Type", "DXVA_VideoSample[32]")]
        [NativeName("Type.Name", "DXVA_VideoSample[32]")]
        [NativeName("Name", "Source")]
        public SourceBuffer Source;

        public struct SourceBuffer
        {
            public VideoSample Element0;
            public VideoSample Element1;
            public VideoSample Element2;
            public VideoSample Element3;
            public VideoSample Element4;
            public VideoSample Element5;
            public VideoSample Element6;
            public VideoSample Element7;
            public VideoSample Element8;
            public VideoSample Element9;
            public VideoSample Element10;
            public VideoSample Element11;
            public VideoSample Element12;
            public VideoSample Element13;
            public VideoSample Element14;
            public VideoSample Element15;
            public VideoSample Element16;
            public VideoSample Element17;
            public VideoSample Element18;
            public VideoSample Element19;
            public VideoSample Element20;
            public VideoSample Element21;
            public VideoSample Element22;
            public VideoSample Element23;
            public VideoSample Element24;
            public VideoSample Element25;
            public VideoSample Element26;
            public VideoSample Element27;
            public VideoSample Element28;
            public VideoSample Element29;
            public VideoSample Element30;
            public VideoSample Element31;
            public ref VideoSample this[int index]
            {
                get
                {
                    if (index > 31 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoSample* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoSample> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 32);
#endif
        }

    }
}
