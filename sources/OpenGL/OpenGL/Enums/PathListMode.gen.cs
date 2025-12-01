// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathListMode")]
public enum PathListMode : uint
{
    [NativeName("GL_ACCUM_ADJACENT_PAIRS_NV")]
    AccumAdjacentPairsNV = unchecked((uint)0x90AD),

    [NativeName("GL_ADJACENT_PAIRS_NV")]
    AdjacentPairsNV = unchecked((uint)0x90AE),

    [NativeName("GL_FIRST_TO_REST_NV")]
    FirstToRestNV = unchecked((uint)0x90AF),
}
