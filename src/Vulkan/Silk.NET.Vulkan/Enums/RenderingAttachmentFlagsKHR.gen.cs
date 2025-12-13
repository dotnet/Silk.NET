// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkRenderingAttachmentFlagsKHR")]
    public enum RenderingAttachmentFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"InputAttachmentFeedbackBitKhr\"")]
        [NativeName("Name", "VK_RENDERING_ATTACHMENT_INPUT_ATTACHMENT_FEEDBACK_BIT_KHR")]
        RenderingAttachmentInputAttachmentFeedbackBitKhr = 1,
        [Obsolete("Deprecated in favour of \"ResolveSkipTransferFunctionBitKhr\"")]
        [NativeName("Name", "VK_RENDERING_ATTACHMENT_RESOLVE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
        RenderingAttachmentResolveSkipTransferFunctionBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ResolveEnableTransferFunctionBitKhr\"")]
        [NativeName("Name", "VK_RENDERING_ATTACHMENT_RESOLVE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
        RenderingAttachmentResolveEnableTransferFunctionBitKhr = 4,
        [NativeName("Name", "VK_RENDERING_ATTACHMENT_INPUT_ATTACHMENT_FEEDBACK_BIT_KHR")]
        InputAttachmentFeedbackBitKhr = 1,
        [NativeName("Name", "VK_RENDERING_ATTACHMENT_RESOLVE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
        ResolveSkipTransferFunctionBitKhr = 2,
        [NativeName("Name", "VK_RENDERING_ATTACHMENT_RESOLVE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
        ResolveEnableTransferFunctionBitKhr = 4,
    }
}
