// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAttachmentStoreOp")]
    public enum AttachmentStoreOp : int
    {
        [NativeName("Name", "VK_ATTACHMENT_STORE_OP_STORE")]
        Store = 0,
        [NativeName("Name", "VK_ATTACHMENT_STORE_OP_DONT_CARE")]
        DontCare = 1,
        [NativeName("Name", "VK_ATTACHMENT_STORE_OP_NONE_QCOM")]
        NoneQCom = 1000301000,
    }
}
