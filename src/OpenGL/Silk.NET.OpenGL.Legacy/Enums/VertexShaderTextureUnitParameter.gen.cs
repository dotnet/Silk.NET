// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "VertexShaderTextureUnitParameter")]
    public enum VertexShaderTextureUnitParameter
    {
        [NativeName("Name", "GL_CURRENT_TEXTURE_COORDS")]
        CurrentTextureCoords = 0xB03,
        [NativeName("Name", "GL_TEXTURE_MATRIX")]
        TextureMatrix = 0xBA8,
    }
}
