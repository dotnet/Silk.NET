// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassContents")]
public enum SubpassContents : uint
{
    [NativeName("VK_SUBPASS_CONTENTS_INLINE")]
    Inline = 0,

    [NativeName("VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS")]
    SecondaryCommandBuffers = 1,

    [NativeName("VK_SUBPASS_CONTENTS_INLINE_AND_SECONDARY_COMMAND_BUFFERS_KHR")]
    InlineAndSecondaryCommandBuffersKHR = 1000451000,

    [NativeName("VK_SUBPASS_CONTENTS_INLINE_AND_SECONDARY_COMMAND_BUFFERS_EXT")]
    InlineAndSecondaryCommandBuffersEXT = InlineAndSecondaryCommandBuffersKHR,
}
