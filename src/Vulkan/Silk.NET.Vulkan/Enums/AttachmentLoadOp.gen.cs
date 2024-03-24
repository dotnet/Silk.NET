// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAttachmentLoadOp")]
    public enum AttachmentLoadOp : int
    {
        [NativeName("Name", "VK_ATTACHMENT_LOAD_OP_LOAD")]
        Load = 0,
        [NativeName("Name", "VK_ATTACHMENT_LOAD_OP_CLEAR")]
        Clear = 1,
        [NativeName("Name", "VK_ATTACHMENT_LOAD_OP_DONT_CARE")]
        DontCare = 2,
        [NativeName("Name", "VK_ATTACHMENT_LOAD_OP_NONE_EXT")]
        NoneExt = 1000400000,
        [NativeName("Name", "VK_ATTACHMENT_LOAD_OP_NONE_KHR")]
        NoneKhr = 1000400000,
    }
}
