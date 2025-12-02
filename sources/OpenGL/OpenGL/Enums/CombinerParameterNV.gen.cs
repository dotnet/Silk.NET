// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("CombinerParameterNV")]
public enum CombinerParameterNV : uint
{
    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_COMBINER_INPUT_NV")]
    Input = unchecked((uint)0x8542),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_COMBINER_MAPPING_NV")]
    Mapping = unchecked((uint)0x8543),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_COMBINER_COMPONENT_USAGE_NV")]
    ComponentUsage = unchecked((uint)0x8544),
}
