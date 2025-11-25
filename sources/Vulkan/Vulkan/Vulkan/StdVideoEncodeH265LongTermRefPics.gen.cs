// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH265LongTermRefPics")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH265LongTermRefPics
{
    [NativeName("num_long_term_sps")]
    [SupportedApiProfile("vulkan")]
    public byte NumLongTermSps;

    [NativeName("num_long_term_pics")]
    [SupportedApiProfile("vulkan")]
    public byte NumLongTermPics;

    [NativeName("lt_idx_sps")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPicsLtIdxSps LtIdxSps;

    [NativeName("poc_lsb_lt")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPicsPocLsbLt PocLsbLt;

    [NativeName("used_by_curr_pic_lt_flag")]
    [SupportedApiProfile("vulkan")]
    public ushort UsedByCurrPicLtFlag;

    [NativeName("delta_poc_msb_present_flag")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPicsDeltaPocMsbPresentFlag DeltaPocMsbPresentFlag;

    [NativeName("delta_poc_msb_cycle_lt")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPicsDeltaPocMsbCycleLt DeltaPocMsbCycleLt;
}
