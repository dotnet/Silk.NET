// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ReadBufferMode")]
public enum ReadBufferMode : uint
{
    [NativeName("GL_FRONT")]
    Front = 1028,

    [NativeName("GL_BACK")]
    Back = 1029,

    [NativeName("GL_NONE_OES")]
    NoneOES = 0,

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

    [NativeName("GL_LEFT")]
    Left = 1030,

    [NativeName("GL_RIGHT")]
    Right = 1031,

    [NativeName("GL_AUX0")]
    Aux0 = 1033,

    [NativeName("GL_AUX1")]
    Aux1 = 1034,

    [NativeName("GL_AUX2")]
    Aux2 = 1035,

    [NativeName("GL_AUX3")]
    Aux3 = 1036,

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
}
