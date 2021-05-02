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
    [NativeName("Name", "StdVideoH265VpsFlags")]
    public unsafe partial struct StdVideoH265VpsFlags
    {
        public StdVideoH265VpsFlags
        (
            uint? vpsTemporalIdNestingFlag = null,
            uint? vpsSubLayerOrderingInfoPresentFlag = null,
            uint? vpsTimingInfoPresentFlag = null,
            uint? vpsPocProportionalToTimingFlag = null
        ) : this()
        {
            if (vpsTemporalIdNestingFlag is not null)
            {
                VpsTemporalIdNestingFlag = vpsTemporalIdNestingFlag.Value;
            }

            if (vpsSubLayerOrderingInfoPresentFlag is not null)
            {
                VpsSubLayerOrderingInfoPresentFlag = vpsSubLayerOrderingInfoPresentFlag.Value;
            }

            if (vpsTimingInfoPresentFlag is not null)
            {
                VpsTimingInfoPresentFlag = vpsTimingInfoPresentFlag.Value;
            }

            if (vpsPocProportionalToTimingFlag is not null)
            {
                VpsPocProportionalToTimingFlag = vpsPocProportionalToTimingFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint VpsTemporalIdNestingFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint VpsSubLayerOrderingInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint VpsTimingInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint VpsPocProportionalToTimingFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }
    }
}
