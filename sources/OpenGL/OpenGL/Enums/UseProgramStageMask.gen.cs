// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("UseProgramStageMask")]
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

    [NativeName("GL_MESH_SHADER_BIT_NV")]
    MeshShaderBitNV = unchecked((uint)0x00000040),

    [NativeName("GL_TASK_SHADER_BIT_NV")]
    TaskShaderBitNV = unchecked((uint)0x00000080),

    [NativeName("GL_GEOMETRY_SHADER_BIT_OES")]
    GeometryShaderBitOES = unchecked((uint)0x00000004),

    [NativeName("GL_TESS_CONTROL_SHADER_BIT_OES")]
    TessControlShaderBitOES = unchecked((uint)0x00000008),

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_OES")]
    TessEvaluationShaderBitOES = unchecked((uint)0x00000010),

    [NativeName("GL_GEOMETRY_SHADER_BIT_EXT")]
    GeometryShaderBitEXT = unchecked((uint)0x00000004),

    [NativeName("GL_VERTEX_SHADER_BIT_EXT")]
    VertexShaderBitEXT = unchecked((uint)0x00000001),

    [NativeName("GL_FRAGMENT_SHADER_BIT_EXT")]
    FragmentShaderBitEXT = unchecked((uint)0x00000002),

    [NativeName("GL_ALL_SHADER_BITS_EXT")]
    AllShaderBitsEXT = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_TESS_CONTROL_SHADER_BIT_EXT")]
    TessControlShaderBitEXT = unchecked((uint)0x00000008),

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_EXT")]
    TessEvaluationShaderBitEXT = unchecked((uint)0x00000010),
}
