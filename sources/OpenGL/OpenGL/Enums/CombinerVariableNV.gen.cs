// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CombinerVariableNV")]
public enum CombinerVariableNV : uint
{
    [NativeName("GL_VARIABLE_A_NV")]
    Anv = unchecked((uint)0x8523),

    [NativeName("GL_VARIABLE_B_NV")]
    Bnv = unchecked((uint)0x8524),

    [NativeName("GL_VARIABLE_C_NV")]
    Cnv = unchecked((uint)0x8525),

    [NativeName("GL_VARIABLE_D_NV")]
    Dnv = unchecked((uint)0x8526),

    [NativeName("GL_VARIABLE_E_NV")]
    Env = unchecked((uint)0x8527),

    [NativeName("GL_VARIABLE_F_NV")]
    Fnv = unchecked((uint)0x8528),

    [NativeName("GL_VARIABLE_G_NV")]
    Gnv = unchecked((uint)0x8529),
}
