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
    A = 34083,

    [NativeName("GL_VARIABLE_B_NV")]
    B = 34084,

    [NativeName("GL_VARIABLE_C_NV")]
    C = 34085,

    [NativeName("GL_VARIABLE_D_NV")]
    D = 34086,

    [NativeName("GL_VARIABLE_E_NV")]
    E = 34087,

    [NativeName("GL_VARIABLE_F_NV")]
    F = 34088,

    [NativeName("GL_VARIABLE_G_NV")]
    G = 34089,
}
