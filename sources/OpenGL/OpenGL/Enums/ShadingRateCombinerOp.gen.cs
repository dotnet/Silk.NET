// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ShadingRateCombinerOp : uint
{
    KeepEXT = unchecked((uint)0x96D2),
    ReplaceEXT = unchecked((uint)0x96D3),
    MinEXT = unchecked((uint)0x96D4),
    MaxEXT = unchecked((uint)0x96D5),
    MulEXT = unchecked((uint)0x96D6),
}
