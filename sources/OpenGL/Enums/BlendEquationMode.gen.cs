// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum BlendEquationMode : uint
{
    FuncAdd = unchecked((uint)0x8006),
    FuncReverseSubtract = unchecked((uint)0x800B),
    FuncSubtract = unchecked((uint)0x800A),
    MIN = unchecked((uint)0x8007),
    MAX = unchecked((uint)0x8008),
    MinExt = unchecked((uint)0x8007),
    MaxExt = unchecked((uint)0x8008),
    FuncAddEXT = unchecked((uint)0x8006),
    FuncSubtractEXT = unchecked((uint)0x800A),
    FuncReverseSubtractEXT = unchecked((uint)0x800B),
    AlphaMinSGIX = unchecked((uint)0x8320),
    AlphaMaxSGIX = unchecked((uint)0x8321)
}
