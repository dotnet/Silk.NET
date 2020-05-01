// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum ProgramTarget
    {
        TextFragmentShaderAti = 0x8200,
        VertexProgramArb = 0x8620,
        FragmentProgramArb = 0x8804,
        TessControlProgramNV = 0x891E,
        TessEvaluationProgramNV = 0x891F,
        GeometryProgramNV = 0x8C26,
        ComputeProgramNV = 0x90FB,
    }
}
