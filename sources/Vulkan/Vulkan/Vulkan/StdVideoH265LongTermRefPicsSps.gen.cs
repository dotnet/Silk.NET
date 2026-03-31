// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265LongTermRefPicsSps")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265LongTermRefPicsSps
{
    [NativeName("used_by_curr_pic_lt_sps_flag")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint UsedByCurrPicLtSpsFlag;

    [NativeName("lt_ref_pic_poc_lsb_sps")]
    [NativeTypeName("uint32_t[32]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265LongTermRefPicsSpsLtRefPicPocLsbSps LtRefPicPocLsbSps;
}
