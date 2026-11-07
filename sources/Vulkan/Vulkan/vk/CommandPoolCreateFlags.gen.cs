// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCommandPoolCreateFlags")]
[Flags]
public enum CommandPoolCreateFlags : uint
{
    None = 0x0,

    [NativeName("VK_COMMAND_POOL_CREATE_TRANSIENT_BIT")]
    TransientBit = 0x1,

    [NativeName("VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT")]
    ResetCommandBufferBit = 0x2,

    [NativeName("VK_COMMAND_POOL_CREATE_PROTECTED_BIT")]
    ProtectedBit = 0x4,
}
