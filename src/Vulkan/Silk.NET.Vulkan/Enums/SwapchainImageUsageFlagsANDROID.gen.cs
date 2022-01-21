// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSwapchainImageUsageFlagsANDROID")]
    public enum SwapchainImageUsageFlagsANDROID : int
    {
        [NativeName("Name", "VK_SWAPCHAIN_IMAGE_USAGE_SHARED_BIT_ANDROID")]
        SwapchainImageUsageSharedBitAndroid = 1,
    }
}
