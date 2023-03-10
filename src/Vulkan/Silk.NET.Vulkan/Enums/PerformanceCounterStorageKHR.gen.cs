// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceCounterStorageKHR")]
    public enum PerformanceCounterStorageKHR : int
    {
        [Obsolete("Deprecated in favour of \"Int32Khr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR")]
        PerformanceCounterStorageInt32Khr = 0,
        [Obsolete("Deprecated in favour of \"Int64Khr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR")]
        PerformanceCounterStorageInt64Khr = 1,
        [Obsolete("Deprecated in favour of \"Uint32Khr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR")]
        PerformanceCounterStorageUint32Khr = 2,
        [Obsolete("Deprecated in favour of \"Uint64Khr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR")]
        PerformanceCounterStorageUint64Khr = 3,
        [Obsolete("Deprecated in favour of \"Float32Khr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR")]
        PerformanceCounterStorageFloat32Khr = 4,
        [Obsolete("Deprecated in favour of \"Float64Khr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR")]
        PerformanceCounterStorageFloat64Khr = 5,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR")]
        Int32Khr = 0,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR")]
        Int64Khr = 1,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR")]
        Uint32Khr = 2,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR")]
        Uint64Khr = 3,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR")]
        Float32Khr = 4,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR")]
        Float64Khr = 5,
    }
}
