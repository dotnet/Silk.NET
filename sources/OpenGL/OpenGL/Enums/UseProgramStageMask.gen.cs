// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("UseProgramStageMask")]
[Transformed]
[Flags]
public enum UseProgramStageMask : uint
{
    [NativeName("GL_VERTEX_SHADER_BIT")]
    VertexShaderBit = unchecked((uint)0x00000001),

    [NativeName("GL_FRAGMENT_SHADER_BIT")]
    FragmentShaderBit = unchecked((uint)0x00000002),

    [NativeName("GL_GEOMETRY_SHADER_BIT")]
    GeometryShaderBit = unchecked((uint)0x00000004),

    [NativeName("GL_TESS_CONTROL_SHADER_BIT")]
    TessControlShaderBit = unchecked((uint)0x00000008),

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT")]
    TessEvaluationShaderBit = unchecked((uint)0x00000010),

    [NativeName("GL_ALL_SHADER_BITS")]
    AllShaderBits = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_COMPUTE_SHADER_BIT")]
    ComputeShaderBit = unchecked((uint)0x00000020),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MESH_SHADER_BIT_NV")]
    MeshShaderBitnv = unchecked((uint)0x00000040),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TASK_SHADER_BIT_NV")]
    TaskShaderBitnv = unchecked((uint)0x00000080),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_GEOMETRY_SHADER_BIT_OES")]
    GeometryShaderBitoes = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_CONTROL_SHADER_BIT_OES")]
    TessControlShaderBitoes = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_OES")]
    TessEvaluationShaderBitoes = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_GEOMETRY_SHADER_BIT_EXT")]
    GeometryShaderBitext = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_SHADER_BIT_EXT")]
    VertexShaderBitext = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADER_BIT_EXT")]
    FragmentShaderBitext = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALL_SHADER_BITS_EXT")]
    AllShaderBitsext = unchecked((uint)0xFFFFFFFF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_CONTROL_SHADER_BIT_EXT")]
    TessControlShaderBitext = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_EXT")]
    TessEvaluationShaderBitext = unchecked((uint)0x00000010),
}
