// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum UniformBlockPName
    {
        UniformBlockReferencedByTessControlShader = 0x84F0,
        UniformBlockReferencedByTessEvaluationShader = 0x84F1,
        UniformBlockBinding = 0x8A3F,
        UniformBlockDataSize = 0x8A40,
        UniformBlockNameLength = 0x8A41,
        UniformBlockActiveUniforms = 0x8A42,
        UniformBlockActiveUniformIndices = 0x8A43,
        UniformBlockReferencedByVertexShader = 0x8A44,
        UniformBlockReferencedByGeometryShader = 0x8A45,
        UniformBlockReferencedByFragmentShader = 0x8A46,
        UniformBlockReferencedByComputeShader = 0x90EC,
    }
}
