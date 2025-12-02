// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramTarget")]
public enum ProgramTarget : uint
{
    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_FRAGMENT_PROGRAM_ARB")]
    FragmentProgramARB = unchecked((uint)0x8804),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_VERTEX_PROGRAM_ARB")]
    VertexProgramARB = unchecked((uint)0x8620),

    [NameAffix("Suffix", "ATI", 0)]
    [NativeName("GL_TEXT_FRAGMENT_SHADER_ATI")]
    TextFragmentShaderATI = unchecked((uint)0x8200),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COMPUTE_PROGRAM_NV")]
    ComputeProgramNV = unchecked((uint)0x90FB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GEOMETRY_PROGRAM_NV")]
    GeometryProgramNV = unchecked((uint)0x8C26),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TESS_CONTROL_PROGRAM_NV")]
    TessControlProgramNV = unchecked((uint)0x891E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TESS_EVALUATION_PROGRAM_NV")]
    TessEvaluationProgramNV = unchecked((uint)0x891F),
}
