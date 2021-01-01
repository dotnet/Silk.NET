// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.MESAX
{
    [NativeName("Name", "GLenum")]
    public enum MESAX : int
    {
        [NativeName("Name", "GL_TEXTURE_1D_STACK_MESAX")]
        Texture1DStackMesax = 0x8759,
        [NativeName("Name", "GL_TEXTURE_2D_STACK_MESAX")]
        Texture2DStackMesax = 0x875A,
        [NativeName("Name", "GL_PROXY_TEXTURE_1D_STACK_MESAX")]
        ProxyTexture1DStackMesax = 0x875B,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_STACK_MESAX")]
        ProxyTexture2DStackMesax = 0x875C,
        [NativeName("Name", "GL_TEXTURE_1D_STACK_BINDING_MESAX")]
        Texture1DStackBindingMesax = 0x875D,
        [NativeName("Name", "GL_TEXTURE_2D_STACK_BINDING_MESAX")]
        Texture2DStackBindingMesax = 0x875E,
    }
}
