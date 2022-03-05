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
        [NativeName("Name", "VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR")]
        SurfaceTransformIdentityBitKhr = 1,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR")]
        SurfaceTransformRotate90BitKhr = 2,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR")]
        SurfaceTransformRotate180BitKhr = 4,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR")]
        SurfaceTransformRotate270BitKhr = 8,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR")]
        SurfaceTransformHorizontalMirrorBitKhr = 16,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR")]
        SurfaceTransformHorizontalMirrorRotate90BitKhr = 32,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR")]
        SurfaceTransformHorizontalMirrorRotate180BitKhr = 64,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR")]
        SurfaceTransformHorizontalMirrorRotate270BitKhr = 128,
        [NativeName("Name", "VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR")]
        SurfaceTransformInheritBitKhr = 256,
    }
}
