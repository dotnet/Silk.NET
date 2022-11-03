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
    [NativeName("Name", "StdVideoH265PpsFlags")]
    public unsafe partial struct StdVideoH265PpsFlags
    {
        public StdVideoH265PpsFlags
        (
            uint? dependentSliceSegmentsEnabledFlag = null,
            uint? outputFlagPresentFlag = null,
            uint? signDataHidingEnabledFlag = null,
            uint? cabacInitPresentFlag = null,
            uint? constrainedIntraPredFlag = null,
            uint? transformSkipEnabledFlag = null,
            uint? cuQpDeltaEnabledFlag = null,
            uint? ppsSliceChromaQpOffsetsPresentFlag = null,
            uint? weightedPredFlag = null,
            uint? weightedBipredFlag = null,
            uint? transquantBypassEnabledFlag = null,
            uint? tilesEnabledFlag = null,
            uint? entropyCodingSyncEnabledFlag = null,
            uint? uniformSpacingFlag = null,
            uint? loopFilterAcrossTilesEnabledFlag = null,
            uint? ppsLoopFilterAcrossSlicesEnabledFlag = null,
            uint? deblockingFilterControlPresentFlag = null,
            uint? deblockingFilterOverrideEnabledFlag = null,
            uint? ppsDeblockingFilterDisabledFlag = null,
            uint? ppsScalingListDataPresentFlag = null,
            uint? listsModificationPresentFlag = null,
            uint? sliceSegmentHeaderExtensionPresentFlag = null,
            uint? ppsExtensionPresentFlag = null,
            uint? crossComponentPredictionEnabledFlag = null,
            uint? chromaQpOffsetListEnabledFlag = null,
            uint? ppsCurrPicRefEnabledFlag = null,
            uint? residualAdaptiveColourTransformEnabledFlag = null,
            uint? ppsSliceActQpOffsetsPresentFlag = null,
            uint? ppsPalettePredictorInitializersPresentFlag = null,
            uint? monochromePaletteFlag = null,
            uint? ppsRangeExtensionFlag = null
        ) : this()
        {
            if (dependentSliceSegmentsEnabledFlag is not null)
            {
                DependentSliceSegmentsEnabledFlag = dependentSliceSegmentsEnabledFlag.Value;
            }

            if (outputFlagPresentFlag is not null)
            {
                OutputFlagPresentFlag = outputFlagPresentFlag.Value;
            }

            if (signDataHidingEnabledFlag is not null)
            {
                SignDataHidingEnabledFlag = signDataHidingEnabledFlag.Value;
            }

            if (cabacInitPresentFlag is not null)
            {
                CabacInitPresentFlag = cabacInitPresentFlag.Value;
            }

            if (constrainedIntraPredFlag is not null)
            {
                ConstrainedIntraPredFlag = constrainedIntraPredFlag.Value;
            }

            if (transformSkipEnabledFlag is not null)
            {
                TransformSkipEnabledFlag = transformSkipEnabledFlag.Value;
            }

            if (cuQpDeltaEnabledFlag is not null)
            {
                CuQpDeltaEnabledFlag = cuQpDeltaEnabledFlag.Value;
            }

            if (ppsSliceChromaQpOffsetsPresentFlag is not null)
            {
                PpsSliceChromaQpOffsetsPresentFlag = ppsSliceChromaQpOffsetsPresentFlag.Value;
            }

            if (weightedPredFlag is not null)
            {
                WeightedPredFlag = weightedPredFlag.Value;
            }

            if (weightedBipredFlag is not null)
            {
                WeightedBipredFlag = weightedBipredFlag.Value;
            }

            if (transquantBypassEnabledFlag is not null)
            {
                TransquantBypassEnabledFlag = transquantBypassEnabledFlag.Value;
            }

            if (tilesEnabledFlag is not null)
            {
                TilesEnabledFlag = tilesEnabledFlag.Value;
            }

            if (entropyCodingSyncEnabledFlag is not null)
            {
                EntropyCodingSyncEnabledFlag = entropyCodingSyncEnabledFlag.Value;
            }

            if (uniformSpacingFlag is not null)
            {
                UniformSpacingFlag = uniformSpacingFlag.Value;
            }

            if (loopFilterAcrossTilesEnabledFlag is not null)
            {
                LoopFilterAcrossTilesEnabledFlag = loopFilterAcrossTilesEnabledFlag.Value;
            }

            if (ppsLoopFilterAcrossSlicesEnabledFlag is not null)
            {
                PpsLoopFilterAcrossSlicesEnabledFlag = ppsLoopFilterAcrossSlicesEnabledFlag.Value;
            }

            if (deblockingFilterControlPresentFlag is not null)
            {
                DeblockingFilterControlPresentFlag = deblockingFilterControlPresentFlag.Value;
            }

            if (deblockingFilterOverrideEnabledFlag is not null)
            {
                DeblockingFilterOverrideEnabledFlag = deblockingFilterOverrideEnabledFlag.Value;
            }

            if (ppsDeblockingFilterDisabledFlag is not null)
            {
                PpsDeblockingFilterDisabledFlag = ppsDeblockingFilterDisabledFlag.Value;
            }

            if (ppsScalingListDataPresentFlag is not null)
            {
                PpsScalingListDataPresentFlag = ppsScalingListDataPresentFlag.Value;
            }

            if (listsModificationPresentFlag is not null)
            {
                ListsModificationPresentFlag = listsModificationPresentFlag.Value;
            }

            if (sliceSegmentHeaderExtensionPresentFlag is not null)
            {
                SliceSegmentHeaderExtensionPresentFlag = sliceSegmentHeaderExtensionPresentFlag.Value;
            }

            if (ppsExtensionPresentFlag is not null)
            {
                PpsExtensionPresentFlag = ppsExtensionPresentFlag.Value;
            }

            if (crossComponentPredictionEnabledFlag is not null)
            {
                CrossComponentPredictionEnabledFlag = crossComponentPredictionEnabledFlag.Value;
            }

            if (chromaQpOffsetListEnabledFlag is not null)
            {
                ChromaQpOffsetListEnabledFlag = chromaQpOffsetListEnabledFlag.Value;
            }

            if (ppsCurrPicRefEnabledFlag is not null)
            {
                PpsCurrPicRefEnabledFlag = ppsCurrPicRefEnabledFlag.Value;
            }

            if (residualAdaptiveColourTransformEnabledFlag is not null)
            {
                ResidualAdaptiveColourTransformEnabledFlag = residualAdaptiveColourTransformEnabledFlag.Value;
            }

            if (ppsSliceActQpOffsetsPresentFlag is not null)
            {
                PpsSliceActQpOffsetsPresentFlag = ppsSliceActQpOffsetsPresentFlag.Value;
            }

            if (ppsPalettePredictorInitializersPresentFlag is not null)
            {
                PpsPalettePredictorInitializersPresentFlag = ppsPalettePredictorInitializersPresentFlag.Value;
            }

            if (monochromePaletteFlag is not null)
            {
                MonochromePaletteFlag = monochromePaletteFlag.Value;
            }

            if (ppsRangeExtensionFlag is not null)
            {
                PpsRangeExtensionFlag = ppsRangeExtensionFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint DependentSliceSegmentsEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint OutputFlagPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint SignDataHidingEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint CabacInitPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint ConstrainedIntraPredFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint TransformSkipEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint CuQpDeltaEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint PpsSliceChromaQpOffsetsPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint WeightedPredFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint WeightedBipredFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 9)) | (uint)(((uint)(value) & 0x1u) << 9));
        }

        public uint TransquantBypassEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 10) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 10)) | (uint)(((uint)(value) & 0x1u) << 10));
        }

        public uint TilesEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 11) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 11)) | (uint)(((uint)(value) & 0x1u) << 11));
        }

        public uint EntropyCodingSyncEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 12) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 12)) | (uint)(((uint)(value) & 0x1u) << 12));
        }

        public uint UniformSpacingFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 13) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 13)) | (uint)(((uint)(value) & 0x1u) << 13));
        }

        public uint LoopFilterAcrossTilesEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 14) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 14)) | (uint)(((uint)(value) & 0x1u) << 14));
        }

        public uint PpsLoopFilterAcrossSlicesEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 15) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 15)) | (uint)(((uint)(value) & 0x1u) << 15));
        }

        public uint DeblockingFilterControlPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 16) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 16)) | (uint)(((uint)(value) & 0x1u) << 16));
        }

        public uint DeblockingFilterOverrideEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 17) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 17)) | (uint)(((uint)(value) & 0x1u) << 17));
        }

        public uint PpsDeblockingFilterDisabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 18) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 18)) | (uint)(((uint)(value) & 0x1u) << 18));
        }

        public uint PpsScalingListDataPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 19) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 19)) | (uint)(((uint)(value) & 0x1u) << 19));
        }

        public uint ListsModificationPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 20) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 20)) | (uint)(((uint)(value) & 0x1u) << 20));
        }

        public uint SliceSegmentHeaderExtensionPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 21) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 21)) | (uint)(((uint)(value) & 0x1u) << 21));
        }

        public uint PpsExtensionPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 22) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 22)) | (uint)(((uint)(value) & 0x1u) << 22));
        }

        public uint CrossComponentPredictionEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 23) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 23)) | (uint)(((uint)(value) & 0x1u) << 23));
        }

        public uint ChromaQpOffsetListEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 24) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 24)) | (uint)(((uint)(value) & 0x1u) << 24));
        }

        public uint PpsCurrPicRefEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 25) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 25)) | (uint)(((uint)(value) & 0x1u) << 25));
        }

        public uint ResidualAdaptiveColourTransformEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 26) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 26)) | (uint)(((uint)(value) & 0x1u) << 26));
        }

        public uint PpsSliceActQpOffsetsPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 27) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 27)) | (uint)(((uint)(value) & 0x1u) << 27));
        }

        public uint PpsPalettePredictorInitializersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 28) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 28)) | (uint)(((uint)(value) & 0x1u) << 28));
        }

        public uint MonochromePaletteFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 29) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 29)) | (uint)(((uint)(value) & 0x1u) << 29));
        }

        public uint PpsRangeExtensionFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 30) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 30)) | (uint)(((uint)(value) & 0x1u) << 30));
        }
    }
}
