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
    None = 0x0,

    [NativeName("GL_CLIENT_PIXEL_STORE_BIT")]
    PixelStoreBit = 0x1,

    [NativeName("GL_CLIENT_VERTEX_ARRAY_BIT")]
    VertexArrayBit = 0x2,

    [NativeName("GL_CLIENT_ALL_ATTRIB_BITS")]
    AllAttribBits = 0xFFFFFFFF,
}
