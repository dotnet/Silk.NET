// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "DrawBufferMode")]
    public enum DrawBufferMode : int
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
        [NativeName("Name", "GL_FRONT_AND_BACK")]
        FrontAndBack = 0x408,
        [NativeName("Name", "GL_COLOR_ATTACHMENT0")]
        ColorAttachment0 = 0x8CE0,
        [NativeName("Name", "GL_COLOR_ATTACHMENT0_NV")]
        ColorAttachment0NV = 0x8CE0,
        [NativeName("Name", "GL_COLOR_ATTACHMENT1")]
        ColorAttachment1 = 0x8CE1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT1_NV")]
        ColorAttachment1NV = 0x8CE1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT2")]
        ColorAttachment2 = 0x8CE2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT2_NV")]
        ColorAttachment2NV = 0x8CE2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT3")]
        ColorAttachment3 = 0x8CE3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT3_NV")]
        ColorAttachment3NV = 0x8CE3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT4")]
        ColorAttachment4 = 0x8CE4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT4_NV")]
        ColorAttachment4NV = 0x8CE4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT5")]
        ColorAttachment5 = 0x8CE5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT5_NV")]
        ColorAttachment5NV = 0x8CE5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT6")]
        ColorAttachment6 = 0x8CE6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT6_NV")]
        ColorAttachment6NV = 0x8CE6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT7")]
        ColorAttachment7 = 0x8CE7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT7_NV")]
        ColorAttachment7NV = 0x8CE7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT8")]
        ColorAttachment8 = 0x8CE8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT8_NV")]
        ColorAttachment8NV = 0x8CE8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT9")]
        ColorAttachment9 = 0x8CE9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT9_NV")]
        ColorAttachment9NV = 0x8CE9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT10")]
        ColorAttachment10 = 0x8CEA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT10_NV")]
        ColorAttachment10NV = 0x8CEA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT11")]
        ColorAttachment11 = 0x8CEB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT11_NV")]
        ColorAttachment11NV = 0x8CEB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT12")]
        ColorAttachment12 = 0x8CEC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT12_NV")]
        ColorAttachment12NV = 0x8CEC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT13")]
        ColorAttachment13 = 0x8CED,
        [NativeName("Name", "GL_COLOR_ATTACHMENT13_NV")]
        ColorAttachment13NV = 0x8CED,
        [NativeName("Name", "GL_COLOR_ATTACHMENT14")]
        ColorAttachment14 = 0x8CEE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT14_NV")]
        ColorAttachment14NV = 0x8CEE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT15")]
        ColorAttachment15 = 0x8CEF,
        [NativeName("Name", "GL_COLOR_ATTACHMENT15_NV")]
        ColorAttachment15NV = 0x8CEF,
        [NativeName("Name", "GL_COLOR_ATTACHMENT16")]
        ColorAttachment16 = 0x8CF0,
        [NativeName("Name", "GL_COLOR_ATTACHMENT17")]
        ColorAttachment17 = 0x8CF1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT18")]
        ColorAttachment18 = 0x8CF2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT19")]
        ColorAttachment19 = 0x8CF3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT20")]
        ColorAttachment20 = 0x8CF4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT21")]
        ColorAttachment21 = 0x8CF5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT22")]
        ColorAttachment22 = 0x8CF6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT23")]
        ColorAttachment23 = 0x8CF7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT24")]
        ColorAttachment24 = 0x8CF8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT25")]
        ColorAttachment25 = 0x8CF9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT26")]
        ColorAttachment26 = 0x8CFA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT27")]
        ColorAttachment27 = 0x8CFB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT28")]
        ColorAttachment28 = 0x8CFC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT29")]
        ColorAttachment29 = 0x8CFD,
        [NativeName("Name", "GL_COLOR_ATTACHMENT30")]
        ColorAttachment30 = 0x8CFE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT31")]
        ColorAttachment31 = 0x8CFF,
    }
}
