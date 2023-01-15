// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
        [NativeName("Name", "VK_ATTACHMENT_STORE_OP_NONE_KHR")]
        NoneKhr = 1000301000,
        [NativeName("Name", "VK_ATTACHMENT_STORE_OP_NONE_QCOM")]
        NoneQCom = 1000301000,
        [NativeName("Name", "VK_ATTACHMENT_STORE_OP_NONE_EXT")]
        NoneExt = 1000301000,
        [NativeName("Name", "VK_ATTACHMENT_STORE_OP_NONE")]
        None = 1000301000,
    }
}
