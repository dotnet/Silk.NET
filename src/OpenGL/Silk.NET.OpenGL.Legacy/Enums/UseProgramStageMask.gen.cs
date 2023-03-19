// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [Flags]
    [NativeName("Name", "UseProgramStageMask")]
    public enum UseProgramStageMask : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "GL_VERTEX_SHADER_BIT")]
        VertexShaderBit = 0x1,
        [NativeName("Name", "GL_VERTEX_SHADER_BIT_EXT")]
        VertexShaderBitExt = 0x1,
        [NativeName("Name", "GL_FRAGMENT_SHADER_BIT")]
        FragmentShaderBit = 0x2,
        [NativeName("Name", "GL_FRAGMENT_SHADER_BIT_EXT")]
        FragmentShaderBitExt = 0x2,
        [NativeName("Name", "GL_GEOMETRY_SHADER_BIT")]
        GeometryShaderBit = 0x4,
        [NativeName("Name", "GL_GEOMETRY_SHADER_BIT_EXT")]
        GeometryShaderBitExt = 0x4,
        [NativeName("Name", "GL_GEOMETRY_SHADER_BIT_OES")]
        GeometryShaderBitOes = 0x4,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_BIT")]
        TessControlShaderBit = 0x8,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_BIT_EXT")]
        TessControlShaderBitExt = 0x8,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_BIT_OES")]
        TessControlShaderBitOes = 0x8,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_BIT")]
        TessEvaluationShaderBit = 0x10,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_BIT_EXT")]
        TessEvaluationShaderBitExt = 0x10,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_BIT_OES")]
        TessEvaluationShaderBitOes = 0x10,
        [NativeName("Name", "GL_COMPUTE_SHADER_BIT")]
        ComputeShaderBit = 0x20,
        [NativeName("Name", "GL_MESH_SHADER_BIT_NV")]
        MeshShaderBitNV = 0x40,
        [NativeName("Name", "GL_TASK_SHADER_BIT_NV")]
        TaskShaderBitNV = 0x80,
        [NativeName("Name", "GL_ALL_SHADER_BITS")]
        AllShaderBits = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_ALL_SHADER_BITS_EXT")]
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF),
    }
}
