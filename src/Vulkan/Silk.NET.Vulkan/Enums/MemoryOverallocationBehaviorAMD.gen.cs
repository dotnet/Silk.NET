// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkMemoryOverallocationBehaviorAMD")]
    public enum MemoryOverallocationBehaviorAMD : int
    {
        [Obsolete("Deprecated in favour of \"DefaultAmd\"")]
        [NativeName("Name", "VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD")]
        MemoryOverallocationBehaviorDefaultAmd = 0,
        [Obsolete("Deprecated in favour of \"AllowedAmd\"")]
        [NativeName("Name", "VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD")]
        MemoryOverallocationBehaviorAllowedAmd = 1,
        [Obsolete("Deprecated in favour of \"DisallowedAmd\"")]
        [NativeName("Name", "VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD")]
        MemoryOverallocationBehaviorDisallowedAmd = 2,
        [NativeName("Name", "VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD")]
        DefaultAmd = 0,
        [NativeName("Name", "VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD")]
        AllowedAmd = 1,
        [NativeName("Name", "VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD")]
        DisallowedAmd = 2,
    }
}
