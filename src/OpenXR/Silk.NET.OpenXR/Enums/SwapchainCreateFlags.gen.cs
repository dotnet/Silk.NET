// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    [NativeName("Name", "XrSwapchainCreateFlags")]
    public enum SwapchainCreateFlags : int
    {
        [NativeName("Name", "XR_SWAPCHAIN_CREATE_PROTECTED_CONTENT_BIT")]
        SwapchainCreateProtectedContentBit = 1,
        [NativeName("Name", "XR_SWAPCHAIN_CREATE_STATIC_IMAGE_BIT")]
        SwapchainCreateStaticImageBit = 2,
    }
}
