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
    [NativeName("Name", "StdVideoEncodeH264SliceHeaderFlags")]
    public unsafe partial struct StdVideoEncodeH264SliceHeaderFlags
    {
        public StdVideoEncodeH264SliceHeaderFlags
        (
            uint? directSpatialMvPredFlag = null,
            uint? numRefIdxActiveOverrideFlag = null,
            uint? noOutputOfPriorPicsFlag = null,
            uint? adaptiveRefPicMarkingModeFlag = null,
            uint? noPriorReferencesAvailableFlag = null
        ) : this()
        {
            if (directSpatialMvPredFlag is not null)
            {
                DirectSpatialMvPredFlag = directSpatialMvPredFlag.Value;
            }

            if (numRefIdxActiveOverrideFlag is not null)
            {
                NumRefIdxActiveOverrideFlag = numRefIdxActiveOverrideFlag.Value;
            }

            if (noOutputOfPriorPicsFlag is not null)
            {
                NoOutputOfPriorPicsFlag = noOutputOfPriorPicsFlag.Value;
            }

            if (adaptiveRefPicMarkingModeFlag is not null)
            {
                AdaptiveRefPicMarkingModeFlag = adaptiveRefPicMarkingModeFlag.Value;
            }

            if (noPriorReferencesAvailableFlag is not null)
            {
                NoPriorReferencesAvailableFlag = noPriorReferencesAvailableFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint DirectSpatialMvPredFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint NumRefIdxActiveOverrideFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint NoOutputOfPriorPicsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint AdaptiveRefPicMarkingModeFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint NoPriorReferencesAvailableFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }
    }
}
