// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMemoryOverallocationBehaviorAMD")]
public enum MemoryOverallocationBehaviorAMD : uint
{
    [NativeName("VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD")]
    Default = 0,

    [NativeName("VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD")]
    Allowed = 1,

    [NativeName("VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD")]
    Disallowed = 2,
}
