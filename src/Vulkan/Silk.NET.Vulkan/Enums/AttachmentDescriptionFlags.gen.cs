// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAttachmentDescriptionFlags")]
    public enum AttachmentDescriptionFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"MayAliasBit\"")]
        [NativeName("Name", "VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT")]
        AttachmentDescriptionMayAliasBit = 1,
        [Obsolete("Deprecated in favour of \"ResolveSkipTransferFunctionBitKhr\"")]
        [NativeName("Name", "VK_ATTACHMENT_DESCRIPTION_RESOLVE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
        AttachmentDescriptionResolveSkipTransferFunctionBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ResolveEnableTransferFunctionBitKhr\"")]
        [NativeName("Name", "VK_ATTACHMENT_DESCRIPTION_RESOLVE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
        AttachmentDescriptionResolveEnableTransferFunctionBitKhr = 4,
        [NativeName("Name", "VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT")]
        MayAliasBit = 1,
        [NativeName("Name", "VK_ATTACHMENT_DESCRIPTION_RESOLVE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
        ResolveSkipTransferFunctionBitKhr = 2,
        [NativeName("Name", "VK_ATTACHMENT_DESCRIPTION_RESOLVE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
        ResolveEnableTransferFunctionBitKhr = 4,
    }
}
