// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAttachmentLoadOp")]
    public enum AttachmentLoadOp
    {
        [NativeName("Name", "VK_ATTACHMENT_LOAD_OP_LOAD")]
        Load = 0,
        [NativeName("Name", "VK_ATTACHMENT_LOAD_OP_CLEAR")]
        Clear = 1,
        [NativeName("Name", "VK_ATTACHMENT_LOAD_OP_DONT_CARE")]
        DontCare = 2,
    }
}
