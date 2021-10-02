// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "LogicOp")]
    public enum LogicOp : int
    {
        [NativeName("Name", "GL_CLEAR")]
        Clear = 0x1500,
        [NativeName("Name", "GL_AND")]
        And = 0x1501,
        [NativeName("Name", "GL_AND_REVERSE")]
        AndReverse = 0x1502,
        [NativeName("Name", "GL_COPY")]
        Copy = 0x1503,
        [NativeName("Name", "GL_AND_INVERTED")]
        AndInverted = 0x1504,
        [NativeName("Name", "GL_NOOP")]
        Noop = 0x1505,
        [NativeName("Name", "GL_XOR")]
        Xor = 0x1506,
        [NativeName("Name", "GL_OR")]
        Or = 0x1507,
        [NativeName("Name", "GL_NOR")]
        Nor = 0x1508,
        [NativeName("Name", "GL_EQUIV")]
        Equiv = 0x1509,
        [NativeName("Name", "GL_INVERT")]
        Invert = 0x150A,
        [NativeName("Name", "GL_OR_REVERSE")]
        OrReverse = 0x150B,
        [NativeName("Name", "GL_COPY_INVERTED")]
        CopyInverted = 0x150C,
        [NativeName("Name", "GL_OR_INVERTED")]
        OrInverted = 0x150D,
        [NativeName("Name", "GL_NAND")]
        Nand = 0x150E,
        [NativeName("Name", "GL_SET")]
        Set = 0x150F,
    }
}
