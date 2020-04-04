// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL
{
    public enum CopyImageSubDataTarget
    {
        Texture1D = 0xDE0,
        Texture2D = 0xDE1,
        Texture3D = 0x806F,
        TextureRectangle = 0x84F5,
        TextureCubeMap = 0x8513,
        Texture1DArray = 0x8C18,
        Texture2DArray = 0x8C1A,
        Renderbuffer = 0x8D41,
        TextureCubeMapArray = 0x9009,
        Texture2DMultisample = 0x9100,
        Texture2DMultisampleArray = 0x9102,
    }
}
