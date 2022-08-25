// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFilter")]
    public enum Filter : int
    {
        [NativeName("Name", "VK_FILTER_NEAREST")]
        Nearest = 0,
        [NativeName("Name", "VK_FILTER_LINEAR")]
        Linear = 1,
        [NativeName("Name", "VK_FILTER_CUBIC_IMG")]
        CubicImg = 1000015000,
        [NativeName("Name", "VK_FILTER_CUBIC_EXT")]
        CubicExt = 1000015000,
    }
}
