// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH265SequenceParameterSetVui
{
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SpsVuiFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoH265AspectRatioIdc AspectRatioIdc;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort SarWidth;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort SarHeight;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte VideoFormat;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ColourPrimaries;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte TransferCharacteristics;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MatrixCoeffs;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ChromaSampleLocTypeTopField;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ChromaSampleLocTypeBottomField;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort DefDispWinLeftOffset;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort DefDispWinRightOffset;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort DefDispWinTopOffset;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort DefDispWinBottomOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VuiNumUnitsInTick;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VuiTimeScale;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VuiNumTicksPocDiffOneMinus1;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort MinSpatialSegmentationIdc;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort Reserved3;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxBytesPerPicDenom;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxBitsPerMinCuDenom;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxMvLengthHorizontal;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Log2MaxMvLengthVertical;

    [NativeTypeName("const StdVideoH265HrdParameters *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParameters* PHrdParameters;
}
