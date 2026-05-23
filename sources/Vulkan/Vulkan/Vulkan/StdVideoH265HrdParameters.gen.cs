// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265HrdParameters")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH265HrdParameters
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdFlags Flags;

    [NativeName("tick_divisor_minus2")]
    [SupportedApiProfile("vulkan")]
    public byte TickDivisorMinus2;

    [NativeName("du_cpb_removal_delay_increment_length_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte DuCpbRemovalDelayIncrementLengthMinus1;

    [NativeName("dpb_output_delay_du_length_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte DpbOutputDelayDuLengthMinus1;

    [NativeName("bit_rate_scale")]
    [SupportedApiProfile("vulkan")]
    public byte BitRateScale;

    [NativeName("cpb_size_scale")]
    [SupportedApiProfile("vulkan")]
    public byte CpbSizeScale;

    [NativeName("cpb_size_du_scale")]
    [SupportedApiProfile("vulkan")]
    public byte CpbSizeDuScale;

    [NativeName("initial_cpb_removal_delay_length_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte InitialCpbRemovalDelayLengthMinus1;

    [NativeName("au_cpb_removal_delay_length_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte AuCpbRemovalDelayLengthMinus1;

    [NativeName("dpb_output_delay_length_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte DpbOutputDelayLengthMinus1;

    [NativeName("cpb_cnt_minus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParametersCpbCntMinus1 CpbCntMinus1;

    [NativeName("elemental_duration_in_tc_minus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParametersElementalDurationInTcMinus1 ElementalDurationInTcMinus1;

    [NativeName("reserved")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParametersReserved Reserved;

    [NativeName("pSubLayerHrdParametersNal")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParameters* PSubLayerHrdParametersNal;

    [NativeName("pSubLayerHrdParametersVcl")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParameters* PSubLayerHrdParametersVcl;
}
