// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("AttribMask")]
[Transformed]
[Flags]
public enum AttribMask : uint
{
    [NativeName("GL_DEPTH_BUFFER_BIT")]
    DepthBufferBit = unchecked((uint)0x00000100),

    [NativeName("GL_STENCIL_BUFFER_BIT")]
    StencilBufferBit = unchecked((uint)0x00000400),

    [NativeName("GL_COLOR_BUFFER_BIT")]
    ColorBufferBit = unchecked((uint)0x00004000),

    [NativeName("GL_CURRENT_BIT")]
    CurrentBit = unchecked((uint)0x00000001),

    [NativeName("GL_POINT_BIT")]
    PointBit = unchecked((uint)0x00000002),

    [NativeName("GL_LINE_BIT")]
    LineBit = unchecked((uint)0x00000004),

    [NativeName("GL_POLYGON_BIT")]
    PolygonBit = unchecked((uint)0x00000008),

    [NativeName("GL_POLYGON_STIPPLE_BIT")]
    PolygonStippleBit = unchecked((uint)0x00000010),

    [NativeName("GL_PIXEL_MODE_BIT")]
    PixelModeBit = unchecked((uint)0x00000020),

    [NativeName("GL_LIGHTING_BIT")]
    LightingBit = unchecked((uint)0x00000040),

    [NativeName("GL_FOG_BIT")]
    FogBit = unchecked((uint)0x00000080),

    [NativeName("GL_ACCUM_BUFFER_BIT")]
    AccumBufferBit = unchecked((uint)0x00000200),

    [NativeName("GL_VIEWPORT_BIT")]
    ViewportBit = unchecked((uint)0x00000800),

    [NativeName("GL_TRANSFORM_BIT")]
    TransformBit = unchecked((uint)0x00001000),

    [NativeName("GL_ENABLE_BIT")]
    EnableBit = unchecked((uint)0x00002000),

    [NativeName("GL_HINT_BIT")]
    HintBit = unchecked((uint)0x00008000),

    [NativeName("GL_EVAL_BIT")]
    EvalBit = unchecked((uint)0x00010000),

    [NativeName("GL_LIST_BIT")]
    ListBit = unchecked((uint)0x00020000),

    [NativeName("GL_TEXTURE_BIT")]
    TextureBit = unchecked((uint)0x00040000),

    [NativeName("GL_SCISSOR_BIT")]
    ScissorBit = unchecked((uint)0x00080000),

    [NativeName("GL_ALL_ATTRIB_BITS")]
    AllAttribBits = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_MULTISAMPLE_BIT")]
    MultisampleBit = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_MULTISAMPLE_BIT_ARB")]
    MultisampleBitarb = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "3DFX", 0)]
    [NativeName("GL_MULTISAMPLE_BIT_3DFX")]
    MultisampleBit3Dfx = unchecked((uint)0x20000000),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MULTISAMPLE_BIT_EXT")]
    MultisampleBitext = unchecked((uint)0x20000000),
}
