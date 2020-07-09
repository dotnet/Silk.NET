// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ProgramInterface")]
    public enum ProgramInterface
    {
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER")]
        TransformFeedbackBuffer = 0x8C8E,
        [NativeName("Name", "GL_UNIFORM")]
        Uniform = 0x92E1,
        [NativeName("Name", "GL_UNIFORM_BLOCK")]
        UniformBlock = 0x92E2,
        [NativeName("Name", "GL_PROGRAM_INPUT")]
        ProgramInput = 0x92E3,
        [NativeName("Name", "GL_PROGRAM_OUTPUT")]
        ProgramOutput = 0x92E4,
        [NativeName("Name", "GL_BUFFER_VARIABLE")]
        BufferVariable = 0x92E5,
        [NativeName("Name", "GL_SHADER_STORAGE_BLOCK")]
        ShaderStorageBlock = 0x92E6,
        [NativeName("Name", "GL_VERTEX_SUBROUTINE")]
        VertexSubroutine = 0x92E8,
        [NativeName("Name", "GL_TESS_CONTROL_SUBROUTINE")]
        TessControlSubroutine = 0x92E9,
        [NativeName("Name", "GL_TESS_EVALUATION_SUBROUTINE")]
        TessEvaluationSubroutine = 0x92EA,
        [NativeName("Name", "GL_GEOMETRY_SUBROUTINE")]
        GeometrySubroutine = 0x92EB,
        [NativeName("Name", "GL_FRAGMENT_SUBROUTINE")]
        FragmentSubroutine = 0x92EC,
        [NativeName("Name", "GL_COMPUTE_SUBROUTINE")]
        ComputeSubroutine = 0x92ED,
        [NativeName("Name", "GL_VERTEX_SUBROUTINE_UNIFORM")]
        VertexSubroutineUniform = 0x92EE,
        [NativeName("Name", "GL_TESS_CONTROL_SUBROUTINE_UNIFORM")]
        TessControlSubroutineUniform = 0x92EF,
        [NativeName("Name", "GL_TESS_EVALUATION_SUBROUTINE_UNIFORM")]
        TessEvaluationSubroutineUniform = 0x92F0,
        [NativeName("Name", "GL_GEOMETRY_SUBROUTINE_UNIFORM")]
        GeometrySubroutineUniform = 0x92F1,
        [NativeName("Name", "GL_FRAGMENT_SUBROUTINE_UNIFORM")]
        FragmentSubroutineUniform = 0x92F2,
        [NativeName("Name", "GL_COMPUTE_SUBROUTINE_UNIFORM")]
        ComputeSubroutineUniform = 0x92F3,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYING")]
        TransformFeedbackVarying = 0x92F4,
    }
}
