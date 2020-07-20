// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineCacheHeaderVersion")]
    public enum PipelineCacheHeaderVersion
    {
        [NativeName("Name", "VK_PIPELINE_CACHE_HEADER_VERSION_ONE")]
        One = 1,
    }
}
