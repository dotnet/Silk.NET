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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoVP9SegmentationFlags")]
    public unsafe partial struct StdVideoVP9SegmentationFlags
    {
        public StdVideoVP9SegmentationFlags
        (
            uint? segmentationUpdateMap = null,
            uint? segmentationTemporalUpdate = null,
            uint? segmentationUpdateData = null,
            uint? segmentationAbsOrDeltaUpdate = null,
            uint? reserved = null
        ) : this()
        {
            if (segmentationUpdateMap is not null)
            {
                SegmentationUpdateMap = segmentationUpdateMap.Value;
            }

            if (segmentationTemporalUpdate is not null)
            {
                SegmentationTemporalUpdate = segmentationTemporalUpdate.Value;
            }

            if (segmentationUpdateData is not null)
            {
                SegmentationUpdateData = segmentationUpdateData.Value;
            }

            if (segmentationAbsOrDeltaUpdate is not null)
            {
                SegmentationAbsOrDeltaUpdate = segmentationAbsOrDeltaUpdate.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private uint _bitfield1;

        public uint SegmentationUpdateMap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint SegmentationTemporalUpdate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint SegmentationUpdateData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint SegmentationAbsOrDeltaUpdate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0xFFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFFFFFFFu << 4)) | (uint)(((uint)(value) & 0xFFFFFFFu) << 4));
        }
    }
}
