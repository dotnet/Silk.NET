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
    [NativeName("Name", "StdVideoEncodeH265SliceHeaderFlags")]
    public unsafe partial struct StdVideoEncodeH265SliceHeaderFlags
    {
        public StdVideoEncodeH265SliceHeaderFlags
        (
            uint? firstSliceSegmentInPicFlag = null,
            uint? noOutputOfPriorPicsFlag = null,
            uint? dependentSliceSegmentFlag = null,
            uint? shortTermRefPicSetSpsFlag = null,
            uint? sliceTemporalMvpEnableFlag = null,
            uint? sliceSaoLumaFlag = null,
            uint? sliceSaoChromaFlag = null,
            uint? numRefIdxActiveOverrideFlag = null,
            uint? mvdL1ZeroFlag = null,
            uint? cabacInitFlag = null,
            uint? sliceDeblockingFilterDisableFlag = null,
            uint? collocatedFromL0Flag = null,
            uint? sliceLoopFilterAcrossSlicesEnabledFlag = null,
            uint? bLastSliceInPic = null,
            uint? reservedBits = null,
            ushort? lumaWeightL0Flag = null,
            ushort? chromaWeightL0Flag = null,
            ushort? lumaWeightL1Flag = null,
            ushort? chromaWeightL1Flag = null
        ) : this()
        {
            if (firstSliceSegmentInPicFlag is not null)
            {
                FirstSliceSegmentInPicFlag = firstSliceSegmentInPicFlag.Value;
            }

            if (noOutputOfPriorPicsFlag is not null)
            {
                NoOutputOfPriorPicsFlag = noOutputOfPriorPicsFlag.Value;
            }

            if (dependentSliceSegmentFlag is not null)
            {
                DependentSliceSegmentFlag = dependentSliceSegmentFlag.Value;
            }

            if (shortTermRefPicSetSpsFlag is not null)
            {
                ShortTermRefPicSetSpsFlag = shortTermRefPicSetSpsFlag.Value;
            }

            if (sliceTemporalMvpEnableFlag is not null)
            {
                SliceTemporalMvpEnableFlag = sliceTemporalMvpEnableFlag.Value;
            }

            if (sliceSaoLumaFlag is not null)
            {
                SliceSaoLumaFlag = sliceSaoLumaFlag.Value;
            }

            if (sliceSaoChromaFlag is not null)
            {
                SliceSaoChromaFlag = sliceSaoChromaFlag.Value;
            }

            if (numRefIdxActiveOverrideFlag is not null)
            {
                NumRefIdxActiveOverrideFlag = numRefIdxActiveOverrideFlag.Value;
            }

            if (mvdL1ZeroFlag is not null)
            {
                MvdL1ZeroFlag = mvdL1ZeroFlag.Value;
            }

            if (cabacInitFlag is not null)
            {
                CabacInitFlag = cabacInitFlag.Value;
            }

            if (sliceDeblockingFilterDisableFlag is not null)
            {
                SliceDeblockingFilterDisableFlag = sliceDeblockingFilterDisableFlag.Value;
            }

            if (collocatedFromL0Flag is not null)
            {
                CollocatedFromL0Flag = collocatedFromL0Flag.Value;
            }

            if (sliceLoopFilterAcrossSlicesEnabledFlag is not null)
            {
                SliceLoopFilterAcrossSlicesEnabledFlag = sliceLoopFilterAcrossSlicesEnabledFlag.Value;
            }

            if (bLastSliceInPic is not null)
            {
                BLastSliceInPic = bLastSliceInPic.Value;
            }

            if (reservedBits is not null)
            {
                ReservedBits = reservedBits.Value;
            }

            if (lumaWeightL0Flag is not null)
            {
                LumaWeightL0Flag = lumaWeightL0Flag.Value;
            }

            if (chromaWeightL0Flag is not null)
            {
                ChromaWeightL0Flag = chromaWeightL0Flag.Value;
            }

            if (lumaWeightL1Flag is not null)
            {
                LumaWeightL1Flag = lumaWeightL1Flag.Value;
            }

            if (chromaWeightL1Flag is not null)
            {
                ChromaWeightL1Flag = chromaWeightL1Flag.Value;
            }
        }


        private uint _bitfield1;

        public uint FirstSliceSegmentInPicFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint NoOutputOfPriorPicsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint DependentSliceSegmentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint ShortTermRefPicSetSpsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint SliceTemporalMvpEnableFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint SliceSaoLumaFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint SliceSaoChromaFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint NumRefIdxActiveOverrideFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint MvdL1ZeroFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint CabacInitFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 9)) | (uint)(((uint)(value) & 0x1u) << 9));
        }

        public uint SliceDeblockingFilterDisableFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 10) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 10)) | (uint)(((uint)(value) & 0x1u) << 10));
        }

        public uint CollocatedFromL0Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 11) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 11)) | (uint)(((uint)(value) & 0x1u) << 11));
        }

        public uint SliceLoopFilterAcrossSlicesEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 12) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 12)) | (uint)(((uint)(value) & 0x1u) << 12));
        }

        public uint BLastSliceInPic
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 13) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 13)) | (uint)(((uint)(value) & 0x1u) << 13));
        }

        public uint ReservedBits
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 14) & 0x3FFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x3FFFFu << 14)) | (uint)(((uint)(value) & 0x3FFFFu) << 14));
        }

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "luma_weight_l0_flag")]
        public ushort LumaWeightL0Flag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "chroma_weight_l0_flag")]
        public ushort ChromaWeightL0Flag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "luma_weight_l1_flag")]
        public ushort LumaWeightL1Flag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "chroma_weight_l1_flag")]
        public ushort ChromaWeightL1Flag;
    }
}
