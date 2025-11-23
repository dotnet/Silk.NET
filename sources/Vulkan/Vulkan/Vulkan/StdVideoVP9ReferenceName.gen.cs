// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVP9ReferenceName : uint
{
    [SupportedApiProfile("vulkan")]
    IntraFrame = 0,

    [SupportedApiProfile("vulkan")]
    LastFrame = 1,

    [SupportedApiProfile("vulkan")]
    GoldenFrame = 2,

    [SupportedApiProfile("vulkan")]
    AltrefFrame = 3,
}
