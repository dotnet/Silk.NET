// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCompareOp")]
public enum CompareOp : uint
{
    [NativeName("VK_COMPARE_OP_NEVER")]
    Never = 0,

    [NativeName("VK_COMPARE_OP_LESS")]
    Less = 1,

    [NativeName("VK_COMPARE_OP_EQUAL")]
    Equal = 2,

    [NativeName("VK_COMPARE_OP_LESS_OR_EQUAL")]
    LessOrEqual = 3,

    [NativeName("VK_COMPARE_OP_GREATER")]
    Greater = 4,

    [NativeName("VK_COMPARE_OP_NOT_EQUAL")]
    NotEqual = 5,

    [NativeName("VK_COMPARE_OP_GREATER_OR_EQUAL")]
    GreaterOrEqual = 6,

    [NativeName("VK_COMPARE_OP_ALWAYS")]
    Always = 7,
}
