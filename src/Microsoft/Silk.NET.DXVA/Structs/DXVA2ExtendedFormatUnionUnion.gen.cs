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
    [NativeName("Name", "__AnonymousRecord_dxva2api_L207_C9")]
    public unsafe partial struct DXVA2ExtendedFormatUnionUnion
    {
        public DXVA2ExtendedFormatUnionUnion
        (
            uint? sampleFormat = null,
            uint? videoChromaSubsampling = null,
            uint? nominalRange = null,
            uint? videoTransferMatrix = null,
            uint? videoLighting = null,
            uint? videoPrimaries = null,
            uint? videoTransferFunction = null
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

        public uint NominalRange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 12) & 0x7u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x7u << 12)) | (uint)(((uint)(value) & 0x7u) << 12));
        }

        public uint VideoTransferMatrix
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 15) & 0x7u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x7u << 15)) | (uint)(((uint)(value) & 0x7u) << 15));
        }

        public uint VideoLighting
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 18) & 0xFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFu << 18)) | (uint)(((uint)(value) & 0xFu) << 18));
        }

        public uint VideoPrimaries
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 22) & 0x1Fu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1Fu << 22)) | (uint)(((uint)(value) & 0x1Fu) << 22));
        }

        public uint VideoTransferFunction
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 27) & 0x1Fu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1Fu << 27)) | (uint)(((uint)(value) & 0x1Fu) << 27));
        }
    }
}
