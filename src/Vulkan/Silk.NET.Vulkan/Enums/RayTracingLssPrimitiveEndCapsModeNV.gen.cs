// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRayTracingLssPrimitiveEndCapsModeNV")]
    public enum RayTracingLssPrimitiveEndCapsModeNV : int
    {
        [Obsolete("Deprecated in favour of \"NoneNV\"")]
        [NativeName("Name", "VK_RAY_TRACING_LSS_PRIMITIVE_END_CAPS_MODE_NONE_NV")]
        RayTracingLssPrimitiveEndCapsModeNoneNV = 0,
        [Obsolete("Deprecated in favour of \"ChainedNV\"")]
        [NativeName("Name", "VK_RAY_TRACING_LSS_PRIMITIVE_END_CAPS_MODE_CHAINED_NV")]
        RayTracingLssPrimitiveEndCapsModeChainedNV = 1,
        [NativeName("Name", "VK_RAY_TRACING_LSS_PRIMITIVE_END_CAPS_MODE_NONE_NV")]
        NoneNV = 0,
        [NativeName("Name", "VK_RAY_TRACING_LSS_PRIMITIVE_END_CAPS_MODE_CHAINED_NV")]
        ChainedNV = 1,
    }
}
