// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkOpacityMicromapSpecialIndexKHR")]
public enum OpacityMicromapSpecialIndexKHR
{
    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_KHR")]
    FullyTransparent = -1,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_KHR")]
    FullyOpaque = -2,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_KHR")]
    FullyUnknownTransparent = -3,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_KHR")]
    FullyUnknownOpaque = -4,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_CLUSTER_GEOMETRY_DISABLE_OPACITY_MICROMAP_NV")]
    ClusterGeometryDisableOpacityMicromapNV = -5,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT")]
    FullyTransparentEXT = FullyTransparent,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT")]
    FullyOpaqueEXT = FullyOpaque,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT")]
    FullyUnknownTransparentEXT = FullyUnknownTransparent,

    [NativeName("VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT")]
    FullyUnknownOpaqueEXT = FullyUnknownOpaque,
}
