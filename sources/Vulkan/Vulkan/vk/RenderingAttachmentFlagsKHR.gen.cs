// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderingAttachmentFlagsKHR")]
[Flags]
public enum RenderingAttachmentFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_RENDERING_ATTACHMENT_INPUT_ATTACHMENT_FEEDBACK_BIT_KHR")]
    InputAttachmentFeedbackBit = 0x1,

    [NativeName("VK_RENDERING_ATTACHMENT_RESOLVE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
    ResolveSkipTransferFunctionBit = 0x2,

    [NativeName("VK_RENDERING_ATTACHMENT_RESOLVE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
    ResolveEnableTransferFunctionBit = 0x4,
}
