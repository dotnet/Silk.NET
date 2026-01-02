// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoH264HrdParameters
{
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CpbCntMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitRateScale;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CpbSizeScale;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeTypeName("uint32_t[32]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264HrdParametersBitRateValueMinus1 BitRateValueMinus1;

    [NativeTypeName("uint32_t[32]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264HrdParametersCpbSizeValueMinus1 CpbSizeValueMinus1;

    [NativeTypeName("uint8_t[32]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264HrdParametersCbrFlag CbrFlag;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint InitialCpbRemovalDelayLengthMinus1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CpbRemovalDelayLengthMinus1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DpbOutputDelayLengthMinus1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint TimeOffsetLength;
}
