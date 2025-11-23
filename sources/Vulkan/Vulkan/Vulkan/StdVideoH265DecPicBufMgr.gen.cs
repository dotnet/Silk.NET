// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265DecPicBufMgr
{
    [NativeTypeName("uint32_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgrMaxLatencyIncreasePlus1 MaxLatencyIncreasePlus1;

    [NativeTypeName("uint8_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgrMaxDecPicBufferingMinus1 MaxDecPicBufferingMinus1;

    [NativeTypeName("uint8_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgrMaxNumReorderPics MaxNumReorderPics;
}
