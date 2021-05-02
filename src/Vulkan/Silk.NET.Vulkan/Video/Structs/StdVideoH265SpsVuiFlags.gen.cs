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
    [NativeName("Name", "StdVideoH265SpsVuiFlags")]
    public unsafe partial struct StdVideoH265SpsVuiFlags
    {
        public StdVideoH265SpsVuiFlags
        (
            uint? aspectRatioInfoPresentFlag = null,
            uint? overscanInfoPresentFlag = null,
            uint? overscanAppropriateFlag = null,
            uint? videoSignalTypePresentFlag = null,
            uint? videoFullRangeFlag = null,
            uint? colourDescriptionPresentFlag = null,
            uint? chromaLocInfoPresentFlag = null,
            uint? neutralChromaIndicationFlag = null,
            uint? fieldSeqFlag = null,
            uint? frameFieldInfoPresentFlag = null,
            uint? defaultDisplayWindowFlag = null,
            uint? vuiTimingInfoPresentFlag = null,
            uint? vuiPocProportionalToTimingFlag = null,
            uint? vuiHrdParametersPresentFlag = null,
            uint? bitstreamRestrictionFlag = null,
            uint? tilesFixedStructureFlag = null,
            uint? motionVectorsOverPicBoundariesFlag = null,
            uint? restrictedRefPicListsFlag = null
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

            if (colourDescriptionPresentFlag is not null)
            {
                ColourDescriptionPresentFlag = colourDescriptionPresentFlag.Value;
            }

            if (chromaLocInfoPresentFlag is not null)
            {
                ChromaLocInfoPresentFlag = chromaLocInfoPresentFlag.Value;
            }

            if (neutralChromaIndicationFlag is not null)
            {
                NeutralChromaIndicationFlag = neutralChromaIndicationFlag.Value;
            }

            if (fieldSeqFlag is not null)
            {
                FieldSeqFlag = fieldSeqFlag.Value;
            }

            if (frameFieldInfoPresentFlag is not null)
            {
                FrameFieldInfoPresentFlag = frameFieldInfoPresentFlag.Value;
            }

            if (defaultDisplayWindowFlag is not null)
            {
                DefaultDisplayWindowFlag = defaultDisplayWindowFlag.Value;
            }

            if (vuiTimingInfoPresentFlag is not null)
            {
                VuiTimingInfoPresentFlag = vuiTimingInfoPresentFlag.Value;
            }

            if (vuiPocProportionalToTimingFlag is not null)
            {
                VuiPocProportionalToTimingFlag = vuiPocProportionalToTimingFlag.Value;
            }

            if (vuiHrdParametersPresentFlag is not null)
            {
                VuiHrdParametersPresentFlag = vuiHrdParametersPresentFlag.Value;
            }

            if (bitstreamRestrictionFlag is not null)
            {
                BitstreamRestrictionFlag = bitstreamRestrictionFlag.Value;
            }

            if (tilesFixedStructureFlag is not null)
            {
                TilesFixedStructureFlag = tilesFixedStructureFlag.Value;
            }

            if (motionVectorsOverPicBoundariesFlag is not null)
            {
                MotionVectorsOverPicBoundariesFlag = motionVectorsOverPicBoundariesFlag.Value;
            }

            if (restrictedRefPicListsFlag is not null)
            {
                RestrictedRefPicListsFlag = restrictedRefPicListsFlag.Value;
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

        public uint ColourDescriptionPresentFlag
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

        public uint NeutralChromaIndicationFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint FieldSeqFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint FrameFieldInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 9)) | (uint)(((uint)(value) & 0x1u) << 9));
        }

        public uint DefaultDisplayWindowFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 10) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 10)) | (uint)(((uint)(value) & 0x1u) << 10));
        }

        public uint VuiTimingInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 11) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 11)) | (uint)(((uint)(value) & 0x1u) << 11));
        }

        public uint VuiPocProportionalToTimingFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 12) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 12)) | (uint)(((uint)(value) & 0x1u) << 12));
        }

        public uint VuiHrdParametersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 13) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 13)) | (uint)(((uint)(value) & 0x1u) << 13));
        }

        public uint BitstreamRestrictionFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 14) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 14)) | (uint)(((uint)(value) & 0x1u) << 14));
        }

        public uint TilesFixedStructureFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 15) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 15)) | (uint)(((uint)(value) & 0x1u) << 15));
        }

        public uint MotionVectorsOverPicBoundariesFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 16) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 16)) | (uint)(((uint)(value) & 0x1u) << 16));
        }

        public uint RestrictedRefPicListsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 17) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 17)) | (uint)(((uint)(value) & 0x1u) << 17));
        }
    }
}
