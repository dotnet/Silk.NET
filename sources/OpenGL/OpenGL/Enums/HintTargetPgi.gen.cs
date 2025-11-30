// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "PGI", 0)]
[NativeName("HintTargetPGI")]
[Transformed]
public enum HintTargetPgi : uint
{
    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX_DATA_HINT_PGI")]
    VertexDataHintpgi = unchecked((uint)0x1A22A),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_VERTEX_CONSISTENT_HINT_PGI")]
    VertexConsistentHintpgi = unchecked((uint)0x1A22B),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MATERIAL_SIDE_HINT_PGI")]
    MaterialSideHintpgi = unchecked((uint)0x1A22C),

    [NameAffix("Suffix", "PGI", 0)]
    [NativeName("GL_MAX_VERTEX_HINT_PGI")]
    MaxVertexHintpgi = unchecked((uint)0x1A22D),
}
