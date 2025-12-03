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
    Combiner0 = unchecked((uint)0x8550),

    [NativeName("GL_COMBINER1_NV")]
    Combiner1 = unchecked((uint)0x8551),

    [NativeName("GL_COMBINER2_NV")]
    Combiner2 = unchecked((uint)0x8552),

    [NativeName("GL_COMBINER3_NV")]
    Combiner3 = unchecked((uint)0x8553),

    [NativeName("GL_COMBINER4_NV")]
    Combiner4 = unchecked((uint)0x8554),

    [NativeName("GL_COMBINER5_NV")]
    Combiner5 = unchecked((uint)0x8555),

    [NativeName("GL_COMBINER6_NV")]
    Combiner6 = unchecked((uint)0x8556),

    [NativeName("GL_COMBINER7_NV")]
    Combiner7 = unchecked((uint)0x8557),
}
