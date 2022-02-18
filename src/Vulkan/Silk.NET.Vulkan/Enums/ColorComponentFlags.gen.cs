// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkColorComponentFlags")]
    public enum ColorComponentFlags : int
    {
        [NativeName("Name", "VK_COLOR_COMPONENT_R_BIT")]
        ColorComponentRBit = 1,
        [NativeName("Name", "VK_COLOR_COMPONENT_G_BIT")]
        ColorComponentGBit = 2,
        [NativeName("Name", "VK_COLOR_COMPONENT_B_BIT")]
        ColorComponentBBit = 4,
        [NativeName("Name", "VK_COLOR_COMPONENT_A_BIT")]
        ColorComponentABit = 8,
    }
}
