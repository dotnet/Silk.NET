// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum UniformBlockPName : uint
{
    Binding = unchecked((uint)0x8A3F),
    DataSize = unchecked((uint)0x8A40),
    NameLength = unchecked((uint)0x8A41),
    ActiveUniforms = unchecked((uint)0x8A42),
    ActiveUniformIndices = unchecked((uint)0x8A43),
    ReferencedByVertexShader = unchecked((uint)0x8A44),
    ReferencedByGeometryShader = unchecked((uint)0x8A45),
    ReferencedByFragmentShader = unchecked((uint)0x8A46),
    ReferencedByTessControlShader = unchecked((uint)0x84F0),
    ReferencedByTessEvaluationShader = unchecked((uint)0x84F1),
    ReferencedByComputeShader = unchecked((uint)0x90EC),
}
