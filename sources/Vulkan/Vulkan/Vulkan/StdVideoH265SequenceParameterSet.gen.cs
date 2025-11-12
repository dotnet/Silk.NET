// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH265SequenceParameterSet
{
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SpsFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoH265ChromaFormatIdc ChromaFormatIdc;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PicWidthInLumaSamples;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PicHeightInLumaSamples;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsVideoParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsMaxSubLayersMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsSeqParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepthLumaMinus8;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepthChromaMinus8;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxPicOrderCntLsbMinus4;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MinLumaCodingBlockSizeMinus3;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2DiffMaxMinLumaCodingBlockSize;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MinLumaTransformBlockSizeMinus2;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2DiffMaxMinLumaTransformBlockSize;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxTransformHierarchyDepthInter;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxTransformHierarchyDepthIntra;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumShortTermRefPicSets;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumLongTermRefPicsSps;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PcmSampleBitDepthLumaMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PcmSampleBitDepthChromaMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MinPcmLumaCodingBlockSizeMinus3;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2DiffMaxMinPcmLumaCodingBlockSize;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PaletteMaxSize;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaPaletteMaxPredictorSize;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MotionVectorResolutionControlIdc;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SpsNumPalettePredictorInitializersMinus1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConfWinLeftOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConfWinRightOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConfWinTopOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConfWinBottomOffset;

    [NativeTypeName("const StdVideoH265ProfileTierLevel *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ProfileTierLevel* PProfileTierLevel;

    [NativeTypeName("const StdVideoH265DecPicBufMgr *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

    [NativeTypeName("const StdVideoH265ScalingLists *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingLists* PScalingLists;

    [NativeTypeName("const StdVideoH265ShortTermRefPicSet *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

    [NativeTypeName("const StdVideoH265LongTermRefPicsSps *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265LongTermRefPicsSps* PLongTermRefPicsSps;

    [NativeTypeName("const StdVideoH265SequenceParameterSetVui *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SequenceParameterSetVui* PSequenceParameterSetVui;

    [NativeTypeName("const StdVideoH265PredictorPaletteEntries *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265PredictorPaletteEntries* PPredictorPaletteEntries;
}
