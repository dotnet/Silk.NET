// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRayTracingInvocationReorderModeEXT")]
    public enum RayTracingInvocationReorderModeEXT : int
    {
        [Obsolete("Deprecated in favour of \"NoneExt\"")]
        [NativeName("Name", "VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_EXT")]
        RayTracingInvocationReorderModeNoneExt = 0,
        [Obsolete("Deprecated in favour of \"ReorderExt\"")]
        [NativeName("Name", "VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_EXT")]
        RayTracingInvocationReorderModeReorderExt = 1,
        [NativeName("Name", "VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_EXT")]
        NoneExt = 0,
        [NativeName("Name", "VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_EXT")]
        ReorderExt = 1,
    }
}
