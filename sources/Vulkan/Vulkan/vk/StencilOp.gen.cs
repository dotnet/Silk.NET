// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkStencilOp")]
public enum StencilOp : uint
{
    [NativeName("VK_STENCIL_OP_KEEP")]
    Keep = 0,

    [NativeName("VK_STENCIL_OP_ZERO")]
    Zero = 1,

    [NativeName("VK_STENCIL_OP_REPLACE")]
    Replace = 2,

    [NativeName("VK_STENCIL_OP_INCREMENT_AND_CLAMP")]
    IncrementAndClamp = 3,

    [NativeName("VK_STENCIL_OP_DECREMENT_AND_CLAMP")]
    DecrementAndClamp = 4,

    [NativeName("VK_STENCIL_OP_INVERT")]
    Invert = 5,

    [NativeName("VK_STENCIL_OP_INCREMENT_AND_WRAP")]
    IncrementAndWrap = 6,

    [NativeName("VK_STENCIL_OP_DECREMENT_AND_WRAP")]
    DecrementAndWrap = 7,
}
