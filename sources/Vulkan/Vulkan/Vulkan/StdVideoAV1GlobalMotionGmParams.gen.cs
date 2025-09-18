// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[InlineArray(8 * 6)]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAV1GlobalMotionGmParams
{
    [SupportedApiProfile("vulkan")]
    public int E0X0;
}
