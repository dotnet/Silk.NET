// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSystemAllocationScope")]
public enum SystemAllocationScope : uint
{
    [NativeName("VK_SYSTEM_ALLOCATION_SCOPE_COMMAND")]
    Command = 0,

    [NativeName("VK_SYSTEM_ALLOCATION_SCOPE_OBJECT")]
    Object = 1,

    [NativeName("VK_SYSTEM_ALLOCATION_SCOPE_CACHE")]
    Cache = 2,

    [NativeName("VK_SYSTEM_ALLOCATION_SCOPE_DEVICE")]
    Device = 3,

    [NativeName("VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE")]
    Instance = 4,
}
