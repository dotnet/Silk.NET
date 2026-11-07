// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCommandBufferLevel")]
public enum CommandBufferLevel : uint
{
    [NativeName("VK_COMMAND_BUFFER_LEVEL_PRIMARY")]
    Primary = 0,

    [NativeName("VK_COMMAND_BUFFER_LEVEL_SECONDARY")]
    Secondary = 1,
}
