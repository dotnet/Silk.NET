// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeH264SliceHeader
{
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264SliceHeaderFlags Flags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FirstMbInSlice;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264SliceType SliceType;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceAlphaC0OffsetDiv2;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceBetaOffsetDiv2;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SliceQpDelta;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264CabacInitIdc CabacInitIdc;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264DisableDeblockingFilterIdc DisableDeblockingFilterIdc;

    [NativeTypeName("const StdVideoEncodeH264WeightTable *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264WeightTable* PWeightTable;
}
