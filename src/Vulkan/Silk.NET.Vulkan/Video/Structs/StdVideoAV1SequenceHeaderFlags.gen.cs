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
    [NativeName("Name", "StdVideoAV1SequenceHeaderFlags")]
    public unsafe partial struct StdVideoAV1SequenceHeaderFlags
    {
        public StdVideoAV1SequenceHeaderFlags
        (
            uint? stillPicture = null,
            uint? reducedStillPictureHeader = null,
            uint? use128x128Superblock = null,
            uint? enableFilterIntra = null,
            uint? enableIntraEdgeFilter = null,
            uint? enableInterintraCompound = null,
            uint? enableMaskedCompound = null,
            uint? enableWarpedMotion = null,
            uint? enableDualFilter = null,
            uint? enableOrderHint = null,
            uint? enableJntComp = null,
            uint? enableRefFrameMvs = null,
            uint? frameIdNumbersPresentFlag = null,
            uint? enableSuperres = null,
            uint? enableCdef = null,
            uint? enableRestoration = null,
            uint? filmGrainParamsPresent = null,
            uint? timingInfoPresentFlag = null,
            uint? initialDisplayDelayPresentFlag = null,
            uint? reserved = null
        ) : this()
        {
            if (stillPicture is not null)
            {
                StillPicture = stillPicture.Value;
            }

            if (reducedStillPictureHeader is not null)
            {
                ReducedStillPictureHeader = reducedStillPictureHeader.Value;
            }

            if (use128x128Superblock is not null)
            {
                Use128x128Superblock = use128x128Superblock.Value;
            }

            if (enableFilterIntra is not null)
            {
                EnableFilterIntra = enableFilterIntra.Value;
            }

            if (enableIntraEdgeFilter is not null)
            {
                EnableIntraEdgeFilter = enableIntraEdgeFilter.Value;
            }

            if (enableInterintraCompound is not null)
            {
                EnableInterintraCompound = enableInterintraCompound.Value;
            }

            if (enableMaskedCompound is not null)
            {
                EnableMaskedCompound = enableMaskedCompound.Value;
            }

            if (enableWarpedMotion is not null)
            {
                EnableWarpedMotion = enableWarpedMotion.Value;
            }

            if (enableDualFilter is not null)
            {
                EnableDualFilter = enableDualFilter.Value;
            }

            if (enableOrderHint is not null)
            {
                EnableOrderHint = enableOrderHint.Value;
            }

            if (enableJntComp is not null)
            {
                EnableJntComp = enableJntComp.Value;
            }

            if (enableRefFrameMvs is not null)
            {
                EnableRefFrameMvs = enableRefFrameMvs.Value;
            }

            if (frameIdNumbersPresentFlag is not null)
            {
                FrameIdNumbersPresentFlag = frameIdNumbersPresentFlag.Value;
            }

            if (enableSuperres is not null)
            {
                EnableSuperres = enableSuperres.Value;
            }

            if (enableCdef is not null)
            {
                EnableCdef = enableCdef.Value;
            }

            if (enableRestoration is not null)
            {
                EnableRestoration = enableRestoration.Value;
            }

            if (filmGrainParamsPresent is not null)
            {
                FilmGrainParamsPresent = filmGrainParamsPresent.Value;
            }

            if (timingInfoPresentFlag is not null)
            {
                TimingInfoPresentFlag = timingInfoPresentFlag.Value;
            }

            if (initialDisplayDelayPresentFlag is not null)
            {
                InitialDisplayDelayPresentFlag = initialDisplayDelayPresentFlag.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private uint _bitfield1;

        public uint StillPicture
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint ReducedStillPictureHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint Use128x128Superblock
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint EnableFilterIntra
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint EnableIntraEdgeFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint EnableInterintraCompound
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint EnableMaskedCompound
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint EnableWarpedMotion
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint EnableDualFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint EnableOrderHint
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 9)) | (uint)(((uint)(value) & 0x1u) << 9));
        }

        public uint EnableJntComp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 10) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 10)) | (uint)(((uint)(value) & 0x1u) << 10));
        }

        public uint EnableRefFrameMvs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 11) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 11)) | (uint)(((uint)(value) & 0x1u) << 11));
        }

        public uint FrameIdNumbersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 12) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 12)) | (uint)(((uint)(value) & 0x1u) << 12));
        }

        public uint EnableSuperres
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 13) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 13)) | (uint)(((uint)(value) & 0x1u) << 13));
        }

        public uint EnableCdef
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 14) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 14)) | (uint)(((uint)(value) & 0x1u) << 14));
        }

        public uint EnableRestoration
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 15) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 15)) | (uint)(((uint)(value) & 0x1u) << 15));
        }

        public uint FilmGrainParamsPresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 16) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 16)) | (uint)(((uint)(value) & 0x1u) << 16));
        }

        public uint TimingInfoPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 17) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 17)) | (uint)(((uint)(value) & 0x1u) << 17));
        }

        public uint InitialDisplayDelayPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 18) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 18)) | (uint)(((uint)(value) & 0x1u) << 18));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 19) & 0x1FFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1FFFu << 19)) | (uint)(((uint)(value) & 0x1FFFu) << 19));
        }
    }
}
