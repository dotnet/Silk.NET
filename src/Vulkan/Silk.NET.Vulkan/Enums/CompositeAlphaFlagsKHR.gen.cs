// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkCompositeAlphaFlagsKHR")]
    public enum CompositeAlphaFlagsKHR : int
    {
        [NativeName("Name", "VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR")]
        CompositeAlphaOpaqueBitKhr = 1,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR")]
        CompositeAlphaPreMultipliedBitKhr = 2,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR")]
        CompositeAlphaPostMultipliedBitKhr = 4,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR")]
        CompositeAlphaInheritBitKhr = 8,
    }
}
