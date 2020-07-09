// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "CopyImageSubDataTarget")]
    public enum CopyImageSubDataTarget
    {
        [NativeName("Name", "GL_TEXTURE_1D")]
        Texture1D = 0xDE0,
        [NativeName("Name", "GL_TEXTURE_2D")]
        Texture2D = 0xDE1,
        [NativeName("Name", "GL_TEXTURE_3D")]
        Texture3D = 0x806F,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE")]
        TextureRectangle = 0x84F5,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP")]
        TextureCubeMap = 0x8513,
        [NativeName("Name", "GL_TEXTURE_1D_ARRAY")]
        Texture1DArray = 0x8C18,
        [NativeName("Name", "GL_TEXTURE_2D_ARRAY")]
        Texture2DArray = 0x8C1A,
        [NativeName("Name", "GL_RENDERBUFFER")]
        Renderbuffer = 0x8D41,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY")]
        TextureCubeMapArray = 0x9009,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE")]
        Texture2DMultisample = 0x9100,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
        Texture2DMultisampleArray = 0x9102,
    }
}
