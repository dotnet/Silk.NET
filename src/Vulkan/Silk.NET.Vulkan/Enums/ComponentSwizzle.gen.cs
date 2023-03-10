// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkComponentSwizzle")]
    public enum ComponentSwizzle : int
    {
        [NativeName("Name", "VK_COMPONENT_SWIZZLE_IDENTITY")]
        Identity = 0,
        [NativeName("Name", "VK_COMPONENT_SWIZZLE_ZERO")]
        Zero = 1,
        [NativeName("Name", "VK_COMPONENT_SWIZZLE_ONE")]
        One = 2,
        [NativeName("Name", "VK_COMPONENT_SWIZZLE_R")]
        R = 3,
        [NativeName("Name", "VK_COMPONENT_SWIZZLE_G")]
        G = 4,
        [NativeName("Name", "VK_COMPONENT_SWIZZLE_B")]
        B = 5,
        [NativeName("Name", "VK_COMPONENT_SWIZZLE_A")]
        A = 6,
    }
}
