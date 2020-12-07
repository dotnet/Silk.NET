// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkSwapchainImageUsageFlagsANDROID")]
    public enum SwapchainImageUsageFlagsANDROID
    {
        [NativeName("Name", "VK_SWAPCHAIN_IMAGE_USAGE_SHARED_BIT_ANDROID")]
        SwapchainImageUsageSharedBitAndroid = 1,
    }
}
