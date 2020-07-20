// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "HintTargetPGI")]
    public enum HintTargetPGI
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
