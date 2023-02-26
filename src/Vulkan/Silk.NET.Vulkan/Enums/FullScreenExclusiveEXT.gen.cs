// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkFullScreenExclusiveEXT")]
    public enum FullScreenExclusiveEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DefaultExt\"")]
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT")]
        FullScreenExclusiveDefaultExt = 0,
        [Obsolete("Deprecated in favour of \"AllowedExt\"")]
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT")]
        FullScreenExclusiveAllowedExt = 1,
        [Obsolete("Deprecated in favour of \"DisallowedExt\"")]
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT")]
        FullScreenExclusiveDisallowedExt = 2,
        [Obsolete("Deprecated in favour of \"ApplicationControlledExt\"")]
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT")]
        FullScreenExclusiveApplicationControlledExt = 3,
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT")]
        DefaultExt = 0,
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT")]
        AllowedExt = 1,
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT")]
        DisallowedExt = 2,
        [NativeName("Name", "VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT")]
        ApplicationControlledExt = 3,
    }
}
