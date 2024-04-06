// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum QueryTarget
{
    SamplesPassed = 0x8914,
    PrimitivesGenerated = 0x8C87,
    TransformFeedbackPrimitivesWritten = 0x8C88,
    AnySamplesPassed = 0x8C2F,
    TimeElapsed = 0x88BF,
    AnySamplesPassedConservative = 0x8D6A,
    VerticesSubmitted = 0x82EE,
    PrimitivesSubmitted = 0x82EF,
    VertexShaderInvocations = 0x82F0,
    TransformFeedbackOverflow = 0x82EC
}
