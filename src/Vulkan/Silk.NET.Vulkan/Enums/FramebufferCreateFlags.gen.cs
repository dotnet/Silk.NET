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
    [NativeName("Name", "VkFramebufferCreateFlags")]
    public enum FramebufferCreateFlags
    {
        [NativeName("Name", "VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT_KHR")]
        FramebufferCreateImagelessBitKhr = 1,
        [NativeName("Name", "VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT")]
        FramebufferCreateImagelessBit = 1,
    }
}
