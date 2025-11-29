// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265SubLayerHrdParameters
{
    [NativeTypeName("uint32_t[32]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParametersBitRateValueMinus1 BitRateValueMinus1;

    [NativeTypeName("uint32_t[32]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParametersCpbSizeValueMinus1 CpbSizeValueMinus1;

    [NativeTypeName("uint32_t[32]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParametersCpbSizeDuValueMinus1 CpbSizeDuValueMinus1;

    [NativeTypeName("uint32_t[32]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParametersBitRateDuValueMinus1 BitRateDuValueMinus1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CbrFlag;
}
