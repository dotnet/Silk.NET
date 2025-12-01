// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CombinerPortionNV")]
public enum CombinerPortionNV : uint
{
    [NativeName("GL_ALPHA")]
    Alpha = unchecked((uint)0x1906),

    [NativeName("GL_RGB")]
    Rgb = unchecked((uint)0x1907),
}
