// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSubpassContents")]
    public enum SubpassContents
    {
        [NativeName("Name", "VK_SUBPASS_CONTENTS_INLINE")]
        Inline = 0,
        [NativeName("Name", "VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS")]
        SecondaryCommandBuffers = 1,
    }
}
