// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDiscardRectangleModeEXT")]
    public enum DiscardRectangleModeEXT : int
    {
        [Obsolete("Deprecated in favour of \"InclusiveExt\"")]
        [NativeName("Name", "VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT")]
        DiscardRectangleModeInclusiveExt = 0,
        [Obsolete("Deprecated in favour of \"ExclusiveExt\"")]
        [NativeName("Name", "VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT")]
        DiscardRectangleModeExclusiveExt = 1,
        [NativeName("Name", "VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT")]
        InclusiveExt = 0,
        [NativeName("Name", "VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT")]
        ExclusiveExt = 1,
    }
}
