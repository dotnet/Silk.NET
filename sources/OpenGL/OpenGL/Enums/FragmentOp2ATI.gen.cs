// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FragmentOp2ATI : uint
{
    Add = unchecked((uint)0x8963),
    Mul = unchecked((uint)0x8964),
    Sub = unchecked((uint)0x8965),
    Dot3 = unchecked((uint)0x8966),
    Dot4 = unchecked((uint)0x8967),
}
