// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("CommandOpcodesNV")]
[Transformed]
public enum CommandOpcodesNv : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TERMINATE_SEQUENCE_COMMAND_NV")]
    TerminateSequenceCommandnv = unchecked((uint)0x0000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NOP_COMMAND_NV")]
    NopCommandnv = unchecked((uint)0x0001),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ELEMENTS_COMMAND_NV")]
    DrawElementsCommandnv = unchecked((uint)0x0002),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ARRAYS_COMMAND_NV")]
    DrawArraysCommandnv = unchecked((uint)0x0003),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ELEMENTS_STRIP_COMMAND_NV")]
    DrawElementsStripCommandnv = unchecked((uint)0x0004),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ARRAYS_STRIP_COMMAND_NV")]
    DrawArraysStripCommandnv = unchecked((uint)0x0005),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV")]
    DrawElementsInstancedCommandnv = unchecked((uint)0x0006),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV")]
    DrawArraysInstancedCommandnv = unchecked((uint)0x0007),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ELEMENT_ADDRESS_COMMAND_NV")]
    ElementAddressCommandnv = unchecked((uint)0x0008),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATTRIBUTE_ADDRESS_COMMAND_NV")]
    AttributeAddressCommandnv = unchecked((uint)0x0009),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNIFORM_ADDRESS_COMMAND_NV")]
    UniformAddressCommandnv = unchecked((uint)0x000A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BLEND_COLOR_COMMAND_NV")]
    BlendColorCommandnv = unchecked((uint)0x000B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_STENCIL_REF_COMMAND_NV")]
    StencilRefCommandnv = unchecked((uint)0x000C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LINE_WIDTH_COMMAND_NV")]
    LineWidthCommandnv = unchecked((uint)0x000D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_POLYGON_OFFSET_COMMAND_NV")]
    PolygonOffsetCommandnv = unchecked((uint)0x000E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ALPHA_REF_COMMAND_NV")]
    AlphaRefCommandnv = unchecked((uint)0x000F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_COMMAND_NV")]
    ViewportCommandnv = unchecked((uint)0x0010),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SCISSOR_COMMAND_NV")]
    ScissorCommandnv = unchecked((uint)0x0011),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRONT_FACE_COMMAND_NV")]
    FrontFaceCommandnv = unchecked((uint)0x0012),
}
