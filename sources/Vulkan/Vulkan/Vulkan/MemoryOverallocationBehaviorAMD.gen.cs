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
public enum MemoryOverallocationBehaviorAMD : uint
{
    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    DefaultAMD = 0,

    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    AllowedAMD = 1,

    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    DisallowedAMD = 2,
}
