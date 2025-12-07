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
    None = 0x0,

    [NativeName("GL_VERTEX_SHADER_BIT")]
    VertexShaderBit = 0x1,

    [NativeName("GL_FRAGMENT_SHADER_BIT")]
    FragmentShaderBit = 0x2,

    [NativeName("GL_GEOMETRY_SHADER_BIT")]
    GeometryShaderBit = 0x4,

    [NativeName("GL_TESS_CONTROL_SHADER_BIT")]
    TessControlShaderBit = 0x8,

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT")]
    TessEvaluationShaderBit = 0x10,

    [NativeName("GL_ALL_SHADER_BITS")]
    AllShaderBits = 0xFFFFFFFF,

    [NativeName("GL_COMPUTE_SHADER_BIT")]
    ComputeShaderBit = 0x20,

    [NativeName("GL_MESH_SHADER_BIT_NV")]
    MeshShaderBitNV = 0x40,

    [NativeName("GL_TASK_SHADER_BIT_NV")]
    TaskShaderBitNV = 0x80,

    [NativeName("GL_GEOMETRY_SHADER_BIT_OES")]
    GeometryShaderBitOES = 0x4,

    [NativeName("GL_TESS_CONTROL_SHADER_BIT_OES")]
    TessControlShaderBitOES = 0x8,

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_OES")]
    TessEvaluationShaderBitOES = 0x10,

    [NativeName("GL_GEOMETRY_SHADER_BIT_EXT")]
    GeometryShaderBitEXT = 0x4,

    [NativeName("GL_VERTEX_SHADER_BIT_EXT")]
    VertexShaderBitEXT = 0x1,

    [NativeName("GL_FRAGMENT_SHADER_BIT_EXT")]
    FragmentShaderBitEXT = 0x2,

    [NativeName("GL_ALL_SHADER_BITS_EXT")]
    AllShaderBitsEXT = 0xFFFFFFFF,

    [NativeName("GL_TESS_CONTROL_SHADER_BIT_EXT")]
    TessControlShaderBitEXT = 0x8,

    [NativeName("GL_TESS_EVALUATION_SHADER_BIT_EXT")]
    TessEvaluationShaderBitEXT = 0x10,
}
