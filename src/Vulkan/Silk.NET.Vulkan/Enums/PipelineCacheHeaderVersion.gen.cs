// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineCacheHeaderVersion")]
    public enum PipelineCacheHeaderVersion : int
    {
        [NativeName("Name", "VK_PIPELINE_CACHE_HEADER_VERSION_ONE")]
        One = 1,
        [NativeName("Name", "VK_PIPELINE_CACHE_HEADER_VERSION_SAFETY_CRITICAL_ONE")]
        SafetyCriticalOne = 1000298001,
    }
}
