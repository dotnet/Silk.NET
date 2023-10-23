// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ReadBufferMode")]
    public enum ReadBufferMode : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_NONE_OES")]
        NoneOes = 0x0,
        [NativeName("Name", "GL_FRONT_LEFT")]
        FrontLeft = 0x400,
        [NativeName("Name", "GL_FRONT_RIGHT")]
        FrontRight = 0x401,
        [NativeName("Name", "GL_BACK_LEFT")]
        BackLeft = 0x402,
        [NativeName("Name", "GL_BACK_RIGHT")]
        BackRight = 0x403,
        [NativeName("Name", "GL_FRONT")]
        Front = 0x404,
        [NativeName("Name", "GL_BACK")]
        Back = 0x405,
        [NativeName("Name", "GL_LEFT")]
        Left = 0x406,
        [NativeName("Name", "GL_RIGHT")]
        Right = 0x407,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_AUX0")]
        Aux0 = 0x409,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_AUX1")]
        Aux1 = 0x40A,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_AUX2")]
        Aux2 = 0x40B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_AUX3")]
        Aux3 = 0x40C,
        [NativeName("Name", "GL_COLOR_ATTACHMENT0")]
        ColorAttachment0 = 0x8CE0,
        [NativeName("Name", "GL_COLOR_ATTACHMENT1")]
        ColorAttachment1 = 0x8CE1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT2")]
        ColorAttachment2 = 0x8CE2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT3")]
        ColorAttachment3 = 0x8CE3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT4")]
        ColorAttachment4 = 0x8CE4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT5")]
        ColorAttachment5 = 0x8CE5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT6")]
        ColorAttachment6 = 0x8CE6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT7")]
        ColorAttachment7 = 0x8CE7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT8")]
        ColorAttachment8 = 0x8CE8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT9")]
        ColorAttachment9 = 0x8CE9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT10")]
        ColorAttachment10 = 0x8CEA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT11")]
        ColorAttachment11 = 0x8CEB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT12")]
        ColorAttachment12 = 0x8CEC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT13")]
        ColorAttachment13 = 0x8CED,
        [NativeName("Name", "GL_COLOR_ATTACHMENT14")]
        ColorAttachment14 = 0x8CEE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT15")]
        ColorAttachment15 = 0x8CEF,
    }
}
