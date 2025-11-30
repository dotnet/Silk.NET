// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("CombinerStageNV")]
[Transformed]
public enum CombinerStageNv : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER0_NV")]
    Combiner0Nv = unchecked((uint)0x8550),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER1_NV")]
    Combiner1Nv = unchecked((uint)0x8551),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER2_NV")]
    Combiner2Nv = unchecked((uint)0x8552),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER3_NV")]
    Combiner3Nv = unchecked((uint)0x8553),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER4_NV")]
    Combiner4Nv = unchecked((uint)0x8554),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER5_NV")]
    Combiner5Nv = unchecked((uint)0x8555),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER6_NV")]
    Combiner6Nv = unchecked((uint)0x8556),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMBINER7_NV")]
    Combiner7Nv = unchecked((uint)0x8557),
}
