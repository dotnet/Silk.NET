// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum BlendEquationMode
{
    FuncAdd = 0x8006,
    FuncReverseSubtract = 0x800B,
    FuncSubtract = 0x800A,
    MIN = 0x8007,
    MAX = 0x8008,
    MinExt = 0x8007,
    MaxExt = 0x8008,
    FuncAddEXT = 0x8006,
    FuncSubtractEXT = 0x800A,
    FuncReverseSubtractEXT = 0x800B,
    AlphaMinSGIX = 0x8320,
    AlphaMaxSGIX = 0x8321
}
