// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265ShortTermRefPicSet")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265ShortTermRefPicSet
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSetFlags Flags;

    [NativeName("delta_idx_minus1")]
    [SupportedApiProfile("vulkan")]
    public uint DeltaIdxMinus1;

    [NativeName("use_delta_flag")]
    [SupportedApiProfile("vulkan")]
    public ushort UseDeltaFlag;

    [NativeName("abs_delta_rps_minus1")]
    [SupportedApiProfile("vulkan")]
    public ushort AbsDeltaRpsMinus1;

    [NativeName("used_by_curr_pic_flag")]
    [SupportedApiProfile("vulkan")]
    public ushort UsedByCurrPicFlag;

    [NativeName("used_by_curr_pic_s0_flag")]
    [SupportedApiProfile("vulkan")]
    public ushort UsedByCurrPicS0Flag;

    [NativeName("used_by_curr_pic_s1_flag")]
    [SupportedApiProfile("vulkan")]
    public ushort UsedByCurrPicS1Flag;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public ushort Reserved1;

    [NativeName("reserved2")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeName("reserved3")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved3;

    [NativeName("num_negative_pics")]
    [SupportedApiProfile("vulkan")]
    public byte NumNegativePics;

    [NativeName("num_positive_pics")]
    [SupportedApiProfile("vulkan")]
    public byte NumPositivePics;

    [NativeName("delta_poc_s0_minus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSetDeltaPocS0Minus1 DeltaPocS0Minus1;

    [NativeName("delta_poc_s1_minus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ShortTermRefPicSetDeltaPocS1Minus1 DeltaPocS1Minus1;
}
