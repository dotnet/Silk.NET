// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ClientAttribMask")]
    public enum ClientAttribMask
    {
        [NativeName("Name", "GL_CLIENT_PIXEL_STORE_BIT")]
        ClientPixelStoreBit = 0x1,
        [NativeName("Name", "GL_CLIENT_VERTEX_ARRAY_BIT")]
        ClientVertexArrayBit = 0x2,
        [NativeName("Name", "GL_CLIENT_ALL_ATTRIB_BITS")]
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF),
    }
}
