// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("DrawBufferMode")]
[Transformed]
public enum DrawBufferMode : uint
{
    [NativeName("GL_FRONT")]
    Front = unchecked((uint)0x0404),

    [NativeName("GL_BACK")]
    Back = unchecked((uint)0x0405),

    [NativeName("GL_FRONT_AND_BACK")]
    FrontAndBack = unchecked((uint)0x0408),

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

    [NativeName("GL_COLOR_ATTACHMENT16")]
    ColorAttachment16 = unchecked((uint)0x8CF0),

    [NativeName("GL_COLOR_ATTACHMENT17")]
    ColorAttachment17 = unchecked((uint)0x8CF1),

    [NativeName("GL_COLOR_ATTACHMENT18")]
    ColorAttachment18 = unchecked((uint)0x8CF2),

    [NativeName("GL_COLOR_ATTACHMENT19")]
    ColorAttachment19 = unchecked((uint)0x8CF3),

    [NativeName("GL_COLOR_ATTACHMENT20")]
    ColorAttachment20 = unchecked((uint)0x8CF4),

    [NativeName("GL_COLOR_ATTACHMENT21")]
    ColorAttachment21 = unchecked((uint)0x8CF5),

    [NativeName("GL_COLOR_ATTACHMENT22")]
    ColorAttachment22 = unchecked((uint)0x8CF6),

    [NativeName("GL_COLOR_ATTACHMENT23")]
    ColorAttachment23 = unchecked((uint)0x8CF7),

    [NativeName("GL_COLOR_ATTACHMENT24")]
    ColorAttachment24 = unchecked((uint)0x8CF8),

    [NativeName("GL_COLOR_ATTACHMENT25")]
    ColorAttachment25 = unchecked((uint)0x8CF9),

    [NativeName("GL_COLOR_ATTACHMENT26")]
    ColorAttachment26 = unchecked((uint)0x8CFA),

    [NativeName("GL_COLOR_ATTACHMENT27")]
    ColorAttachment27 = unchecked((uint)0x8CFB),

    [NativeName("GL_COLOR_ATTACHMENT28")]
    ColorAttachment28 = unchecked((uint)0x8CFC),

    [NativeName("GL_COLOR_ATTACHMENT29")]
    ColorAttachment29 = unchecked((uint)0x8CFD),

    [NativeName("GL_COLOR_ATTACHMENT30")]
    ColorAttachment30 = unchecked((uint)0x8CFE),

    [NativeName("GL_COLOR_ATTACHMENT31")]
    ColorAttachment31 = unchecked((uint)0x8CFF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT0_NV")]
    ColorAttachment0NV = unchecked((uint)0x8CE0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT1_NV")]
    ColorAttachment1NV = unchecked((uint)0x8CE1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT2_NV")]
    ColorAttachment2NV = unchecked((uint)0x8CE2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT3_NV")]
    ColorAttachment3NV = unchecked((uint)0x8CE3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT4_NV")]
    ColorAttachment4NV = unchecked((uint)0x8CE4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT5_NV")]
    ColorAttachment5NV = unchecked((uint)0x8CE5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT6_NV")]
    ColorAttachment6NV = unchecked((uint)0x8CE6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT7_NV")]
    ColorAttachment7NV = unchecked((uint)0x8CE7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT8_NV")]
    ColorAttachment8NV = unchecked((uint)0x8CE8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT9_NV")]
    ColorAttachment9NV = unchecked((uint)0x8CE9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT10_NV")]
    ColorAttachment10NV = unchecked((uint)0x8CEA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT11_NV")]
    ColorAttachment11NV = unchecked((uint)0x8CEB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT12_NV")]
    ColorAttachment12NV = unchecked((uint)0x8CEC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT13_NV")]
    ColorAttachment13NV = unchecked((uint)0x8CED),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT14_NV")]
    ColorAttachment14NV = unchecked((uint)0x8CEE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT15_NV")]
    ColorAttachment15NV = unchecked((uint)0x8CEF),
}
