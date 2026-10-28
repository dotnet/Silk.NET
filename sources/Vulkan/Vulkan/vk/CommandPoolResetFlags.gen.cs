// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCommandPoolResetFlags")]
[Flags]
public enum CommandPoolResetFlags : uint
{
    None = 0x0,

    [NativeName("VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT")]
    ReleaseResourcesBit = 0x1,
}
