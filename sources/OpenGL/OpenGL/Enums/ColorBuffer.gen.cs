// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ColorBuffer")]
public enum ColorBuffer : uint
{
    [NativeName("GL_NONE")]
    None = 0,

    [NativeName("GL_FRONT_LEFT")]
    FrontLeft = 1024,

    [NativeName("GL_FRONT_RIGHT")]
    FrontRight = 1025,

    [NativeName("GL_BACK_LEFT")]
    BackLeft = 1026,

    [NativeName("GL_BACK_RIGHT")]
    BackRight = 1027,

    [NativeName("GL_FRONT")]
    Front = 1028,

    [NativeName("GL_BACK")]
    Back = 1029,

    [NativeName("GL_LEFT")]
    Left = 1030,

    [NativeName("GL_RIGHT")]
    Right = 1031,

    [NativeName("GL_FRONT_AND_BACK")]
    FrontAndBack = 1032,

    [NativeName("GL_COLOR_ATTACHMENT0")]
    ColorAttachment0 = 36064,

    [NativeName("GL_COLOR_ATTACHMENT1")]
    ColorAttachment1 = 36065,

    [NativeName("GL_COLOR_ATTACHMENT2")]
    ColorAttachment2 = 36066,

    [NativeName("GL_COLOR_ATTACHMENT3")]
    ColorAttachment3 = 36067,

    [NativeName("GL_COLOR_ATTACHMENT4")]
    ColorAttachment4 = 36068,

    [NativeName("GL_COLOR_ATTACHMENT5")]
    ColorAttachment5 = 36069,

    [NativeName("GL_COLOR_ATTACHMENT6")]
    ColorAttachment6 = 36070,

    [NativeName("GL_COLOR_ATTACHMENT7")]
    ColorAttachment7 = 36071,

    [NativeName("GL_COLOR_ATTACHMENT8")]
    ColorAttachment8 = 36072,

    [NativeName("GL_COLOR_ATTACHMENT9")]
    ColorAttachment9 = 36073,

    [NativeName("GL_COLOR_ATTACHMENT10")]
    ColorAttachment10 = 36074,

    [NativeName("GL_COLOR_ATTACHMENT11")]
    ColorAttachment11 = 36075,

    [NativeName("GL_COLOR_ATTACHMENT12")]
    ColorAttachment12 = 36076,

    [NativeName("GL_COLOR_ATTACHMENT13")]
    ColorAttachment13 = 36077,

    [NativeName("GL_COLOR_ATTACHMENT14")]
    ColorAttachment14 = 36078,

    [NativeName("GL_COLOR_ATTACHMENT15")]
    ColorAttachment15 = 36079,

    [NativeName("GL_COLOR_ATTACHMENT16")]
    ColorAttachment16 = 36080,

    [NativeName("GL_COLOR_ATTACHMENT17")]
    ColorAttachment17 = 36081,

    [NativeName("GL_COLOR_ATTACHMENT18")]
    ColorAttachment18 = 36082,

    [NativeName("GL_COLOR_ATTACHMENT19")]
    ColorAttachment19 = 36083,

    [NativeName("GL_COLOR_ATTACHMENT20")]
    ColorAttachment20 = 36084,

    [NativeName("GL_COLOR_ATTACHMENT21")]
    ColorAttachment21 = 36085,

    [NativeName("GL_COLOR_ATTACHMENT22")]
    ColorAttachment22 = 36086,

    [NativeName("GL_COLOR_ATTACHMENT23")]
    ColorAttachment23 = 36087,

    [NativeName("GL_COLOR_ATTACHMENT24")]
    ColorAttachment24 = 36088,

    [NativeName("GL_COLOR_ATTACHMENT25")]
    ColorAttachment25 = 36089,

    [NativeName("GL_COLOR_ATTACHMENT26")]
    ColorAttachment26 = 36090,

    [NativeName("GL_COLOR_ATTACHMENT27")]
    ColorAttachment27 = 36091,

    [NativeName("GL_COLOR_ATTACHMENT28")]
    ColorAttachment28 = 36092,

    [NativeName("GL_COLOR_ATTACHMENT29")]
    ColorAttachment29 = 36093,

    [NativeName("GL_COLOR_ATTACHMENT30")]
    ColorAttachment30 = 36094,

    [NativeName("GL_COLOR_ATTACHMENT31")]
    ColorAttachment31 = 36095,
}
