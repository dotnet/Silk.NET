// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265SubLayerHrdParameters")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265SubLayerHrdParameters
{
    [NativeName("bit_rate_value_minus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParametersBitRateValueMinus1 BitRateValueMinus1;

    [NativeName("cpb_size_value_minus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParametersCpbSizeValueMinus1 CpbSizeValueMinus1;

    [NativeName("cpb_size_du_value_minus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParametersCpbSizeDuValueMinus1 CpbSizeDuValueMinus1;

    [NativeName("bit_rate_du_value_minus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParametersBitRateDuValueMinus1 BitRateDuValueMinus1;

    [NativeName("cbr_flag")]
    [SupportedApiProfile("vulkan")]
    public uint CbrFlag;
}
