// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CombinerStageNV")]
public enum CombinerStageNV : uint
{
    [NativeName("GL_COMBINER0_NV")]
    Combiner0NV = unchecked((uint)0x8550),

    [NativeName("GL_COMBINER1_NV")]
    Combiner1NV = unchecked((uint)0x8551),

    [NativeName("GL_COMBINER2_NV")]
    Combiner2NV = unchecked((uint)0x8552),

    [NativeName("GL_COMBINER3_NV")]
    Combiner3NV = unchecked((uint)0x8553),

    [NativeName("GL_COMBINER4_NV")]
    Combiner4NV = unchecked((uint)0x8554),

    [NativeName("GL_COMBINER5_NV")]
    Combiner5NV = unchecked((uint)0x8555),

    [NativeName("GL_COMBINER6_NV")]
    Combiner6NV = unchecked((uint)0x8556),

    [NativeName("GL_COMBINER7_NV")]
    Combiner7NV = unchecked((uint)0x8557),
}
