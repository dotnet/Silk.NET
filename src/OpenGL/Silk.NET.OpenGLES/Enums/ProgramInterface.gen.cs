// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES
{
    public enum ProgramInterface
    {
        TransformFeedbackBuffer = 0x8C8E,
        Uniform = 0x92E1,
        UniformBlock = 0x92E2,
        ProgramInput = 0x92E3,
        ProgramOutput = 0x92E4,
        BufferVariable = 0x92E5,
        ShaderStorageBlock = 0x92E6,
        VertexSubroutine = 0x92E8,
        TessControlSubroutine = 0x92E9,
        TessEvaluationSubroutine = 0x92EA,
        GeometrySubroutine = 0x92EB,
        FragmentSubroutine = 0x92EC,
        ComputeSubroutine = 0x92ED,
        VertexSubroutineUniform = 0x92EE,
        TessControlSubroutineUniform = 0x92EF,
        TessEvaluationSubroutineUniform = 0x92F0,
        GeometrySubroutineUniform = 0x92F1,
        FragmentSubroutineUniform = 0x92F2,
        ComputeSubroutineUniform = 0x92F3,
        TransformFeedbackVarying = 0x92F4,
    }
}
