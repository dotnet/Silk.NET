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
    [NativeName("Name", "StdVideoH264SpsFlags")]
    public unsafe partial struct StdVideoH264SpsFlags
    {
        public StdVideoH264SpsFlags
        (
            uint? constraintSet0Flag = null,
            uint? constraintSet1Flag = null,
            uint? constraintSet2Flag = null,
            uint? constraintSet3Flag = null,
            uint? constraintSet4Flag = null,
            uint? constraintSet5Flag = null,
            uint? direct8x8InferenceFlag = null,
            uint? mbAdaptiveFrameFieldFlag = null,
            uint? frameMbsOnlyFlag = null,
            uint? deltaPicOrderAlwaysZeroFlag = null,
            uint? separateColourPlaneFlag = null,
            uint? gapsInFrameNumValueAllowedFlag = null,
            uint? qpprimeYZeroTransformBypassFlag = null,
            uint? frameCroppingFlag = null,
            uint? seqScalingMatrixPresentFlag = null,
            uint? vuiParametersPresentFlag = null
        ) : this()
        {
            if (constraintSet0Flag is not null)
            {
                ConstraintSet0Flag = constraintSet0Flag.Value;
            }

            if (constraintSet1Flag is not null)
            {
                ConstraintSet1Flag = constraintSet1Flag.Value;
            }

            if (constraintSet2Flag is not null)
            {
                ConstraintSet2Flag = constraintSet2Flag.Value;
            }

            if (constraintSet3Flag is not null)
            {
                ConstraintSet3Flag = constraintSet3Flag.Value;
            }

            if (constraintSet4Flag is not null)
            {
                ConstraintSet4Flag = constraintSet4Flag.Value;
            }

            if (constraintSet5Flag is not null)
            {
                ConstraintSet5Flag = constraintSet5Flag.Value;
            }

            if (direct8x8InferenceFlag is not null)
            {
                Direct8x8InferenceFlag = direct8x8InferenceFlag.Value;
            }

            if (mbAdaptiveFrameFieldFlag is not null)
            {
                MbAdaptiveFrameFieldFlag = mbAdaptiveFrameFieldFlag.Value;
            }

            if (frameMbsOnlyFlag is not null)
            {
                FrameMbsOnlyFlag = frameMbsOnlyFlag.Value;
            }

            if (deltaPicOrderAlwaysZeroFlag is not null)
            {
                DeltaPicOrderAlwaysZeroFlag = deltaPicOrderAlwaysZeroFlag.Value;
            }

            if (separateColourPlaneFlag is not null)
            {
                SeparateColourPlaneFlag = separateColourPlaneFlag.Value;
            }

            if (gapsInFrameNumValueAllowedFlag is not null)
            {
                GapsInFrameNumValueAllowedFlag = gapsInFrameNumValueAllowedFlag.Value;
            }

            if (qpprimeYZeroTransformBypassFlag is not null)
            {
                QpprimeYZeroTransformBypassFlag = qpprimeYZeroTransformBypassFlag.Value;
            }

            if (frameCroppingFlag is not null)
            {
                FrameCroppingFlag = frameCroppingFlag.Value;
            }

            if (seqScalingMatrixPresentFlag is not null)
            {
                SeqScalingMatrixPresentFlag = seqScalingMatrixPresentFlag.Value;
            }

            if (vuiParametersPresentFlag is not null)
            {
                VuiParametersPresentFlag = vuiParametersPresentFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint ConstraintSet0Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint ConstraintSet1Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint ConstraintSet2Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint ConstraintSet3Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint ConstraintSet4Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint ConstraintSet5Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint Direct8x8InferenceFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint MbAdaptiveFrameFieldFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint FrameMbsOnlyFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint DeltaPicOrderAlwaysZeroFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 9)) | (uint)(((uint)(value) & 0x1u) << 9));
        }

        public uint SeparateColourPlaneFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 10) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 10)) | (uint)(((uint)(value) & 0x1u) << 10));
        }

        public uint GapsInFrameNumValueAllowedFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 11) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 11)) | (uint)(((uint)(value) & 0x1u) << 11));
        }

        public uint QpprimeYZeroTransformBypassFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 12) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 12)) | (uint)(((uint)(value) & 0x1u) << 12));
        }

        public uint FrameCroppingFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 13) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 13)) | (uint)(((uint)(value) & 0x1u) << 13));
        }

        public uint SeqScalingMatrixPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 14) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 14)) | (uint)(((uint)(value) & 0x1u) << 14));
        }

        public uint VuiParametersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 15) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 15)) | (uint)(((uint)(value) & 0x1u) << 15));
        }
    }
}
