// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum AccumOp : uint
{
    Accum = unchecked((uint)0x0100),
    Load = unchecked((uint)0x0101),
    Return = unchecked((uint)0x0102),
    Mult = unchecked((uint)0x0103),
    Add = unchecked((uint)0x0104),
}
