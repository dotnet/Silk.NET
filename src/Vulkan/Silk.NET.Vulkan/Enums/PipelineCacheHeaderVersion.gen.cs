// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineCacheHeaderVersion")]
    public enum PipelineCacheHeaderVersion : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_PIPELINE_CACHE_HEADER_VERSION_ONE")]
        One = 1,
        [NativeName("Name", "VK_PIPELINE_CACHE_HEADER_VERSION_DATA_GRAPH_QCOM")]
        DataGraphQCom = 1000629000,
        [NativeName("Name", "VK_PIPELINE_CACHE_HEADER_VERSION_SAFETY_CRITICAL_ONE")]
        SafetyCriticalOne = 1000298001,
    }
}
