// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum ClientAttribMask
    {
        ClientPixelStoreBit = 0x1,
        ClientVertexArrayBit = 0x2,
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF),
    }
}
