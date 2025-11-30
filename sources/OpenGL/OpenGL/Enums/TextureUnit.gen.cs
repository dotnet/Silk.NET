// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureUnit")]
[Transformed]
public enum TextureUnit : uint
{
    [NativeName("GL_TEXTURE0")]
    Texture0 = unchecked((uint)0x84C0),

    [NativeName("GL_TEXTURE1")]
    Texture1 = unchecked((uint)0x84C1),

    [NativeName("GL_TEXTURE2")]
    Texture2 = unchecked((uint)0x84C2),

    [NativeName("GL_TEXTURE3")]
    Texture3 = unchecked((uint)0x84C3),

    [NativeName("GL_TEXTURE4")]
    Texture4 = unchecked((uint)0x84C4),

    [NativeName("GL_TEXTURE5")]
    Texture5 = unchecked((uint)0x84C5),

    [NativeName("GL_TEXTURE6")]
    Texture6 = unchecked((uint)0x84C6),

    [NativeName("GL_TEXTURE7")]
    Texture7 = unchecked((uint)0x84C7),

    [NativeName("GL_TEXTURE8")]
    Texture8 = unchecked((uint)0x84C8),

    [NativeName("GL_TEXTURE9")]
    Texture9 = unchecked((uint)0x84C9),

    [NativeName("GL_TEXTURE10")]
    Texture10 = unchecked((uint)0x84CA),

    [NativeName("GL_TEXTURE11")]
    Texture11 = unchecked((uint)0x84CB),

    [NativeName("GL_TEXTURE12")]
    Texture12 = unchecked((uint)0x84CC),

    [NativeName("GL_TEXTURE13")]
    Texture13 = unchecked((uint)0x84CD),

    [NativeName("GL_TEXTURE14")]
    Texture14 = unchecked((uint)0x84CE),

    [NativeName("GL_TEXTURE15")]
    Texture15 = unchecked((uint)0x84CF),

    [NativeName("GL_TEXTURE16")]
    Texture16 = unchecked((uint)0x84D0),

    [NativeName("GL_TEXTURE17")]
    Texture17 = unchecked((uint)0x84D1),

    [NativeName("GL_TEXTURE18")]
    Texture18 = unchecked((uint)0x84D2),

    [NativeName("GL_TEXTURE19")]
    Texture19 = unchecked((uint)0x84D3),

    [NativeName("GL_TEXTURE20")]
    Texture20 = unchecked((uint)0x84D4),

    [NativeName("GL_TEXTURE21")]
    Texture21 = unchecked((uint)0x84D5),

    [NativeName("GL_TEXTURE22")]
    Texture22 = unchecked((uint)0x84D6),

    [NativeName("GL_TEXTURE23")]
    Texture23 = unchecked((uint)0x84D7),

    [NativeName("GL_TEXTURE24")]
    Texture24 = unchecked((uint)0x84D8),

    [NativeName("GL_TEXTURE25")]
    Texture25 = unchecked((uint)0x84D9),

    [NativeName("GL_TEXTURE26")]
    Texture26 = unchecked((uint)0x84DA),

    [NativeName("GL_TEXTURE27")]
    Texture27 = unchecked((uint)0x84DB),

    [NativeName("GL_TEXTURE28")]
    Texture28 = unchecked((uint)0x84DC),

    [NativeName("GL_TEXTURE29")]
    Texture29 = unchecked((uint)0x84DD),

    [NativeName("GL_TEXTURE30")]
    Texture30 = unchecked((uint)0x84DE),

    [NativeName("GL_TEXTURE31")]
    Texture31 = unchecked((uint)0x84DF),
}
