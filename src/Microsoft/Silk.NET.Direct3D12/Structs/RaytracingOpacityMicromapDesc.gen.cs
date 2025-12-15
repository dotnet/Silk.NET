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
    [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_DESC")]
    public unsafe partial struct RaytracingOpacityMicromapDesc
    {
        public RaytracingOpacityMicromapDesc
        (
            uint? byteOffset = null,
            uint? subdivisionLevel = null,
            RaytracingOpacityMicromapFormat? format = null
        ) : this()
        {
            if (byteOffset is not null)
            {
                ByteOffset = byteOffset.Value;
            }

            if (subdivisionLevel is not null)
            {
                SubdivisionLevel = subdivisionLevel.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ByteOffset")]
        public uint ByteOffset;

        private uint _bitfield1;

        public uint SubdivisionLevel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0xFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0xFFFFu) | (uint)((uint)(value) & 0xFFFFu));
        }

        public RaytracingOpacityMicromapFormat Format
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (RaytracingOpacityMicromapFormat)((_bitfield1 >> 16) & 0xFFFF);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((RaytracingOpacityMicromapFormat)(_bitfield1 & ~(0xFFFF << 16)) | (RaytracingOpacityMicromapFormat)(((int)(value) & 0xFFFF) << 16));
        }
    }
}
