// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "VertexShaderParameterEXT")]
    public enum VertexShaderParameterEXT : int
    {
        [NativeName("Name", "GL_CURRENT_VERTEX_EXT")]
        CurrentVertexExt = 0x87E2,
        [NativeName("Name", "GL_MVP_MATRIX_EXT")]
        MvpMatrixExt = 0x87E3,
    }
}
