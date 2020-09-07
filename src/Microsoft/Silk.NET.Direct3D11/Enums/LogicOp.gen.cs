// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_LOGIC_OP")]
    public enum LogicOp
    {
        [NativeName("Name", "D3D11_LOGIC_OP_CLEAR")]
        LogicOpClear = 0x0,
        [NativeName("Name", "D3D11_LOGIC_OP_SET")]
        LogicOpSet = 0x1,
        [NativeName("Name", "D3D11_LOGIC_OP_COPY")]
        LogicOpCopy = 0x2,
        [NativeName("Name", "D3D11_LOGIC_OP_COPY_INVERTED")]
        LogicOpCopyInverted = 0x3,
        [NativeName("Name", "D3D11_LOGIC_OP_NOOP")]
        LogicOpNoop = 0x4,
        [NativeName("Name", "D3D11_LOGIC_OP_INVERT")]
        LogicOpInvert = 0x5,
        [NativeName("Name", "D3D11_LOGIC_OP_AND")]
        LogicOpAnd = 0x6,
        [NativeName("Name", "D3D11_LOGIC_OP_NAND")]
        LogicOpNand = 0x7,
        [NativeName("Name", "D3D11_LOGIC_OP_OR")]
        LogicOpOr = 0x8,
        [NativeName("Name", "D3D11_LOGIC_OP_NOR")]
        LogicOpNor = 0x9,
        [NativeName("Name", "D3D11_LOGIC_OP_XOR")]
        LogicOpXor = 0xA,
        [NativeName("Name", "D3D11_LOGIC_OP_EQUIV")]
        LogicOpEquiv = 0xB,
        [NativeName("Name", "D3D11_LOGIC_OP_AND_REVERSE")]
        LogicOpAndReverse = 0xC,
        [NativeName("Name", "D3D11_LOGIC_OP_AND_INVERTED")]
        LogicOpAndInverted = 0xD,
        [NativeName("Name", "D3D11_LOGIC_OP_OR_REVERSE")]
        LogicOpOrReverse = 0xE,
        [NativeName("Name", "D3D11_LOGIC_OP_OR_INVERTED")]
        LogicOpOrInverted = 0xF,
    }
}
