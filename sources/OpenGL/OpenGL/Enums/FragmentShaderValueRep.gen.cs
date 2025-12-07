// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FragmentShaderValueRep : uint
{
    None = unchecked((uint)0),
    Red = unchecked((uint)0x1903),
    Green = unchecked((uint)0x1904),
    Blue = unchecked((uint)0x1905),
    Alpha = unchecked((uint)0x1906),
}
