// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ClientAttribMask")]
    public enum ClientAttribMask : int
    {
        [NativeName("Name", "GL_CLIENT_PIXEL_STORE_BIT")]
        ClientPixelStoreBit = 0x1,
        [NativeName("Name", "GL_CLIENT_VERTEX_ARRAY_BIT")]
        ClientVertexArrayBit = 0x2,
        [NativeName("Name", "GL_CLIENT_ALL_ATTRIB_BITS")]
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF),
    }
}
