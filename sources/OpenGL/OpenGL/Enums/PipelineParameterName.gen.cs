// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PipelineParameterName")]
public enum PipelineParameterName : uint
{
    [NativeName("GL_FRAGMENT_SHADER")]
    FragmentShader = 35632,

    [NativeName("GL_VERTEX_SHADER")]
    VertexShader = 35633,

    [NativeName("GL_INFO_LOG_LENGTH")]
    InfoLogLength = 35716,

    [NativeName("GL_GEOMETRY_SHADER")]
    GeometryShader = 36313,

    [NativeName("GL_TESS_EVALUATION_SHADER")]
    TessEvaluationShader = 36487,

    [NativeName("GL_TESS_CONTROL_SHADER")]
    TessControlShader = 36488,

    [NativeName("GL_ACTIVE_PROGRAM")]
    ActiveProgram = 33369,
}
