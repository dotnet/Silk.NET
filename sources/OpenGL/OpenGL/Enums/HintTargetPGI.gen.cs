// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "PGI", 0)]
[NativeName("HintTargetPGI")]
public enum HintTargetPGI : uint
{
    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_VERTEX_DATA_HINT_PGI")]
    VertexDataHint = unchecked((uint)0x1A22A),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_VERTEX_CONSISTENT_HINT_PGI")]
    VertexConsistentHint = unchecked((uint)0x1A22B),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_MATERIAL_SIDE_HINT_PGI")]
    MaterialSideHint = unchecked((uint)0x1A22C),

    [NameAffix("Suffix", "PGI", -1)]
    [NativeName("GL_MAX_VERTEX_HINT_PGI")]
    MaxVertexHint = unchecked((uint)0x1A22D),
}
