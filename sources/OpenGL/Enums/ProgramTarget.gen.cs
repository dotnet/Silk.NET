// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum ProgramTarget
{
    FragmentProgramARB = 0x8804,
    VertexProgramARB = 0x8620,
    TextFragmentShaderATI = 0x8200,
    ComputeProgramNV = 0x90FB,
    GeometryProgramNV = 0x8C26,
    TessControlProgramNV = 0x891E,
    TessEvaluationProgramNV = 0x891F
}
