// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ClientAttribMask")]
[Flags]
public enum ClientAttribMask : uint
{
    [NativeName("GL_CLIENT_PIXEL_STORE_BIT")]
    PixelStoreBit = unchecked((uint)0x00000001),

    [NativeName("GL_CLIENT_VERTEX_ARRAY_BIT")]
    VertexArrayBit = unchecked((uint)0x00000002),

    [NativeName("GL_CLIENT_ALL_ATTRIB_BITS")]
    AllAttribBits = unchecked((uint)0xFFFFFFFF),
}
