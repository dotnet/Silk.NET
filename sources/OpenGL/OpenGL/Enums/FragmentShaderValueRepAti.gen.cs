// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("FragmentShaderValueRepATI")]
[Transformed]
public enum FragmentShaderValueRepAti : uint
{
    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NativeName("GL_RED")]
    Red = unchecked((uint)0x1903),

    [NativeName("GL_GREEN")]
    Green = unchecked((uint)0x1904),

    [NativeName("GL_BLUE")]
    Blue = unchecked((uint)0x1905),

    [NativeName("GL_ALPHA")]
    Alpha = unchecked((uint)0x1906),
}
