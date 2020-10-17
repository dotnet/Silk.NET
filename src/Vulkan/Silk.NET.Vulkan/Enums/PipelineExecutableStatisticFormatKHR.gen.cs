// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineExecutableStatisticFormatKHR")]
    public enum PipelineExecutableStatisticFormatKHR
    {
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR")]
        PipelineExecutableStatisticFormatBool32Khr = 0,
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR")]
        PipelineExecutableStatisticFormatInt64Khr = 1,
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR")]
        PipelineExecutableStatisticFormatUint64Khr = 2,
        [NativeName("Name", "VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR")]
        PipelineExecutableStatisticFormatFloat64Khr = 3,
    }
}
