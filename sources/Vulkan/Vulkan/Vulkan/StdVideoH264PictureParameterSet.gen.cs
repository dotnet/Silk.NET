// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH264PictureParameterSet
{
    [SupportedApiProfile("vulkan")]
    public StdVideoH264PpsFlags Flags;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SeqParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte PicParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefIdxL0DefaultActiveMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefIdxL1DefaultActiveMinus1;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264WeightedBipredIdc WeightedBipredIdc;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte PicInitQpMinus26;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte PicInitQsMinus26;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte ChromaQpIndexOffset;

    [NativeTypeName("int8_t")]
    [SupportedApiProfile("vulkan")]
    public sbyte SecondChromaQpIndexOffset;

    [NativeTypeName("const StdVideoH264ScalingLists *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ScalingLists* PScalingLists;
}
