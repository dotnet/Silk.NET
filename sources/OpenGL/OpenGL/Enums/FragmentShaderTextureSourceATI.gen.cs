// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentShaderTextureSourceATI")]
public enum FragmentShaderTextureSourceATI : uint
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

    [NativeName("GL_REG_0_ATI")]
    Reg0ATI = unchecked((uint)0x8921),

    [NativeName("GL_REG_1_ATI")]
    Reg1ATI = unchecked((uint)0x8922),

    [NativeName("GL_REG_2_ATI")]
    Reg2ATI = unchecked((uint)0x8923),

    [NativeName("GL_REG_3_ATI")]
    Reg3ATI = unchecked((uint)0x8924),

    [NativeName("GL_REG_4_ATI")]
    Reg4ATI = unchecked((uint)0x8925),

    [NativeName("GL_REG_5_ATI")]
    Reg5ATI = unchecked((uint)0x8926),

    [NativeName("GL_REG_6_ATI")]
    Reg6ATI = unchecked((uint)0x8927),

    [NativeName("GL_REG_7_ATI")]
    Reg7ATI = unchecked((uint)0x8928),

    [NativeName("GL_REG_8_ATI")]
    Reg8ATI = unchecked((uint)0x8929),

    [NativeName("GL_REG_9_ATI")]
    Reg9ATI = unchecked((uint)0x892A),

    [NativeName("GL_REG_10_ATI")]
    Reg10ATI = unchecked((uint)0x892B),

    [NativeName("GL_REG_11_ATI")]
    Reg11ATI = unchecked((uint)0x892C),

    [NativeName("GL_REG_12_ATI")]
    Reg12ATI = unchecked((uint)0x892D),

    [NativeName("GL_REG_13_ATI")]
    Reg13ATI = unchecked((uint)0x892E),

    [NativeName("GL_REG_14_ATI")]
    Reg14ATI = unchecked((uint)0x892F),

    [NativeName("GL_REG_15_ATI")]
    Reg15ATI = unchecked((uint)0x8930),

    [NativeName("GL_REG_16_ATI")]
    Reg16ATI = unchecked((uint)0x8931),

    [NativeName("GL_REG_17_ATI")]
    Reg17ATI = unchecked((uint)0x8932),

    [NativeName("GL_REG_18_ATI")]
    Reg18ATI = unchecked((uint)0x8933),

    [NativeName("GL_REG_19_ATI")]
    Reg19ATI = unchecked((uint)0x8934),

    [NativeName("GL_REG_20_ATI")]
    Reg20ATI = unchecked((uint)0x8935),

    [NativeName("GL_REG_21_ATI")]
    Reg21ATI = unchecked((uint)0x8936),

    [NativeName("GL_REG_22_ATI")]
    Reg22ATI = unchecked((uint)0x8937),

    [NativeName("GL_REG_23_ATI")]
    Reg23ATI = unchecked((uint)0x8938),

    [NativeName("GL_REG_24_ATI")]
    Reg24ATI = unchecked((uint)0x8939),

    [NativeName("GL_REG_25_ATI")]
    Reg25ATI = unchecked((uint)0x893A),

    [NativeName("GL_REG_26_ATI")]
    Reg26ATI = unchecked((uint)0x893B),

    [NativeName("GL_REG_27_ATI")]
    Reg27ATI = unchecked((uint)0x893C),

    [NativeName("GL_REG_28_ATI")]
    Reg28ATI = unchecked((uint)0x893D),

    [NativeName("GL_REG_29_ATI")]
    Reg29ATI = unchecked((uint)0x893E),

    [NativeName("GL_REG_30_ATI")]
    Reg30ATI = unchecked((uint)0x893F),

    [NativeName("GL_REG_31_ATI")]
    Reg31ATI = unchecked((uint)0x8940),
}
