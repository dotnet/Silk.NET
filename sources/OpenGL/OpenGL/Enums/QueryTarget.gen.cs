// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("QueryTarget")]
public enum QueryTarget : uint
{
    [NativeName("GL_SAMPLES_PASSED")]
    SamplesPassed = 35092,

    [NativeName("GL_PRIMITIVES_GENERATED")]
    PrimitivesGenerated = 35975,

    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN")]
    TransformFeedbackPrimitivesWritten = 35976,

    [NativeName("GL_ANY_SAMPLES_PASSED")]
    AnySamplesPassed = 35887,

    [NativeName("GL_TIME_ELAPSED")]
    TimeElapsed = 35007,

    [NativeName("GL_ANY_SAMPLES_PASSED_CONSERVATIVE")]
    AnySamplesPassedConservative = 36202,

    [NativeName("GL_VERTICES_SUBMITTED")]
    VerticesSubmitted = 33518,

    [NativeName("GL_PRIMITIVES_SUBMITTED")]
    PrimitivesSubmitted = 33519,

    [NativeName("GL_VERTEX_SHADER_INVOCATIONS")]
    VertexShaderInvocations = 33520,

    [NativeName("GL_TRANSFORM_FEEDBACK_OVERFLOW")]
    TransformFeedbackOverflow = 33516,
}
