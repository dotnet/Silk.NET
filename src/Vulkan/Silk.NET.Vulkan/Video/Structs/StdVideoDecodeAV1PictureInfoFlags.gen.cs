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
    [NativeName("Name", "StdVideoDecodeAV1PictureInfoFlags")]
    public unsafe partial struct StdVideoDecodeAV1PictureInfoFlags
    {
        public StdVideoDecodeAV1PictureInfoFlags
        (
            uint? errorResilientMode = null,
            uint? disableCdfUpdate = null,
            uint? useSuperres = null,
            uint? renderAndFrameSizeDifferent = null,
            uint? allowScreenContentTools = null,
            uint? isFilterSwitchable = null,
            uint? forceIntegerMv = null,
            uint? frameSizeOverrideFlag = null,
            uint? bufferRemovalTimePresentFlag = null,
            uint? allowIntrabc = null,
            uint? frameRefsShortSignaling = null,
            uint? allowHighPrecisionMv = null,
            uint? isMotionModeSwitchable = null,
            uint? useRefFrameMvs = null,
            uint? disableFrameEndUpdateCdf = null,
            uint? allowWarpedMotion = null,
            uint? reducedTxSet = null,
            uint? referenceSelect = null,
            uint? skipModePresent = null,
            uint? deltaQPresent = null,
            uint? deltaLfPresent = null,
            uint? deltaLfMulti = null,
            uint? segmentationEnabled = null,
            uint? segmentationUpdateMap = null,
            uint? segmentationTemporalUpdate = null,
            uint? segmentationUpdateData = null,
            uint? usesLr = null,
            uint? usesChromaLr = null,
            uint? applyGrain = null,
            uint? reserved = null
        ) : this()
        {
            if (errorResilientMode is not null)
            {
                ErrorResilientMode = errorResilientMode.Value;
            }

            if (disableCdfUpdate is not null)
            {
                DisableCdfUpdate = disableCdfUpdate.Value;
            }

            if (useSuperres is not null)
            {
                UseSuperres = useSuperres.Value;
            }

            if (renderAndFrameSizeDifferent is not null)
            {
                RenderAndFrameSizeDifferent = renderAndFrameSizeDifferent.Value;
            }

            if (allowScreenContentTools is not null)
            {
                AllowScreenContentTools = allowScreenContentTools.Value;
            }

            if (isFilterSwitchable is not null)
            {
                IsFilterSwitchable = isFilterSwitchable.Value;
            }

            if (forceIntegerMv is not null)
            {
                ForceIntegerMv = forceIntegerMv.Value;
            }

            if (frameSizeOverrideFlag is not null)
            {
                FrameSizeOverrideFlag = frameSizeOverrideFlag.Value;
            }

            if (bufferRemovalTimePresentFlag is not null)
            {
                BufferRemovalTimePresentFlag = bufferRemovalTimePresentFlag.Value;
            }

            if (allowIntrabc is not null)
            {
                AllowIntrabc = allowIntrabc.Value;
            }

            if (frameRefsShortSignaling is not null)
            {
                FrameRefsShortSignaling = frameRefsShortSignaling.Value;
            }

            if (allowHighPrecisionMv is not null)
            {
                AllowHighPrecisionMv = allowHighPrecisionMv.Value;
            }

            if (isMotionModeSwitchable is not null)
            {
                IsMotionModeSwitchable = isMotionModeSwitchable.Value;
            }

            if (useRefFrameMvs is not null)
            {
                UseRefFrameMvs = useRefFrameMvs.Value;
            }

            if (disableFrameEndUpdateCdf is not null)
            {
                DisableFrameEndUpdateCdf = disableFrameEndUpdateCdf.Value;
            }

            if (allowWarpedMotion is not null)
            {
                AllowWarpedMotion = allowWarpedMotion.Value;
            }

            if (reducedTxSet is not null)
            {
                ReducedTxSet = reducedTxSet.Value;
            }

            if (referenceSelect is not null)
            {
                ReferenceSelect = referenceSelect.Value;
            }

            if (skipModePresent is not null)
            {
                SkipModePresent = skipModePresent.Value;
            }

            if (deltaQPresent is not null)
            {
                DeltaQPresent = deltaQPresent.Value;
            }

            if (deltaLfPresent is not null)
            {
                DeltaLfPresent = deltaLfPresent.Value;
            }

            if (deltaLfMulti is not null)
            {
                DeltaLfMulti = deltaLfMulti.Value;
            }

            if (segmentationEnabled is not null)
            {
                SegmentationEnabled = segmentationEnabled.Value;
            }

            if (segmentationUpdateMap is not null)
            {
                SegmentationUpdateMap = segmentationUpdateMap.Value;
            }

            if (segmentationTemporalUpdate is not null)
            {
                SegmentationTemporalUpdate = segmentationTemporalUpdate.Value;
            }

            if (segmentationUpdateData is not null)
            {
                SegmentationUpdateData = segmentationUpdateData.Value;
            }

            if (usesLr is not null)
            {
                UsesLr = usesLr.Value;
            }

            if (usesChromaLr is not null)
            {
                UsesChromaLr = usesChromaLr.Value;
            }

            if (applyGrain is not null)
            {
                ApplyGrain = applyGrain.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private uint _bitfield1;

        public uint ErrorResilientMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint DisableCdfUpdate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint UseSuperres
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint RenderAndFrameSizeDifferent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint AllowScreenContentTools
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint IsFilterSwitchable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint ForceIntegerMv
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint FrameSizeOverrideFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint BufferRemovalTimePresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint AllowIntrabc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 9)) | (uint)(((uint)(value) & 0x1u) << 9));
        }

        public uint FrameRefsShortSignaling
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 10) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 10)) | (uint)(((uint)(value) & 0x1u) << 10));
        }

        public uint AllowHighPrecisionMv
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 11) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 11)) | (uint)(((uint)(value) & 0x1u) << 11));
        }

        public uint IsMotionModeSwitchable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 12) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 12)) | (uint)(((uint)(value) & 0x1u) << 12));
        }

        public uint UseRefFrameMvs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 13) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 13)) | (uint)(((uint)(value) & 0x1u) << 13));
        }

        public uint DisableFrameEndUpdateCdf
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 14) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 14)) | (uint)(((uint)(value) & 0x1u) << 14));
        }

        public uint AllowWarpedMotion
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 15) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 15)) | (uint)(((uint)(value) & 0x1u) << 15));
        }

        public uint ReducedTxSet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 16) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 16)) | (uint)(((uint)(value) & 0x1u) << 16));
        }

        public uint ReferenceSelect
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 17) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 17)) | (uint)(((uint)(value) & 0x1u) << 17));
        }

        public uint SkipModePresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 18) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 18)) | (uint)(((uint)(value) & 0x1u) << 18));
        }

        public uint DeltaQPresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 19) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 19)) | (uint)(((uint)(value) & 0x1u) << 19));
        }

        public uint DeltaLfPresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 20) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 20)) | (uint)(((uint)(value) & 0x1u) << 20));
        }

        public uint DeltaLfMulti
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 21) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 21)) | (uint)(((uint)(value) & 0x1u) << 21));
        }

        public uint SegmentationEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 22) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 22)) | (uint)(((uint)(value) & 0x1u) << 22));
        }

        public uint SegmentationUpdateMap
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 23) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 23)) | (uint)(((uint)(value) & 0x1u) << 23));
        }

        public uint SegmentationTemporalUpdate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 24) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 24)) | (uint)(((uint)(value) & 0x1u) << 24));
        }

        public uint SegmentationUpdateData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 25) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 25)) | (uint)(((uint)(value) & 0x1u) << 25));
        }

        public uint UsesLr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 26) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 26)) | (uint)(((uint)(value) & 0x1u) << 26));
        }

        public uint UsesChromaLr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 27) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 27)) | (uint)(((uint)(value) & 0x1u) << 27));
        }

        public uint ApplyGrain
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 28) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 28)) | (uint)(((uint)(value) & 0x1u) << 28));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 29) & 0x7u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x7u << 29)) | (uint)(((uint)(value) & 0x7u) << 29));
        }
    }
}
