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
    [NativeName("Name", "StdVideoH264PpsFlags")]
    public unsafe partial struct StdVideoH264PpsFlags
    {
        public StdVideoH264PpsFlags
        (
            uint? transform8x8ModeFlag = null,
            uint? redundantPicCntPresentFlag = null,
            uint? constrainedIntraPredFlag = null,
            uint? deblockingFilterControlPresentFlag = null,
            uint? weightedPredFlag = null,
            uint? bottomFieldPicOrderInFramePresentFlag = null,
            uint? entropyCodingModeFlag = null,
            uint? picScalingMatrixPresentFlag = null
        ) : this()
        {
            if (transform8x8ModeFlag is not null)
            {
                Transform8x8ModeFlag = transform8x8ModeFlag.Value;
            }

            if (redundantPicCntPresentFlag is not null)
            {
                RedundantPicCntPresentFlag = redundantPicCntPresentFlag.Value;
            }

            if (constrainedIntraPredFlag is not null)
            {
                ConstrainedIntraPredFlag = constrainedIntraPredFlag.Value;
            }

            if (deblockingFilterControlPresentFlag is not null)
            {
                DeblockingFilterControlPresentFlag = deblockingFilterControlPresentFlag.Value;
            }

            if (weightedPredFlag is not null)
            {
                WeightedPredFlag = weightedPredFlag.Value;
            }

            if (bottomFieldPicOrderInFramePresentFlag is not null)
            {
                BottomFieldPicOrderInFramePresentFlag = bottomFieldPicOrderInFramePresentFlag.Value;
            }

            if (entropyCodingModeFlag is not null)
            {
                EntropyCodingModeFlag = entropyCodingModeFlag.Value;
            }

            if (picScalingMatrixPresentFlag is not null)
            {
                PicScalingMatrixPresentFlag = picScalingMatrixPresentFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint Transform8x8ModeFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint RedundantPicCntPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint ConstrainedIntraPredFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint DeblockingFilterControlPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint WeightedPredFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint BottomFieldPicOrderInFramePresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint EntropyCodingModeFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint PicScalingMatrixPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }
    }
}
