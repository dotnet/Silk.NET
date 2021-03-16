// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ProgramTarget")]
    public enum ProgramTarget : int
    {
        [NativeName("Name", "GL_TEXT_FRAGMENT_SHADER_ATI")]
        TextFragmentShaderAti = 0x8200,
        [NativeName("Name", "GL_VERTEX_PROGRAM_ARB")]
        VertexProgramArb = 0x8620,
        [NativeName("Name", "GL_FRAGMENT_PROGRAM_ARB")]
        FragmentProgramArb = 0x8804,
        [NativeName("Name", "GL_TESS_CONTROL_PROGRAM_NV")]
        TessControlProgramNV = 0x891E,
        [NativeName("Name", "GL_TESS_EVALUATION_PROGRAM_NV")]
        TessEvaluationProgramNV = 0x891F,
        [NativeName("Name", "GL_GEOMETRY_PROGRAM_NV")]
        GeometryProgramNV = 0x8C26,
        [NativeName("Name", "GL_COMPUTE_PROGRAM_NV")]
        ComputeProgramNV = 0x90FB,
    }
}
