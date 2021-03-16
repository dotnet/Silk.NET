// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "HintTargetPGI")]
    public enum HintTargetPGI : int
    {
        [NativeName("Name", "GL_VERTEX_DATA_HINT_PGI")]
        VertexDataHintPgi = 0x1A22A,
        [NativeName("Name", "GL_VERTEX_CONSISTENT_HINT_PGI")]
        VertexConsistentHintPgi = 0x1A22B,
        [NativeName("Name", "GL_MATERIAL_SIDE_HINT_PGI")]
        MaterialSideHintPgi = 0x1A22C,
        [NativeName("Name", "GL_MAX_VERTEX_HINT_PGI")]
        MaxVertexHintPgi = 0x1A22D,
    }
}
