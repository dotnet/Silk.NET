// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH264SequenceParameterSetVui
{
    [SupportedApiProfile("vulkan")]
    public StdVideoH264SpsVuiFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264AspectRatioIdc AspectRatioIdc;

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
    public byte MatrixCoefficients;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint NumUnitsInTick;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint TimeScale;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxNumReorderFrames;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxDecFrameBuffering;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ChromaSampleLocTypeTopField;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte ChromaSampleLocTypeBottomField;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Reserved1;

    [NativeTypeName("const StdVideoH264HrdParameters *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264HrdParameters* PHrdParameters;
}
