// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1GlobalMotion")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAv1GlobalMotion
{
    [NativeName("GmType")]
    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1GlobalMotionGmType GmType;

    [NativeName("gm_params")]
    [NativeTypeName("int32_t[8][6]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1GlobalMotionGmParams GmParams;
}
