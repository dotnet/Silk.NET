// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_LOGIC_OP")]
    public enum LogicOp : int
    {
        [Obsolete("Deprecated in favour of \"Clear\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_CLEAR")]
        LogicOpClear = 0x0,
        [Obsolete("Deprecated in favour of \"Set\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_SET")]
        LogicOpSet = 0x1,
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_COPY")]
        LogicOpCopy = 0x2,
        [Obsolete("Deprecated in favour of \"CopyInverted\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_COPY_INVERTED")]
        LogicOpCopyInverted = 0x3,
        [Obsolete("Deprecated in favour of \"Noop\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_NOOP")]
        LogicOpNoop = 0x4,
        [Obsolete("Deprecated in favour of \"Invert\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_INVERT")]
        LogicOpInvert = 0x5,
        [Obsolete("Deprecated in favour of \"And\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_AND")]
        LogicOpAnd = 0x6,
        [Obsolete("Deprecated in favour of \"Nand\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_NAND")]
        LogicOpNand = 0x7,
        [Obsolete("Deprecated in favour of \"Or\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_OR")]
        LogicOpOr = 0x8,
        [Obsolete("Deprecated in favour of \"Nor\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_NOR")]
        LogicOpNor = 0x9,
        [Obsolete("Deprecated in favour of \"Xor\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_XOR")]
        LogicOpXor = 0xA,
        [Obsolete("Deprecated in favour of \"Equiv\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_EQUIV")]
        LogicOpEquiv = 0xB,
        [Obsolete("Deprecated in favour of \"AndReverse\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_AND_REVERSE")]
        LogicOpAndReverse = 0xC,
        [Obsolete("Deprecated in favour of \"AndInverted\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_AND_INVERTED")]
        LogicOpAndInverted = 0xD,
        [Obsolete("Deprecated in favour of \"OrReverse\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_OR_REVERSE")]
        LogicOpOrReverse = 0xE,
        [Obsolete("Deprecated in favour of \"OrInverted\"")]
        [NativeName("Name", "D3D12_LOGIC_OP_OR_INVERTED")]
        LogicOpOrInverted = 0xF,
        [NativeName("Name", "D3D12_LOGIC_OP_CLEAR")]
        Clear = 0x0,
        [NativeName("Name", "D3D12_LOGIC_OP_SET")]
        Set = 0x1,
        [NativeName("Name", "D3D12_LOGIC_OP_COPY")]
        Copy = 0x2,
        [NativeName("Name", "D3D12_LOGIC_OP_COPY_INVERTED")]
        CopyInverted = 0x3,
        [NativeName("Name", "D3D12_LOGIC_OP_NOOP")]
        Noop = 0x4,
        [NativeName("Name", "D3D12_LOGIC_OP_INVERT")]
        Invert = 0x5,
        [NativeName("Name", "D3D12_LOGIC_OP_AND")]
        And = 0x6,
        [NativeName("Name", "D3D12_LOGIC_OP_NAND")]
        Nand = 0x7,
        [NativeName("Name", "D3D12_LOGIC_OP_OR")]
        Or = 0x8,
        [NativeName("Name", "D3D12_LOGIC_OP_NOR")]
        Nor = 0x9,
        [NativeName("Name", "D3D12_LOGIC_OP_XOR")]
        Xor = 0xA,
        [NativeName("Name", "D3D12_LOGIC_OP_EQUIV")]
        Equiv = 0xB,
        [NativeName("Name", "D3D12_LOGIC_OP_AND_REVERSE")]
        AndReverse = 0xC,
        [NativeName("Name", "D3D12_LOGIC_OP_AND_INVERTED")]
        AndInverted = 0xD,
        [NativeName("Name", "D3D12_LOGIC_OP_OR_REVERSE")]
        OrReverse = 0xE,
        [NativeName("Name", "D3D12_LOGIC_OP_OR_INVERTED")]
        OrInverted = 0xF,
    }
}
