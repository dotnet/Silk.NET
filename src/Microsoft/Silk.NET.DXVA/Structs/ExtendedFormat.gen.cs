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
    [NativeName("Name", "_DXVA_ExtendedFormat")]
    public unsafe partial struct ExtendedFormat
    {
        public ExtendedFormat
        (
            uint? sampleFormat = null,
            uint? videoChromaSubsampling = null,
            NominalRange? nominalRange = null,
            VideoTransferMatrix? videoTransferMatrix = null,
            VideoLighting? videoLighting = null,
            VideoPrimaries? videoPrimaries = null,
            VideoTransferFunction? videoTransferFunction = null
        ) : this()
        {
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


        private uint _bitfield1;

        public uint SampleFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0xFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0xFFu) | (uint)((uint)(value) & 0xFFu));
        }

        public uint VideoChromaSubsampling
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0xFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFu << 8)) | (uint)(((uint)(value) & 0xFu) << 8));
        }

        public NominalRange NominalRange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (NominalRange)((_bitfield1 >> 12) & 0x7);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((NominalRange)(_bitfield1 & ~(0x7 << 12)) | (NominalRange)(((int)(value) & 0x7) << 12));
        }

        public VideoTransferMatrix VideoTransferMatrix
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (VideoTransferMatrix)((_bitfield1 >> 15) & 0x7);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((VideoTransferMatrix)(_bitfield1 & ~(0x7 << 15)) | (VideoTransferMatrix)(((int)(value) & 0x7) << 15));
        }

        public VideoLighting VideoLighting
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (VideoLighting)((_bitfield1 >> 18) & 0xF);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((VideoLighting)(_bitfield1 & ~(0xF << 18)) | (VideoLighting)(((int)(value) & 0xF) << 18));
        }

        public VideoPrimaries VideoPrimaries
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (VideoPrimaries)((_bitfield1 >> 22) & 0x1F);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((VideoPrimaries)(_bitfield1 & ~(0x1F << 22)) | (VideoPrimaries)(((int)(value) & 0x1F) << 22));
        }

        public VideoTransferFunction VideoTransferFunction
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (VideoTransferFunction)((_bitfield1 >> 27) & 0x1F);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((VideoTransferFunction)(_bitfield1 & ~(0x1F << 27)) | (VideoTransferFunction)(((int)(value) & 0x1F) << 27));
        }
    }
}
