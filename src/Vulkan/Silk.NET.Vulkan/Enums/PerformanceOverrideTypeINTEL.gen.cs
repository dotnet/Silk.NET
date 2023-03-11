// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPerformanceOverrideTypeINTEL")]
    public enum PerformanceOverrideTypeINTEL : int
    {
        [Obsolete("Deprecated in favour of \"NullHardwareIntel\"")]
        [NativeName("Name", "VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL")]
        PerformanceOverrideTypeNullHardwareIntel = 0,
        [Obsolete("Deprecated in favour of \"FlushGpuCachesIntel\"")]
        [NativeName("Name", "VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL")]
        PerformanceOverrideTypeFlushGpuCachesIntel = 1,
        [NativeName("Name", "VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL")]
        NullHardwareIntel = 0,
        [NativeName("Name", "VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL")]
        FlushGpuCachesIntel = 1,
    }
}
