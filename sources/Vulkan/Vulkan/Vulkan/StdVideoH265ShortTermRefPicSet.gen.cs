// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265ShortTermRefPicSet
{
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSetFlags Flags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DeltaIdxMinus1;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort UseDeltaFlag;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort AbsDeltaRpsMinus1;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort UsedByCurrPicFlag;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort UsedByCurrPicS0Flag;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort UsedByCurrPicS1Flag;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort Reserved1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved3;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumNegativePics;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumPositivePics;

    [NativeTypeName("uint16_t[16]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSetDeltaPocS0Minus1 DeltaPocS0Minus1;

    [NativeTypeName("uint16_t[16]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSetDeltaPocS1Minus1 DeltaPocS1Minus1;
}
