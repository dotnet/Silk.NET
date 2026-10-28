// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAttachmentStoreOp")]
public enum AttachmentStoreOp : uint
{
    [NativeName("VK_ATTACHMENT_STORE_OP_STORE")]
    Store = 0,

    [NativeName("VK_ATTACHMENT_STORE_OP_DONT_CARE")]
    DontCare = 1,

    [NativeName("VK_ATTACHMENT_STORE_OP_NONE")]
    None = 1000301000,

    [NativeName("VK_ATTACHMENT_STORE_OP_NONE_KHR")]
    NoneKHR = None,

    [NativeName("VK_ATTACHMENT_STORE_OP_NONE_QCOM")]
    NoneQCOM = None,

    [NativeName("VK_ATTACHMENT_STORE_OP_NONE_EXT")]
    NoneEXT = None,
}
