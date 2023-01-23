// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBuildMicromapModeEXT")]
    public enum BuildMicromapModeEXT : int
    {
        [Obsolete("Deprecated in favour of \"BuildExt\"")]
        [NativeName("Name", "VK_BUILD_MICROMAP_MODE_BUILD_EXT")]
        BuildMicromapModeBuildExt = 0,
        [NativeName("Name", "VK_BUILD_MICROMAP_MODE_BUILD_EXT")]
        BuildExt = 0,
    }
}
