// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPresentGravityFlagsEXT")]
    public enum PresentGravityFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"MinBitExt\"")]
        [NativeName("Name", "VK_PRESENT_GRAVITY_MIN_BIT_EXT")]
        PresentGravityMinBitExt = 1,
        [Obsolete("Deprecated in favour of \"MaxBitExt\"")]
        [NativeName("Name", "VK_PRESENT_GRAVITY_MAX_BIT_EXT")]
        PresentGravityMaxBitExt = 2,
        [Obsolete("Deprecated in favour of \"CenteredBitExt\"")]
        [NativeName("Name", "VK_PRESENT_GRAVITY_CENTERED_BIT_EXT")]
        PresentGravityCenteredBitExt = 4,
        [NativeName("Name", "VK_PRESENT_GRAVITY_MIN_BIT_EXT")]
        MinBitExt = 1,
        [NativeName("Name", "VK_PRESENT_GRAVITY_MAX_BIT_EXT")]
        MaxBitExt = 2,
        [NativeName("Name", "VK_PRESENT_GRAVITY_CENTERED_BIT_EXT")]
        CenteredBitExt = 4,
    }
}
