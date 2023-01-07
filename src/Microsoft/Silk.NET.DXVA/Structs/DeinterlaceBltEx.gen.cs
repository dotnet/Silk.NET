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
    [NativeName("Name", "_DXVA_DeinterlaceBltEx")]
    public unsafe partial struct DeinterlaceBltEx
    {
        public DeinterlaceBltEx
        (
            uint? size = null,
            AYUVsample2? backgroundColor = null,
            Silk.NET.Maths.Box2D<int>? rcTarget = null,
            long? rtTarget = null,
            uint? numSourceSurfaces = null,
            float? alpha = null,
            uint? destinationFormat = null,
            uint? destinationFlags = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (backgroundColor is not null)
            {
                BackgroundColor = backgroundColor.Value;
            }

            if (rcTarget is not null)
            {
                RcTarget = rcTarget.Value;
            }

            if (rtTarget is not null)
            {
                RtTarget = rtTarget.Value;
            }

            if (numSourceSurfaces is not null)
            {
                NumSourceSurfaces = numSourceSurfaces.Value;
            }

            if (alpha is not null)
            {
                Alpha = alpha.Value;
            }

            if (destinationFormat is not null)
            {
                DestinationFormat = destinationFormat.Value;
            }

            if (destinationFlags is not null)
            {
                DestinationFlags = destinationFlags.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "DXVA_AYUVsample2")]
        [NativeName("Type.Name", "DXVA_AYUVsample2")]
        [NativeName("Name", "BackgroundColor")]
        public AYUVsample2 BackgroundColor;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "rcTarget")]
        public Silk.NET.Maths.Box2D<int> RcTarget;

        [NativeName("Type", "REFERENCE_TIME")]
        [NativeName("Type.Name", "REFERENCE_TIME")]
        [NativeName("Name", "rtTarget")]
        public long RtTarget;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumSourceSurfaces")]
        public uint NumSourceSurfaces;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Alpha")]
        public float Alpha;
        
        [NativeName("Type", "DXVA_VideoSample2[32]")]
        [NativeName("Type.Name", "DXVA_VideoSample2[32]")]
        [NativeName("Name", "Source")]
        public SourceBuffer Source;

        public struct SourceBuffer
        {
            public VideoSample2 Element0;
            public VideoSample2 Element1;
            public VideoSample2 Element2;
            public VideoSample2 Element3;
            public VideoSample2 Element4;
            public VideoSample2 Element5;
            public VideoSample2 Element6;
            public VideoSample2 Element7;
            public VideoSample2 Element8;
            public VideoSample2 Element9;
            public VideoSample2 Element10;
            public VideoSample2 Element11;
            public VideoSample2 Element12;
            public VideoSample2 Element13;
            public VideoSample2 Element14;
            public VideoSample2 Element15;
            public VideoSample2 Element16;
            public VideoSample2 Element17;
            public VideoSample2 Element18;
            public VideoSample2 Element19;
            public VideoSample2 Element20;
            public VideoSample2 Element21;
            public VideoSample2 Element22;
            public VideoSample2 Element23;
            public VideoSample2 Element24;
            public VideoSample2 Element25;
            public VideoSample2 Element26;
            public VideoSample2 Element27;
            public VideoSample2 Element28;
            public VideoSample2 Element29;
            public VideoSample2 Element30;
            public VideoSample2 Element31;
            public ref VideoSample2 this[int index]
            {
                get
                {
                    if (index > 31 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoSample2* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoSample2> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 32);
#endif
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DestinationFormat")]
        public uint DestinationFormat;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DestinationFlags")]
        public uint DestinationFlags;
    }
}
