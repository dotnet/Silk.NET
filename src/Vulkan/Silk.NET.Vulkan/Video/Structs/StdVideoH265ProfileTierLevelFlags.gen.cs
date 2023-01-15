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
    [NativeName("Name", "StdVideoH265ProfileTierLevelFlags")]
    public unsafe partial struct StdVideoH265ProfileTierLevelFlags
    {
        public StdVideoH265ProfileTierLevelFlags
        (
            uint? generalTierFlag = null,
            uint? generalProgressiveSourceFlag = null,
            uint? generalInterlacedSourceFlag = null,
            uint? generalNonPackedConstraintFlag = null,
            uint? generalFrameOnlyConstraintFlag = null
        ) : this()
        {
            if (generalTierFlag is not null)
            {
                GeneralTierFlag = generalTierFlag.Value;
            }

            if (generalProgressiveSourceFlag is not null)
            {
                GeneralProgressiveSourceFlag = generalProgressiveSourceFlag.Value;
            }

            if (generalInterlacedSourceFlag is not null)
            {
                GeneralInterlacedSourceFlag = generalInterlacedSourceFlag.Value;
            }

            if (generalNonPackedConstraintFlag is not null)
            {
                GeneralNonPackedConstraintFlag = generalNonPackedConstraintFlag.Value;
            }

            if (generalFrameOnlyConstraintFlag is not null)
            {
                GeneralFrameOnlyConstraintFlag = generalFrameOnlyConstraintFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint GeneralTierFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint GeneralProgressiveSourceFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint GeneralInterlacedSourceFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint GeneralNonPackedConstraintFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint GeneralFrameOnlyConstraintFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }
    }
}
