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
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumLongTermSps;

    [NativeName("num_long_term_pics")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte NumLongTermPics;

    [NativeName("lt_idx_sps")]
    [NativeTypeName("uint8_t[32]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPicsLtIdxSps LtIdxSps;

    [NativeName("poc_lsb_lt")]
    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPicsPocLsbLt PocLsbLt;

    [NativeName("used_by_curr_pic_lt_flag")]
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort UsedByCurrPicLtFlag;

    [NativeName("delta_poc_msb_present_flag")]
    [NativeTypeName("uint8_t[48]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPicsDeltaPocMsbPresentFlag DeltaPocMsbPresentFlag;

    [NativeName("delta_poc_msb_cycle_lt")]
    [NativeTypeName("uint8_t[48]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265LongTermRefPicsDeltaPocMsbCycleLt DeltaPocMsbCycleLt;
}
