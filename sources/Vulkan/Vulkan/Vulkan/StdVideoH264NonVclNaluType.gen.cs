// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264NonVclNaluType
{
    [SupportedApiProfile("vulkan")]
    Sps = 0,

    [SupportedApiProfile("vulkan")]
    Pps = 1,

    [SupportedApiProfile("vulkan")]
    Aud = 2,

    [SupportedApiProfile("vulkan")]
    Prefix = 3,

    [SupportedApiProfile("vulkan")]
    EndOfSequence = 4,

    [SupportedApiProfile("vulkan")]
    EndOfStream = 5,

    [SupportedApiProfile("vulkan")]
    Precoded = 6,
}
