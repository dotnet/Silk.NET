// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSurfaceTransformFlagsKHR")]
    public enum SurfaceTransformFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"IdentityBitKhr\"")]
        [NativeName("Name", "VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR")]
        SurfaceTransformIdentityBitKhr = 1,
        [Obsolete("Deprecated in favour of \"Rotate90BitKhr\"")]
        [NativeName("Name", "VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR")]
        SurfaceTransformRotate90BitKhr = 2,
        [Obsolete("Deprecated in favour of \"Rotate180BitKhr\"")]
        [NativeName("Name", "VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR")]
        SurfaceTransformRotate180BitKhr = 4,
        [Obsolete("Deprecated in favour of \"Rotate270BitKhr\"")]
        [NativeName("Name", "VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR")]
        SurfaceTransformRotate270BitKhr = 8,
        [Obsolete("Deprecated in favour of \"HorizontalMirrorBitKhr\"")]
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR")]
        SurfaceTransformHorizontalMirrorBitKhr = 16,
        [Obsolete("Deprecated in favour of \"HorizontalMirrorRotate90BitKhr\"")]
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR")]
        SurfaceTransformHorizontalMirrorRotate90BitKhr = 32,
        [Obsolete("Deprecated in favour of \"HorizontalMirrorRotate180BitKhr\"")]
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR")]
        SurfaceTransformHorizontalMirrorRotate180BitKhr = 64,
        [Obsolete("Deprecated in favour of \"HorizontalMirrorRotate270BitKhr\"")]
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR")]
        SurfaceTransformHorizontalMirrorRotate270BitKhr = 128,
        [Obsolete("Deprecated in favour of \"InheritBitKhr\"")]
        [NativeName("Name", "VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR")]
        SurfaceTransformInheritBitKhr = 256,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR")]
        IdentityBitKhr = 1,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR")]
        Rotate90BitKhr = 2,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR")]
        Rotate180BitKhr = 4,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR")]
        Rotate270BitKhr = 8,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR")]
        HorizontalMirrorBitKhr = 16,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR")]
        HorizontalMirrorRotate90BitKhr = 32,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR")]
        HorizontalMirrorRotate180BitKhr = 64,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR")]
        HorizontalMirrorRotate270BitKhr = 128,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR")]
        InheritBitKhr = 256,
    }
}
