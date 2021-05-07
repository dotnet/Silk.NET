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
    [NativeName("Name", "StdVideoH264SpsVuiFlags")]
    public unsafe partial struct StdVideoH264SpsVuiFlags
    {
        public StdVideoH264SpsVuiFlags
        (
            uint? aspectRatioInfoPresentFlag = null,
            uint? overscanInfoPresentFlag = null,
            uint? overscanAppropriateFlag = null,
            uint? videoSignalTypePresentFlag = null,
            uint? videoFullRangeFlag = null,
            uint? colorDescriptionPresentFlag = null,
            uint? chromaLocInfoPresentFlag = null,
            uint? timingInfoPresentFlag = null,
            uint? fixedFrameRateFlag = null,
            uint? bitstreamRestrictionFlag = null,
            uint? nalHrdParametersPresentFlag = null,
            uint? vclHrdParametersPresentFlag = null
        ) : this()
        {
            if (aspectRatioInfoPresentFlag is not null)
            {
                AspectRatioInfoPresentFlag = aspectRatioInfoPresentFlag.Value;
            }

            if (overscanInfoPresentFlag is not null)
            {
                OverscanInfoPresentFlag = overscanInfoPresentFlag.Value;
            }

            if (overscanAppropriateFlag is not null)
            {
                OverscanAppropriateFlag = overscanAppropriateFlag.Value;
            }

            if (videoSignalTypePresentFlag is not null)
            {
                VideoSignalTypePresentFlag = videoSignalTypePresentFlag.Value;
            }

            if (videoFullRangeFlag is not null)
            {
                VideoFullRangeFlag = videoFullRangeFlag.Value;
            }

            if (colorDescriptionPresentFlag is not null)
            {
                ColorDescriptionPresentFlag = colorDescriptionPresentFlag.Value;
            }

            if (chromaLocInfoPresentFlag is not null)
            {
                ChromaLocInfoPresentFlag = chromaLocInfoPresentFlag.Value;
            }

            if (timingInfoPresentFlag is not null)
            {
                TimingInfoPresentFlag = timingInfoPresentFlag.Value;
            }

            if (fixedFrameRateFlag is not null)
            {
                FixedFrameRateFlag = fixedFrameRateFlag.Value;
            }

            if (bitstreamRestrictionFlag is not null)
            {
                BitstreamRestrictionFlag = bitstreamRestrictionFlag.Value;
            }

            if (nalHrdParametersPresentFlag is not null)
            {
                NalHrdParametersPresentFlag = nalHrdParametersPresentFlag.Value;
            }

            if (vclHrdParametersPresentFlag is not null)
            {
                VclHrdParametersPresentFlag = vclHrdParametersPresentFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint AspectRatioInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint OverscanInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint OverscanAppropriateFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint VideoSignalTypePresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint VideoFullRangeFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint ColorDescriptionPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint ChromaLocInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint TimingInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint FixedFrameRateFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint BitstreamRestrictionFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 9)) | (uint)(((uint)(value) & 0x1u) << 9));
        }

        public uint NalHrdParametersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 10) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 10)) | (uint)(((uint)(value) & 0x1u) << 10));
        }

        public uint VclHrdParametersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 11) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 11)) | (uint)(((uint)(value) & 0x1u) << 11));
        }
    }
}
