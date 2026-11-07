// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceCounterScopeKHR")]
public enum PerformanceCounterScopeKHR : uint
{
    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR")]
    CommandBuffer = 0,

    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR")]
    RenderPass = 1,

    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR")]
    Command = 2,
}
