// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum UniformBlockPName
{
    Binding = 0x8A3F,
    DataSize = 0x8A40,
    NameLength = 0x8A41,
    ActiveUniforms = 0x8A42,
    ActiveUniformIndices = 0x8A43,
    ReferencedByVertexShader = 0x8A44,
    ReferencedByGeometryShader = 0x8A45,
    ReferencedByFragmentShader = 0x8A46,
    ReferencedByTessControlShader = 0x84F0,
    ReferencedByTessEvaluationShader = 0x84F1,
    ReferencedByComputeShader = 0x90EC
}
