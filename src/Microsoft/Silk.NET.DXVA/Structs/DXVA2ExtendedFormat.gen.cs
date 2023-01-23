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
    [NativeName("Name", "_DXVA2_ExtendedFormat")]
    public unsafe partial struct DXVA2ExtendedFormat
    {
        public DXVA2ExtendedFormat
        (
            DXVA2ExtendedFormatUnion? anonymous = null,
            uint? value = null,
            uint? sampleFormat = null,
            uint? videoChromaSubsampling = null,
            uint? nominalRange = null,
            uint? videoTransferMatrix = null,
            uint? videoLighting = null,
            uint? videoPrimaries = null,
            uint? videoTransferFunction = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }

            if (sampleFormat is not null)
            {
                SampleFormat = sampleFormat.Value;
            }

            if (videoChromaSubsampling is not null)
            {
                VideoChromaSubsampling = videoChromaSubsampling.Value;
            }

            if (nominalRange is not null)
            {
                NominalRange = nominalRange.Value;
            }

            if (videoTransferMatrix is not null)
            {
                VideoTransferMatrix = videoTransferMatrix.Value;
            }

            if (videoLighting is not null)
            {
                VideoLighting = videoLighting.Value;
            }

            if (videoPrimaries is not null)
            {
                VideoPrimaries = videoPrimaries.Value;
            }

            if (videoTransferFunction is not null)
            {
                VideoTransferFunction = videoTransferFunction.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_dxva2api_L205_C5")]
        [NativeName("Name", "anonymous1")]
        public DXVA2ExtendedFormatUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Value
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Value;
        }
#else
        public uint Value
        {
            get => Anonymous.Value;
            set => Anonymous.Value = value;
        }
#endif

        public uint SampleFormat
        {
            get => Anonymous.SampleFormat;
            set => Anonymous.SampleFormat = value;
        }

        public uint VideoChromaSubsampling
        {
            get => Anonymous.VideoChromaSubsampling;
            set => Anonymous.VideoChromaSubsampling = value;
        }

        public uint NominalRange
        {
            get => Anonymous.NominalRange;
            set => Anonymous.NominalRange = value;
        }

        public uint VideoTransferMatrix
        {
            get => Anonymous.VideoTransferMatrix;
            set => Anonymous.VideoTransferMatrix = value;
        }

        public uint VideoLighting
        {
            get => Anonymous.VideoLighting;
            set => Anonymous.VideoLighting = value;
        }

        public uint VideoPrimaries
        {
            get => Anonymous.VideoPrimaries;
            set => Anonymous.VideoPrimaries = value;
        }

        public uint VideoTransferFunction
        {
            get => Anonymous.VideoTransferFunction;
            set => Anonymous.VideoTransferFunction = value;
        }

    }
}
