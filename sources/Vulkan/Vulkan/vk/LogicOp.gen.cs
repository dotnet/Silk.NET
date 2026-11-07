// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLogicOp")]
public enum LogicOp : uint
{
    [NativeName("VK_LOGIC_OP_CLEAR")]
    Clear = 0,

    [NativeName("VK_LOGIC_OP_AND")]
    And = 1,

    [NativeName("VK_LOGIC_OP_AND_REVERSE")]
    AndReverse = 2,

    [NativeName("VK_LOGIC_OP_COPY")]
    Copy = 3,

    [NativeName("VK_LOGIC_OP_AND_INVERTED")]
    AndInverted = 4,

    [NativeName("VK_LOGIC_OP_NO_OP")]
    NoOp = 5,

    [NativeName("VK_LOGIC_OP_XOR")]
    Xor = 6,

    [NativeName("VK_LOGIC_OP_OR")]
    Or = 7,

    [NativeName("VK_LOGIC_OP_NOR")]
    Nor = 8,

    [NativeName("VK_LOGIC_OP_EQUIVALENT")]
    Equivalent = 9,

    [NativeName("VK_LOGIC_OP_INVERT")]
    Invert = 10,

    [NativeName("VK_LOGIC_OP_OR_REVERSE")]
    OrReverse = 11,

    [NativeName("VK_LOGIC_OP_COPY_INVERTED")]
    CopyInverted = 12,

    [NativeName("VK_LOGIC_OP_OR_INVERTED")]
    OrInverted = 13,

    [NativeName("VK_LOGIC_OP_NAND")]
    Nand = 14,

    [NativeName("VK_LOGIC_OP_SET")]
    Set = 15,
}
