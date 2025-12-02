// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("CombinerVariableNV")]
public enum CombinerVariableNV : uint
{
    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_VARIABLE_A_NV")]
    A = unchecked((uint)0x8523),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_VARIABLE_B_NV")]
    B = unchecked((uint)0x8524),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_VARIABLE_C_NV")]
    C = unchecked((uint)0x8525),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_VARIABLE_D_NV")]
    D = unchecked((uint)0x8526),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_VARIABLE_E_NV")]
    E = unchecked((uint)0x8527),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_VARIABLE_F_NV")]
    F = unchecked((uint)0x8528),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_VARIABLE_G_NV")]
    G = unchecked((uint)0x8529),
}
