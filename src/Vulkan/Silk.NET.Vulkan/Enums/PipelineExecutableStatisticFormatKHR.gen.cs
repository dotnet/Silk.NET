// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineExecutableStatisticFormatKHR")]
    public enum PipelineExecutableStatisticFormatKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Bool32Khr\"")]
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR")]
        PipelineExecutableStatisticFormatBool32Khr = 0,
        [Obsolete("Deprecated in favour of \"Int64Khr\"")]
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR")]
        PipelineExecutableStatisticFormatInt64Khr = 1,
        [Obsolete("Deprecated in favour of \"Uint64Khr\"")]
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR")]
        PipelineExecutableStatisticFormatUint64Khr = 2,
        [Obsolete("Deprecated in favour of \"Float64Khr\"")]
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR")]
        PipelineExecutableStatisticFormatFloat64Khr = 3,
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR")]
        Bool32Khr = 0,
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR")]
        Int64Khr = 1,
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR")]
        Uint64Khr = 2,
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR")]
        Float64Khr = 3,
    }
}
