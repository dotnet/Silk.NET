// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeAV1OperatingPointInfo
{
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1OperatingPointInfoFlags Flags;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort OperatingPointIdc;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SeqLevelIdx;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SeqTier;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DecoderBufferDelay;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint EncoderBufferDelay;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte InitialDisplayDelayMinus1;
}
