// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkBuildMicromapFlagsEXT")]
    public enum BuildMicromapFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PreferFastTraceBitExt\"")]
        [NativeName("Name", "VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT")]
        BuildMicromapPreferFastTraceBitExt = 1,
        [Obsolete("Deprecated in favour of \"PreferFastBuildBitExt\"")]
        [NativeName("Name", "VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT")]
        BuildMicromapPreferFastBuildBitExt = 2,
        [Obsolete("Deprecated in favour of \"AllowCompactionBitExt\"")]
        [NativeName("Name", "VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT")]
        BuildMicromapAllowCompactionBitExt = 4,
        [NativeName("Name", "VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT")]
        PreferFastTraceBitExt = 1,
        [NativeName("Name", "VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT")]
        PreferFastBuildBitExt = 2,
        [NativeName("Name", "VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT")]
        AllowCompactionBitExt = 4,
    }
}
