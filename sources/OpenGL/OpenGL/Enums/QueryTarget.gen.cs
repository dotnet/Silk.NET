// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum QueryTarget : uint
{
    SamplesPassed = unchecked((uint)0x8914),
    PrimitivesGenerated = unchecked((uint)0x8C87),
    TransformFeedbackPrimitivesWritten = unchecked((uint)0x8C88),
    AnySamplesPassed = unchecked((uint)0x8C2F),
    TimeElapsed = unchecked((uint)0x88BF),
    AnySamplesPassedConservative = unchecked((uint)0x8D6A),
    VerticesSubmitted = unchecked((uint)0x82EE),
    PrimitivesSubmitted = unchecked((uint)0x82EF),
    VertexShaderInvocations = unchecked((uint)0x82F0),
    TransformFeedbackOverflow = unchecked((uint)0x82EC),
}
