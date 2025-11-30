// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ReadBufferMode")]
[Transformed]
public enum ReadBufferMode : uint
{
    [NativeName("GL_FRONT")]
    Front = unchecked((uint)0x0404),

    [NativeName("GL_BACK")]
    Back = unchecked((uint)0x0405),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_NONE_OES")]
    NoneOES = unchecked((uint)0),

    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NativeName("GL_FRONT_LEFT")]
    FrontLeft = unchecked((uint)0x0400),

    [NativeName("GL_FRONT_RIGHT")]
    FrontRight = unchecked((uint)0x0401),

    [NativeName("GL_BACK_LEFT")]
    BackLeft = unchecked((uint)0x0402),

    [NativeName("GL_BACK_RIGHT")]
    BackRight = unchecked((uint)0x0403),

    [NativeName("GL_LEFT")]
    Left = unchecked((uint)0x0406),

    [NativeName("GL_RIGHT")]
    Right = unchecked((uint)0x0407),

    [NativeName("GL_AUX0")]
    Aux0 = unchecked((uint)0x0409),

    [NativeName("GL_AUX1")]
    Aux1 = unchecked((uint)0x040A),

    [NativeName("GL_AUX2")]
    Aux2 = unchecked((uint)0x040B),

    [NativeName("GL_AUX3")]
    Aux3 = unchecked((uint)0x040C),

    [NativeName("GL_COLOR_ATTACHMENT0")]
    ColorAttachment0 = unchecked((uint)0x8CE0),

    [NativeName("GL_COLOR_ATTACHMENT1")]
    ColorAttachment1 = unchecked((uint)0x8CE1),

    [NativeName("GL_COLOR_ATTACHMENT2")]
    ColorAttachment2 = unchecked((uint)0x8CE2),

    [NativeName("GL_COLOR_ATTACHMENT3")]
    ColorAttachment3 = unchecked((uint)0x8CE3),

    [NativeName("GL_COLOR_ATTACHMENT4")]
    ColorAttachment4 = unchecked((uint)0x8CE4),

    [NativeName("GL_COLOR_ATTACHMENT5")]
    ColorAttachment5 = unchecked((uint)0x8CE5),

    [NativeName("GL_COLOR_ATTACHMENT6")]
    ColorAttachment6 = unchecked((uint)0x8CE6),

    [NativeName("GL_COLOR_ATTACHMENT7")]
    ColorAttachment7 = unchecked((uint)0x8CE7),

    [NativeName("GL_COLOR_ATTACHMENT8")]
    ColorAttachment8 = unchecked((uint)0x8CE8),

    [NativeName("GL_COLOR_ATTACHMENT9")]
    ColorAttachment9 = unchecked((uint)0x8CE9),

    [NativeName("GL_COLOR_ATTACHMENT10")]
    ColorAttachment10 = unchecked((uint)0x8CEA),

    [NativeName("GL_COLOR_ATTACHMENT11")]
    ColorAttachment11 = unchecked((uint)0x8CEB),

    [NativeName("GL_COLOR_ATTACHMENT12")]
    ColorAttachment12 = unchecked((uint)0x8CEC),

    [NativeName("GL_COLOR_ATTACHMENT13")]
    ColorAttachment13 = unchecked((uint)0x8CED),

    [NativeName("GL_COLOR_ATTACHMENT14")]
    ColorAttachment14 = unchecked((uint)0x8CEE),

    [NativeName("GL_COLOR_ATTACHMENT15")]
    ColorAttachment15 = unchecked((uint)0x8CEF),
}
