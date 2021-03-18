// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ShaderType")]
    public enum ShaderType : int
    {
        [NativeName("Name", "GL_FRAGMENT_SHADER")]
        FragmentShader = 0x8B30,
        [NativeName("Name", "GL_FRAGMENT_SHADER_ARB")]
        FragmentShaderArb = 0x8B30,
        [NativeName("Name", "GL_VERTEX_SHADER")]
        VertexShader = 0x8B31,
        [NativeName("Name", "GL_VERTEX_SHADER_ARB")]
        VertexShaderArb = 0x8B31,
        [NativeName("Name", "GL_GEOMETRY_SHADER")]
        GeometryShader = 0x8DD9,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER")]
        TessEvaluationShader = 0x8E87,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER")]
        TessControlShader = 0x8E88,
        [NativeName("Name", "GL_COMPUTE_SHADER")]
        ComputeShader = 0x91B9,
    }
}
