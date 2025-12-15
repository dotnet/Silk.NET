// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS")]
    public enum VideoEncoderAV1FeatureFlags : int
    {
        [Obsolete("Deprecated in favour of \"FlagNone\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_NONE")]
        VideoEncoderAV1FeatureFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Flag128x128Superblock\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_128x128_SUPERBLOCK")]
        VideoEncoderAV1FeatureFlag128x128Superblock = 0x1,
        [Obsolete("Deprecated in favour of \"FlagFilterIntra\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_FILTER_INTRA")]
        VideoEncoderAV1FeatureFlagFilterIntra = 0x2,
        [Obsolete("Deprecated in favour of \"FlagIntraEdgeFilter\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_INTRA_EDGE_FILTER")]
        VideoEncoderAV1FeatureFlagIntraEdgeFilter = 0x4,
        [Obsolete("Deprecated in favour of \"FlagInterintraCompound\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_INTERINTRA_COMPOUND")]
        VideoEncoderAV1FeatureFlagInterintraCompound = 0x8,
        [Obsolete("Deprecated in favour of \"FlagMaskedCompound\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_MASKED_COMPOUND")]
        VideoEncoderAV1FeatureFlagMaskedCompound = 0x10,
        [Obsolete("Deprecated in favour of \"FlagWarpedMotion\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_WARPED_MOTION")]
        VideoEncoderAV1FeatureFlagWarpedMotion = 0x20,
        [Obsolete("Deprecated in favour of \"FlagDualFilter\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_DUAL_FILTER")]
        VideoEncoderAV1FeatureFlagDualFilter = 0x40,
        [Obsolete("Deprecated in favour of \"FlagJntComp\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_JNT_COMP")]
        VideoEncoderAV1FeatureFlagJntComp = 0x80,
        [Obsolete("Deprecated in favour of \"FlagForcedIntegerMotionVectors\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_FORCED_INTEGER_MOTION_VECTORS")]
        VideoEncoderAV1FeatureFlagForcedIntegerMotionVectors = 0x100,
        [Obsolete("Deprecated in favour of \"FlagSuperResolution\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_SUPER_RESOLUTION")]
        VideoEncoderAV1FeatureFlagSuperResolution = 0x200,
        [Obsolete("Deprecated in favour of \"FlagLoopRestorationFilter\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_LOOP_RESTORATION_FILTER")]
        VideoEncoderAV1FeatureFlagLoopRestorationFilter = 0x400,
        [Obsolete("Deprecated in favour of \"FlagPaletteEncoding\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_PALETTE_ENCODING")]
        VideoEncoderAV1FeatureFlagPaletteEncoding = 0x800,
        [Obsolete("Deprecated in favour of \"FlagCdefFiltering\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_CDEF_FILTERING")]
        VideoEncoderAV1FeatureFlagCdefFiltering = 0x1000,
        [Obsolete("Deprecated in favour of \"FlagIntraBlockCopy\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_INTRA_BLOCK_COPY")]
        VideoEncoderAV1FeatureFlagIntraBlockCopy = 0x2000,
        [Obsolete("Deprecated in favour of \"FlagFrameReferenceMotionVectors\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_FRAME_REFERENCE_MOTION_VECTORS")]
        VideoEncoderAV1FeatureFlagFrameReferenceMotionVectors = 0x4000,
        [Obsolete("Deprecated in favour of \"FlagOrderHintTools\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_ORDER_HINT_TOOLS")]
        VideoEncoderAV1FeatureFlagOrderHintTools = 0x8000,
        [Obsolete("Deprecated in favour of \"FlagAutoSegmentation\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_AUTO_SEGMENTATION")]
        VideoEncoderAV1FeatureFlagAutoSegmentation = 0x10000,
        [Obsolete("Deprecated in favour of \"FlagCustomSegmentation\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_CUSTOM_SEGMENTATION")]
        VideoEncoderAV1FeatureFlagCustomSegmentation = 0x20000,
        [Obsolete("Deprecated in favour of \"FlagLoopFilterDeltas\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_LOOP_FILTER_DELTAS")]
        VideoEncoderAV1FeatureFlagLoopFilterDeltas = 0x40000,
        [Obsolete("Deprecated in favour of \"FlagQuantizationDeltas\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_QUANTIZATION_DELTAS")]
        VideoEncoderAV1FeatureFlagQuantizationDeltas = 0x80000,
        [Obsolete("Deprecated in favour of \"FlagQuantizationMatrix\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_QUANTIZATION_MATRIX")]
        VideoEncoderAV1FeatureFlagQuantizationMatrix = 0x100000,
        [Obsolete("Deprecated in favour of \"FlagReducedTXSet\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_REDUCED_TX_SET")]
        VideoEncoderAV1FeatureFlagReducedTXSet = 0x200000,
        [Obsolete("Deprecated in favour of \"FlagMotionModeSwitchable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_MOTION_MODE_SWITCHABLE")]
        VideoEncoderAV1FeatureFlagMotionModeSwitchable = 0x400000,
        [Obsolete("Deprecated in favour of \"FlagAllowHighPrecisionMV\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_ALLOW_HIGH_PRECISION_MV")]
        VideoEncoderAV1FeatureFlagAllowHighPrecisionMV = 0x800000,
        [Obsolete("Deprecated in favour of \"FlagSkipModePresent\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_SKIP_MODE_PRESENT")]
        VideoEncoderAV1FeatureFlagSkipModePresent = 0x1000000,
        [Obsolete("Deprecated in favour of \"FlagDeltaLFParams\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_DELTA_LF_PARAMS")]
        VideoEncoderAV1FeatureFlagDeltaLFParams = 0x2000000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_NONE")]
        FlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_128x128_SUPERBLOCK")]
        Flag128x128Superblock = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_FILTER_INTRA")]
        FlagFilterIntra = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_INTRA_EDGE_FILTER")]
        FlagIntraEdgeFilter = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_INTERINTRA_COMPOUND")]
        FlagInterintraCompound = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_MASKED_COMPOUND")]
        FlagMaskedCompound = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_WARPED_MOTION")]
        FlagWarpedMotion = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_DUAL_FILTER")]
        FlagDualFilter = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_JNT_COMP")]
        FlagJntComp = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_FORCED_INTEGER_MOTION_VECTORS")]
        FlagForcedIntegerMotionVectors = 0x100,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_SUPER_RESOLUTION")]
        FlagSuperResolution = 0x200,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_LOOP_RESTORATION_FILTER")]
        FlagLoopRestorationFilter = 0x400,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_PALETTE_ENCODING")]
        FlagPaletteEncoding = 0x800,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_CDEF_FILTERING")]
        FlagCdefFiltering = 0x1000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_INTRA_BLOCK_COPY")]
        FlagIntraBlockCopy = 0x2000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_FRAME_REFERENCE_MOTION_VECTORS")]
        FlagFrameReferenceMotionVectors = 0x4000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_ORDER_HINT_TOOLS")]
        FlagOrderHintTools = 0x8000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_AUTO_SEGMENTATION")]
        FlagAutoSegmentation = 0x10000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_CUSTOM_SEGMENTATION")]
        FlagCustomSegmentation = 0x20000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_LOOP_FILTER_DELTAS")]
        FlagLoopFilterDeltas = 0x40000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_QUANTIZATION_DELTAS")]
        FlagQuantizationDeltas = 0x80000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_QUANTIZATION_MATRIX")]
        FlagQuantizationMatrix = 0x100000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_REDUCED_TX_SET")]
        FlagReducedTXSet = 0x200000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_MOTION_MODE_SWITCHABLE")]
        FlagMotionModeSwitchable = 0x400000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_ALLOW_HIGH_PRECISION_MV")]
        FlagAllowHighPrecisionMV = 0x800000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_SKIP_MODE_PRESENT")]
        FlagSkipModePresent = 0x1000000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAG_DELTA_LF_PARAMS")]
        FlagDeltaLFParams = 0x2000000,
    }
}
