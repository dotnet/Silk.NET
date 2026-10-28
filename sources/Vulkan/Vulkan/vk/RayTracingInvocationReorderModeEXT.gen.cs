// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRayTracingInvocationReorderModeEXT")]
public enum RayTracingInvocationReorderModeEXT : uint
{
    [NativeName("VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_EXT")]
    None = 0,

    [NativeName("VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_EXT")]
    Reorder = 1,

    [NativeName("VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV")]
    NoneNV = None,

    [NativeName("VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV")]
    ReorderNV = Reorder,
}
