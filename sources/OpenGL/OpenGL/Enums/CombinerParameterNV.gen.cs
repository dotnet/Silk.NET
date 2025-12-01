// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CombinerParameterNV")]
public enum CombinerParameterNV : uint
{
    [NativeName("GL_COMBINER_INPUT_NV")]
    InputNV = unchecked((uint)0x8542),

    [NativeName("GL_COMBINER_MAPPING_NV")]
    MappingNV = unchecked((uint)0x8543),

    [NativeName("GL_COMBINER_COMPONENT_USAGE_NV")]
    ComponentUsageNV = unchecked((uint)0x8544),
}
