// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDisplayPlaneAlphaFlagsKHR")]
    public enum DisplayPlaneAlphaFlagsKHR : int
    {
        [NativeName("Name", "VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR")]
        DisplayPlaneAlphaOpaqueBitKhr = 1,
        [NativeName("Name", "VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR")]
        DisplayPlaneAlphaGlobalBitKhr = 2,
        [NativeName("Name", "VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR")]
        DisplayPlaneAlphaPerPixelBitKhr = 4,
        [NativeName("Name", "VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR")]
        DisplayPlaneAlphaPerPixelPremultipliedBitKhr = 8,
    }
}
