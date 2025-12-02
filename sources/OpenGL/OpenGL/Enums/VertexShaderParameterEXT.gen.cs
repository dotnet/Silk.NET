// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VertexShaderParameterEXT")]
public enum VertexShaderParameterEXT : uint
{
    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_CURRENT_VERTEX_EXT")]
    CurrentVertex = unchecked((uint)0x87E2),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_MVP_MATRIX_EXT")]
    MvpMatrix = unchecked((uint)0x87E3),
}
