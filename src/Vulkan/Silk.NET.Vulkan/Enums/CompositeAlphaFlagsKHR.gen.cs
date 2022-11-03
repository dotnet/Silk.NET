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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"OpaqueBitKhr\"")]
        [NativeName("Name", "VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR")]
        CompositeAlphaOpaqueBitKhr = 1,
        [Obsolete("Deprecated in favour of \"PreMultipliedBitKhr\"")]
        [NativeName("Name", "VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR")]
        CompositeAlphaPreMultipliedBitKhr = 2,
        [Obsolete("Deprecated in favour of \"PostMultipliedBitKhr\"")]
        [NativeName("Name", "VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR")]
        CompositeAlphaPostMultipliedBitKhr = 4,
        [Obsolete("Deprecated in favour of \"InheritBitKhr\"")]
        [NativeName("Name", "VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR")]
        CompositeAlphaInheritBitKhr = 8,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR")]
        OpaqueBitKhr = 1,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR")]
        PreMultipliedBitKhr = 2,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR")]
        PostMultipliedBitKhr = 4,
        [NativeName("Name", "VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR")]
        InheritBitKhr = 8,
    }
}
