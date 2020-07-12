// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [NativeName("Name", "GLenum")]
    public enum SUN
    {
        [NativeName("Name", "GL_WRAP_BORDER_SUN")]
        WrapBorderSun = 0x81D4,
        [NativeName("Name", "GL_GLOBAL_ALPHA_SUN")]
        GlobalAlphaSun = 0x81D9,
        [NativeName("Name", "GL_GLOBAL_ALPHA_FACTOR_SUN")]
        GlobalAlphaFactorSun = 0x81DA,
        [NativeName("Name", "GL_QUAD_MESH_SUN")]
        QuadMeshSun = 0x8614,
        [NativeName("Name", "GL_TRIANGLE_MESH_SUN")]
        TriangleMeshSun = 0x8615,
        [NativeName("Name", "GL_SLICE_ACCUM_SUN")]
        SliceAccumSun = 0x85CC,
        [NativeName("Name", "GL_RESTART_SUN")]
        RestartSun = 0x1,
        [NativeName("Name", "GL_REPLACE_MIDDLE_SUN")]
        ReplaceMiddleSun = 0x2,
        [NativeName("Name", "GL_REPLACE_OLDEST_SUN")]
        ReplaceOldestSun = 0x3,
        [NativeName("Name", "GL_TRIANGLE_LIST_SUN")]
        TriangleListSun = 0x81D7,
        [NativeName("Name", "GL_REPLACEMENT_CODE_SUN")]
        ReplacementCodeSun = 0x81D8,
        [NativeName("Name", "GL_REPLACEMENT_CODE_ARRAY_SUN")]
        ReplacementCodeArraySun = 0x85C0,
        [NativeName("Name", "GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN")]
        ReplacementCodeArrayTypeSun = 0x85C1,
        [NativeName("Name", "GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN")]
        ReplacementCodeArrayStrideSun = 0x85C2,
        [NativeName("Name", "GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN")]
        ReplacementCodeArrayPointerSun = 0x85C3,
        [NativeName("Name", "GL_R1UI_V3F_SUN")]
        R1uiV3fSun = 0x85C4,
        [NativeName("Name", "GL_R1UI_C4UB_V3F_SUN")]
        R1uiC4UBV3fSun = 0x85C5,
        [NativeName("Name", "GL_R1UI_C3F_V3F_SUN")]
        R1uiC3fV3fSun = 0x85C6,
        [NativeName("Name", "GL_R1UI_N3F_V3F_SUN")]
        R1uiN3fV3fSun = 0x85C7,
        [NativeName("Name", "GL_R1UI_C4F_N3F_V3F_SUN")]
        R1uiC4fN3fV3fSun = 0x85C8,
        [NativeName("Name", "GL_R1UI_T2F_V3F_SUN")]
        R1uiT2fV3fSun = 0x85C9,
        [NativeName("Name", "GL_R1UI_T2F_N3F_V3F_SUN")]
        R1uiT2fN3fV3fSun = 0x85CA,
        [NativeName("Name", "GL_R1UI_T2F_C4F_N3F_V3F_SUN")]
        R1uiT2fC4fN3fV3fSun = 0x85CB,
    }
}
