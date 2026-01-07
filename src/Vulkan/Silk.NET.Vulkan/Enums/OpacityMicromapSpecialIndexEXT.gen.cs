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
        [Obsolete("Deprecated in favour of \"FullyTransparentExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT")]
        OpacityMicromapSpecialIndexFullyTransparentExt = unchecked((int) -1),
        [Obsolete("Deprecated in favour of \"FullyOpaqueExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT")]
        OpacityMicromapSpecialIndexFullyOpaqueExt = unchecked((int) -2),
        [Obsolete("Deprecated in favour of \"FullyUnknownTransparentExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT")]
        OpacityMicromapSpecialIndexFullyUnknownTransparentExt = unchecked((int) -3),
        [Obsolete("Deprecated in favour of \"FullyUnknownOpaqueExt\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT")]
        OpacityMicromapSpecialIndexFullyUnknownOpaqueExt = unchecked((int) -4),
        [Obsolete("Deprecated in favour of \"ClusterGeometryDisableOpacityMicromapNV\"")]
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_CLUSTER_GEOMETRY_DISABLE_OPACITY_MICROMAP_NV")]
        OpacityMicromapSpecialIndexClusterGeometryDisableOpacityMicromapNV = unchecked((int) -5),
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT")]
        FullyTransparentExt = unchecked((int) -1),
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT")]
        FullyOpaqueExt = unchecked((int) -2),
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT")]
        FullyUnknownTransparentExt = unchecked((int) -3),
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT")]
        FullyUnknownOpaqueExt = unchecked((int) -4),
        [NativeName("Name", "VK_OPACITY_MICROMAP_SPECIAL_INDEX_CLUSTER_GEOMETRY_DISABLE_OPACITY_MICROMAP_NV")]
        ClusterGeometryDisableOpacityMicromapNV = unchecked((int) -5),
    }
}
