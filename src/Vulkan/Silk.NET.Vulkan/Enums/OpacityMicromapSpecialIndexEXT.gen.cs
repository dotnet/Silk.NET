// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkOpacityMicromapSpecialIndexEXT")]
    public enum OpacityMicromapSpecialIndexEXT : int
    {
        [Obsolete("Deprecated in favour of \"TransparentExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT")]
        OpacityMicromapSpecialIndexFullyTransparentExt = unchecked((int) -1),
        [Obsolete("Deprecated in favour of \"OpaqueExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT")]
        OpacityMicromapSpecialIndexFullyOpaqueExt = unchecked((int) -2),
        [Obsolete("Deprecated in favour of \"UnknownTransparentExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT")]
        OpacityMicromapSpecialIndexFullyUnknownTransparentExt = unchecked((int) -3),
        [Obsolete("Deprecated in favour of \"UnknownOpaqueExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT")]
        OpacityMicromapSpecialIndexFullyUnknownOpaqueExt = unchecked((int) -4),
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT")]
        TransparentExt = unchecked((int) -1),
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT")]
        OpaqueExt = unchecked((int) -2),
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT")]
        UnknownTransparentExt = unchecked((int) -3),
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT")]
        UnknownOpaqueExt = unchecked((int) -4),
    }
}
