// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL.Legacy
{
    public enum LogicOp
    {
        Clear = 0x1500,
        And = 0x1501,
        AndReverse = 0x1502,
        Copy = 0x1503,
        AndInverted = 0x1504,
        Noop = 0x1505,
        Xor = 0x1506,
        Or = 0x1507,
        Nor = 0x1508,
        Equiv = 0x1509,
        Invert = 0x150A,
        OrReverse = 0x150B,
        CopyInverted = 0x150C,
        OrInverted = 0x150D,
        Nand = 0x150E,
        Set = 0x150F,
    }
}
