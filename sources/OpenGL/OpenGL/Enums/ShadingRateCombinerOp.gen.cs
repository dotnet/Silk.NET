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
    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_EXT")]
    KeepEXT = 38610,

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_EXT")]
    ReplaceEXT = 38611,

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_EXT")]
    MinEXT = 38612,

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_EXT")]
    MaxEXT = 38613,

    [NativeName("GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_EXT")]
    MulEXT = 38614,
}
