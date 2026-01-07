// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRayTracingLssIndexingModeNV")]
    public enum RayTracingLssIndexingModeNV : int
    {
        [Obsolete("Deprecated in favour of \"ListNV\"")]
        [NativeName("Name", "VK_RAY_TRACING_LSS_INDEXING_MODE_LIST_NV")]
        RayTracingLssIndexingModeListNV = 0,
        [Obsolete("Deprecated in favour of \"SuccessiveNV\"")]
        [NativeName("Name", "VK_RAY_TRACING_LSS_INDEXING_MODE_SUCCESSIVE_NV")]
        RayTracingLssIndexingModeSuccessiveNV = 1,
        [NativeName("Name", "VK_RAY_TRACING_LSS_INDEXING_MODE_LIST_NV")]
        ListNV = 0,
        [NativeName("Name", "VK_RAY_TRACING_LSS_INDEXING_MODE_SUCCESSIVE_NV")]
        SuccessiveNV = 1,
    }
}
