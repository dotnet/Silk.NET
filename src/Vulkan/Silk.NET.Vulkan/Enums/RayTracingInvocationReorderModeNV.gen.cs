// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRayTracingInvocationReorderModeNV")]
    public enum RayTracingInvocationReorderModeNV : int
    {
        [Obsolete("Deprecated in favour of \"NoneNV\"")]
        [NativeName("Name", "VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV")]
        RayTracingInvocationReorderModeNoneNV = 0,
        [Obsolete("Deprecated in favour of \"ReorderNV\"")]
        [NativeName("Name", "VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV")]
        RayTracingInvocationReorderModeReorderNV = 1,
        [NativeName("Name", "VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV")]
        NoneNV = 0,
        [NativeName("Name", "VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV")]
        ReorderNV = 1,
    }
}
