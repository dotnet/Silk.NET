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
    [NativeName("Name", "StdVideoH265SpsFlags")]
    public unsafe partial struct StdVideoH265SpsFlags
    {
        public StdVideoH265SpsFlags
        (
            uint? spsTemporalIdNestingFlag = null,
            uint? separateColourPlaneFlag = null,
            uint? conformanceWindowFlag = null,
            uint? spsSubLayerOrderingInfoPresentFlag = null,
            uint? scalingListEnabledFlag = null,
            uint? spsScalingListDataPresentFlag = null,
            uint? ampEnabledFlag = null,
            uint? sampleAdaptiveOffsetEnabledFlag = null,
            uint? pcmEnabledFlag = null,
            uint? pcmLoopFilterDisabledFlag = null,
            uint? longTermRefPicsPresentFlag = null,
            uint? spsTemporalMvpEnabledFlag = null,
            uint? strongIntraSmoothingEnabledFlag = null,
            uint? vuiParametersPresentFlag = null,
            uint? spsExtensionPresentFlag = null,
            uint? spsRangeExtensionFlag = null,
            uint? transformSkipRotationEnabledFlag = null,
            uint? transformSkipContextEnabledFlag = null,
            uint? implicitRdpcmEnabledFlag = null,
            uint? explicitRdpcmEnabledFlag = null,
            uint? extendedPrecisionProcessingFlag = null,
            uint? intraSmoothingDisabledFlag = null,
            uint? highPrecisionOffsetsEnabledFlag = null,
            uint? persistentRiceAdaptationEnabledFlag = null,
            uint? cabacBypassAlignmentEnabledFlag = null,
            uint? spsSccExtensionFlag = null,
            uint? spsCurrPicRefEnabledFlag = null,
            uint? paletteModeEnabledFlag = null,
            uint? spsPalettePredictorInitializersPresentFlag = null,
            uint? intraBoundaryFilteringDisabledFlag = null
        ) : this()
        {
            if (spsTemporalIdNestingFlag is not null)
            {
                SpsTemporalIdNestingFlag = spsTemporalIdNestingFlag.Value;
            }

            if (separateColourPlaneFlag is not null)
            {
                SeparateColourPlaneFlag = separateColourPlaneFlag.Value;
            }

            if (conformanceWindowFlag is not null)
            {
                ConformanceWindowFlag = conformanceWindowFlag.Value;
            }

            if (spsSubLayerOrderingInfoPresentFlag is not null)
            {
                SpsSubLayerOrderingInfoPresentFlag = spsSubLayerOrderingInfoPresentFlag.Value;
            }

            if (scalingListEnabledFlag is not null)
            {
                ScalingListEnabledFlag = scalingListEnabledFlag.Value;
            }

            if (spsScalingListDataPresentFlag is not null)
            {
                SpsScalingListDataPresentFlag = spsScalingListDataPresentFlag.Value;
            }

            if (ampEnabledFlag is not null)
            {
                AmpEnabledFlag = ampEnabledFlag.Value;
            }

            if (sampleAdaptiveOffsetEnabledFlag is not null)
            {
                SampleAdaptiveOffsetEnabledFlag = sampleAdaptiveOffsetEnabledFlag.Value;
            }

            if (pcmEnabledFlag is not null)
            {
                PcmEnabledFlag = pcmEnabledFlag.Value;
            }

            if (pcmLoopFilterDisabledFlag is not null)
            {
                PcmLoopFilterDisabledFlag = pcmLoopFilterDisabledFlag.Value;
            }

            if (longTermRefPicsPresentFlag is not null)
            {
                LongTermRefPicsPresentFlag = longTermRefPicsPresentFlag.Value;
            }

            if (spsTemporalMvpEnabledFlag is not null)
            {
                SpsTemporalMvpEnabledFlag = spsTemporalMvpEnabledFlag.Value;
            }

            if (strongIntraSmoothingEnabledFlag is not null)
            {
                StrongIntraSmoothingEnabledFlag = strongIntraSmoothingEnabledFlag.Value;
            }

            if (vuiParametersPresentFlag is not null)
            {
                VuiParametersPresentFlag = vuiParametersPresentFlag.Value;
            }

            if (spsExtensionPresentFlag is not null)
            {
                SpsExtensionPresentFlag = spsExtensionPresentFlag.Value;
            }

            if (spsRangeExtensionFlag is not null)
            {
                SpsRangeExtensionFlag = spsRangeExtensionFlag.Value;
            }

            if (transformSkipRotationEnabledFlag is not null)
            {
                TransformSkipRotationEnabledFlag = transformSkipRotationEnabledFlag.Value;
            }

            if (transformSkipContextEnabledFlag is not null)
            {
                TransformSkipContextEnabledFlag = transformSkipContextEnabledFlag.Value;
            }

            if (implicitRdpcmEnabledFlag is not null)
            {
                ImplicitRdpcmEnabledFlag = implicitRdpcmEnabledFlag.Value;
            }

            if (explicitRdpcmEnabledFlag is not null)
            {
                ExplicitRdpcmEnabledFlag = explicitRdpcmEnabledFlag.Value;
            }

            if (extendedPrecisionProcessingFlag is not null)
            {
                ExtendedPrecisionProcessingFlag = extendedPrecisionProcessingFlag.Value;
            }

            if (intraSmoothingDisabledFlag is not null)
            {
                IntraSmoothingDisabledFlag = intraSmoothingDisabledFlag.Value;
            }

            if (highPrecisionOffsetsEnabledFlag is not null)
            {
                HighPrecisionOffsetsEnabledFlag = highPrecisionOffsetsEnabledFlag.Value;
            }

            if (persistentRiceAdaptationEnabledFlag is not null)
            {
                PersistentRiceAdaptationEnabledFlag = persistentRiceAdaptationEnabledFlag.Value;
            }

            if (cabacBypassAlignmentEnabledFlag is not null)
            {
                CabacBypassAlignmentEnabledFlag = cabacBypassAlignmentEnabledFlag.Value;
            }

            if (spsSccExtensionFlag is not null)
            {
                SpsSccExtensionFlag = spsSccExtensionFlag.Value;
            }

            if (spsCurrPicRefEnabledFlag is not null)
            {
                SpsCurrPicRefEnabledFlag = spsCurrPicRefEnabledFlag.Value;
            }

            if (paletteModeEnabledFlag is not null)
            {
                PaletteModeEnabledFlag = paletteModeEnabledFlag.Value;
            }

            if (spsPalettePredictorInitializersPresentFlag is not null)
            {
                SpsPalettePredictorInitializersPresentFlag = spsPalettePredictorInitializersPresentFlag.Value;
            }

            if (intraBoundaryFilteringDisabledFlag is not null)
            {
                IntraBoundaryFilteringDisabledFlag = intraBoundaryFilteringDisabledFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint SpsTemporalIdNestingFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint SeparateColourPlaneFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint ConformanceWindowFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint SpsSubLayerOrderingInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint ScalingListEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint SpsScalingListDataPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint AmpEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint SampleAdaptiveOffsetEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint PcmEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint PcmLoopFilterDisabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 9)) | (uint)(((uint)(value) & 0x1u) << 9));
        }

        public uint LongTermRefPicsPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 10) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 10)) | (uint)(((uint)(value) & 0x1u) << 10));
        }

        public uint SpsTemporalMvpEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 11) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 11)) | (uint)(((uint)(value) & 0x1u) << 11));
        }

        public uint StrongIntraSmoothingEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 12) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 12)) | (uint)(((uint)(value) & 0x1u) << 12));
        }

        public uint VuiParametersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 13) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 13)) | (uint)(((uint)(value) & 0x1u) << 13));
        }

        public uint SpsExtensionPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 14) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 14)) | (uint)(((uint)(value) & 0x1u) << 14));
        }

        public uint SpsRangeExtensionFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 15) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 15)) | (uint)(((uint)(value) & 0x1u) << 15));
        }

        public uint TransformSkipRotationEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 16) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 16)) | (uint)(((uint)(value) & 0x1u) << 16));
        }

        public uint TransformSkipContextEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 17) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 17)) | (uint)(((uint)(value) & 0x1u) << 17));
        }

        public uint ImplicitRdpcmEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 18) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 18)) | (uint)(((uint)(value) & 0x1u) << 18));
        }

        public uint ExplicitRdpcmEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 19) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 19)) | (uint)(((uint)(value) & 0x1u) << 19));
        }

        public uint ExtendedPrecisionProcessingFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 20) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 20)) | (uint)(((uint)(value) & 0x1u) << 20));
        }

        public uint IntraSmoothingDisabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 21) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 21)) | (uint)(((uint)(value) & 0x1u) << 21));
        }

        public uint HighPrecisionOffsetsEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 22) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 22)) | (uint)(((uint)(value) & 0x1u) << 22));
        }

        public uint PersistentRiceAdaptationEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 23) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 23)) | (uint)(((uint)(value) & 0x1u) << 23));
        }

        public uint CabacBypassAlignmentEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 24) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 24)) | (uint)(((uint)(value) & 0x1u) << 24));
        }

        public uint SpsSccExtensionFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 25) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 25)) | (uint)(((uint)(value) & 0x1u) << 25));
        }

        public uint SpsCurrPicRefEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 26) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 26)) | (uint)(((uint)(value) & 0x1u) << 26));
        }

        public uint PaletteModeEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 27) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 27)) | (uint)(((uint)(value) & 0x1u) << 27));
        }

        public uint SpsPalettePredictorInitializersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 28) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 28)) | (uint)(((uint)(value) & 0x1u) << 28));
        }

        public uint IntraBoundaryFilteringDisabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 29) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 29)) | (uint)(((uint)(value) & 0x1u) << 29));
        }
    }
}
