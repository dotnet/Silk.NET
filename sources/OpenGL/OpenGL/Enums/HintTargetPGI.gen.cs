// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("HintTargetPGI")]
public enum HintTargetPGI : uint
{
    [NativeName("GL_VERTEX_DATA_HINT_PGI")]
    VertexDataHint = 107050,

    [NativeName("GL_VERTEX_CONSISTENT_HINT_PGI")]
    VertexConsistentHint = 107051,

    [NativeName("GL_MATERIAL_SIDE_HINT_PGI")]
    MaterialSideHint = 107052,

    [NativeName("GL_MAX_VERTEX_HINT_PGI")]
    MaxVertexHint = 107053,
}
