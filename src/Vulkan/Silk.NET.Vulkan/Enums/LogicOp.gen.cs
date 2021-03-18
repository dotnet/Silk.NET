// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLogicOp")]
    public enum LogicOp : int
    {
        [NativeName("Name", "VK_LOGIC_OP_CLEAR")]
        Clear = 0,
        [NativeName("Name", "VK_LOGIC_OP_AND")]
        And = 1,
        [NativeName("Name", "VK_LOGIC_OP_AND_REVERSE")]
        AndReverse = 2,
        [NativeName("Name", "VK_LOGIC_OP_COPY")]
        Copy = 3,
        [NativeName("Name", "VK_LOGIC_OP_AND_INVERTED")]
        AndInverted = 4,
        [NativeName("Name", "VK_LOGIC_OP_NO_OP")]
        NoOp = 5,
        [NativeName("Name", "VK_LOGIC_OP_XOR")]
        Xor = 6,
        [NativeName("Name", "VK_LOGIC_OP_OR")]
        Or = 7,
        [NativeName("Name", "VK_LOGIC_OP_NOR")]
        Nor = 8,
        [NativeName("Name", "VK_LOGIC_OP_EQUIVALENT")]
        Equivalent = 9,
        [NativeName("Name", "VK_LOGIC_OP_INVERT")]
        Invert = 10,
        [NativeName("Name", "VK_LOGIC_OP_OR_REVERSE")]
        OrReverse = 11,
        [NativeName("Name", "VK_LOGIC_OP_COPY_INVERTED")]
        CopyInverted = 12,
        [NativeName("Name", "VK_LOGIC_OP_OR_INVERTED")]
        OrInverted = 13,
        [NativeName("Name", "VK_LOGIC_OP_NAND")]
        Nand = 14,
        [NativeName("Name", "VK_LOGIC_OP_SET")]
        Set = 15,
    }
}
