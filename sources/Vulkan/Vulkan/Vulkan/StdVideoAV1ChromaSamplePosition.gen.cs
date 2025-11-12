// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAV1ChromaSamplePosition : uint
{
    [SupportedApiProfile("vulkan")]
    Unknown = 0,

    [SupportedApiProfile("vulkan")]
    Vertical = 1,

    [SupportedApiProfile("vulkan")]
    Colocated = 2,

    [SupportedApiProfile("vulkan")]
    Reserved = 3,
}
