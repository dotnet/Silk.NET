// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeH265SliceSegmentHeader
{
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265SliceSegmentHeaderFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoH265SliceType SliceType;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SliceSegmentAddress;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CollocatedRefIdx;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte MaxNumMergeCand;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceCbQpOffset;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceCrQpOffset;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceBetaOffsetDiv2;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceTcOffsetDiv2;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceActYQpOffset;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceActCbQpOffset;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceActCrQpOffset;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceQpDelta;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort Reserved1;

    [NativeTypeName("const StdVideoEncodeH265WeightTable *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265WeightTable* PWeightTable;
}
