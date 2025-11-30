// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("QueryTarget")]
[Transformed]
public enum QueryTarget : uint
{
    [NativeName("GL_SAMPLES_PASSED")]
    SamplesPassed = unchecked((uint)0x8914),

    [NativeName("GL_PRIMITIVES_GENERATED")]
    PrimitivesGenerated = unchecked((uint)0x8C87),

    [NativeName("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN")]
    TransformFeedbackPrimitivesWritten = unchecked((uint)0x8C88),

    [NativeName("GL_ANY_SAMPLES_PASSED")]
    AnySamplesPassed = unchecked((uint)0x8C2F),

    [NativeName("GL_TIME_ELAPSED")]
    TimeElapsed = unchecked((uint)0x88BF),

    [NativeName("GL_ANY_SAMPLES_PASSED_CONSERVATIVE")]
    AnySamplesPassedConservative = unchecked((uint)0x8D6A),

    [NativeName("GL_VERTICES_SUBMITTED")]
    VerticesSubmitted = unchecked((uint)0x82EE),

    [NativeName("GL_PRIMITIVES_SUBMITTED")]
    PrimitivesSubmitted = unchecked((uint)0x82EF),

    [NativeName("GL_VERTEX_SHADER_INVOCATIONS")]
    VertexShaderInvocations = unchecked((uint)0x82F0),

    [NativeName("GL_TRANSFORM_FEEDBACK_OVERFLOW")]
    TransformFeedbackOverflow = unchecked((uint)0x82EC),
}
