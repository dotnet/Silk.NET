// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAttachmentLoadOp")]
public enum AttachmentLoadOp : uint
{
    [NativeName("VK_ATTACHMENT_LOAD_OP_LOAD")]
    Load = 0,

    [NativeName("VK_ATTACHMENT_LOAD_OP_CLEAR")]
    Clear = 1,

    [NativeName("VK_ATTACHMENT_LOAD_OP_DONT_CARE")]
    DontCare = 2,

    [NativeName("VK_ATTACHMENT_LOAD_OP_NONE")]
    None = 1000400000,

    [NativeName("VK_ATTACHMENT_LOAD_OP_NONE_EXT")]
    NoneEXT = None,

    [NativeName("VK_ATTACHMENT_LOAD_OP_NONE_KHR")]
    NoneKHR = None,
}
