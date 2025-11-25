// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ProgramTarget : uint
{
    FragmentProgramARB = unchecked((uint)0x8804),
    VertexProgramARB = unchecked((uint)0x8620),
    TextFragmentShaderATI = unchecked((uint)0x8200),
    ComputeProgramNV = unchecked((uint)0x90FB),
    GeometryProgramNV = unchecked((uint)0x8C26),
    TessControlProgramNV = unchecked((uint)0x891E),
    TessEvaluationProgramNV = unchecked((uint)0x891F),
}
