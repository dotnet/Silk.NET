// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ShaderType")]
[Transformed]
public enum ShaderType : uint
{
    [NativeName("GL_FRAGMENT_SHADER")]
    FragmentShader = unchecked((uint)0x8B30),

    [NativeName("GL_VERTEX_SHADER")]
    VertexShader = unchecked((uint)0x8B31),

    [NativeName("GL_GEOMETRY_SHADER")]
    GeometryShader = unchecked((uint)0x8DD9),

    [NativeName("GL_TESS_EVALUATION_SHADER")]
    TessEvaluationShader = unchecked((uint)0x8E87),

    [NativeName("GL_TESS_CONTROL_SHADER")]
    TessControlShader = unchecked((uint)0x8E88),

    [NativeName("GL_COMPUTE_SHADER")]
    ComputeShader = unchecked((uint)0x91B9),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAGMENT_SHADER_ARB")]
    FragmentShaderarb = unchecked((uint)0x8B30),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_SHADER_ARB")]
    VertexShaderarb = unchecked((uint)0x8B31),
}
