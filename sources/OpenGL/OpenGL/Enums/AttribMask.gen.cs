// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("AttribMask")]
[Flags]
public enum AttribMask : uint
{
    None = 0x0,

    [NativeName("GL_DEPTH_BUFFER_BIT")]
    DepthBufferBit = 0x100,

    [NativeName("GL_STENCIL_BUFFER_BIT")]
    StencilBufferBit = 0x400,

    [NativeName("GL_COLOR_BUFFER_BIT")]
    ColorBufferBit = 0x4000,

    [NativeName("GL_CURRENT_BIT")]
    CurrentBit = 0x1,

    [NativeName("GL_POINT_BIT")]
    PointBit = 0x2,

    [NativeName("GL_LINE_BIT")]
    LineBit = 0x4,

    [NativeName("GL_POLYGON_BIT")]
    PolygonBit = 0x8,

    [NativeName("GL_POLYGON_STIPPLE_BIT")]
    PolygonStippleBit = 0x10,

    [NativeName("GL_PIXEL_MODE_BIT")]
    PixelModeBit = 0x20,

    [NativeName("GL_LIGHTING_BIT")]
    LightingBit = 0x40,

    [NativeName("GL_FOG_BIT")]
    FogBit = 0x80,

    [NativeName("GL_ACCUM_BUFFER_BIT")]
    AccumBufferBit = 0x200,

    [NativeName("GL_VIEWPORT_BIT")]
    ViewportBit = 0x800,

    [NativeName("GL_TRANSFORM_BIT")]
    TransformBit = 0x1000,

    [NativeName("GL_ENABLE_BIT")]
    EnableBit = 0x2000,

    [NativeName("GL_HINT_BIT")]
    HintBit = 0x8000,

    [NativeName("GL_EVAL_BIT")]
    EvalBit = 0x10000,

    [NativeName("GL_LIST_BIT")]
    ListBit = 0x20000,

    [NativeName("GL_TEXTURE_BIT")]
    TextureBit = 0x40000,

    [NativeName("GL_SCISSOR_BIT")]
    ScissorBit = 0x80000,

    [NativeName("GL_ALL_ATTRIB_BITS")]
    AllAttribBits = 0xFFFFFFFF,

    [NativeName("GL_MULTISAMPLE_BIT")]
    MultisampleBit = 0x20000000,

    [NativeName("GL_MULTISAMPLE_BIT_ARB")]
    MultisampleBitARB = 0x20000000,

    [NativeName("GL_MULTISAMPLE_BIT_3DFX")]
    MultisampleBit3DFX = 0x20000000,

    [NativeName("GL_MULTISAMPLE_BIT_EXT")]
    MultisampleBitEXT = 0x20000000,
}
