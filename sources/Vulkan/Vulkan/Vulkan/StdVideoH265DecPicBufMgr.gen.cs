// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265DecPicBufMgr")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265DecPicBufMgr
{
    [NativeName("max_latency_increase_plus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgrMaxLatencyIncreasePlus1 MaxLatencyIncreasePlus1;

    [NativeName("max_dec_pic_buffering_minus1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgrMaxDecPicBufferingMinus1 MaxDecPicBufferingMinus1;

    [NativeName("max_num_reorder_pics")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgrMaxNumReorderPics MaxNumReorderPics;
}
