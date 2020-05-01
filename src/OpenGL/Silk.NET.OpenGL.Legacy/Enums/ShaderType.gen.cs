// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum ShaderType
    {
        FragmentShader = 0x8B30,
        FragmentShaderArb = 0x8B30,
        VertexShader = 0x8B31,
        VertexShaderArb = 0x8B31,
        GeometryShader = 0x8DD9,
        TessEvaluationShader = 0x8E87,
        TessControlShader = 0x8E88,
        ComputeShader = 0x91B9,
    }
}
