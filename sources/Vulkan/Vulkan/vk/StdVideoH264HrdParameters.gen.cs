// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264HrdParameters")]
public partial struct StdVideoH264HrdParameters
{
    [NativeName("cpb_cnt_minus1")]
    public byte CpbCntMinus1;

    [NativeName("bit_rate_scale")]
    public byte BitRateScale;

    [NativeName("cpb_size_scale")]
    public byte CpbSizeScale;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("bit_rate_value_minus1")]
    public StdVideoH264HrdParametersBitRateValueMinus1 BitRateValueMinus1;

    [NativeName("cpb_size_value_minus1")]
    public StdVideoH264HrdParametersCpbSizeValueMinus1 CpbSizeValueMinus1;

    [NativeName("cbr_flag")]
    public StdVideoH264HrdParametersCbrFlag CbrFlag;

    [NativeName("initial_cpb_removal_delay_length_minus1")]
    public uint InitialCpbRemovalDelayLengthMinus1;

    [NativeName("cpb_removal_delay_length_minus1")]
    public uint CpbRemovalDelayLengthMinus1;

    [NativeName("dpb_output_delay_length_minus1")]
    public uint DpbOutputDelayLengthMinus1;

    [NativeName("time_offset_length")]
    public uint TimeOffsetLength;
}
