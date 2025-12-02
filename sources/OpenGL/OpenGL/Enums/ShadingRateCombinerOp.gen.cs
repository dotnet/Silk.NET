// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ShadingRateCombinerOp")]
public enum ShadingRateCombinerOp : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_EXT")]
    KeepEXT = unchecked((uint)0x96D2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_EXT")]
    ReplaceEXT = unchecked((uint)0x96D3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_EXT")]
    MinEXT = unchecked((uint)0x96D4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_EXT")]
    MaxEXT = unchecked((uint)0x96D5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_EXT")]
    MulEXT = unchecked((uint)0x96D6),
}
