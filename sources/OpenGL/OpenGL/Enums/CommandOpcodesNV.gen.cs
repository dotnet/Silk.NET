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
public enum CommandOpcodesNV : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TERMINATE_SEQUENCE_COMMAND_NV")]
    TerminateSequenceCommandNV = unchecked((uint)0x0000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NOP_COMMAND_NV")]
    NopCommandNV = unchecked((uint)0x0001),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ELEMENTS_COMMAND_NV")]
    DrawElementsCommandNV = unchecked((uint)0x0002),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ARRAYS_COMMAND_NV")]
    DrawArraysCommandNV = unchecked((uint)0x0003),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ELEMENTS_STRIP_COMMAND_NV")]
    DrawElementsStripCommandNV = unchecked((uint)0x0004),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ARRAYS_STRIP_COMMAND_NV")]
    DrawArraysStripCommandNV = unchecked((uint)0x0005),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV")]
    DrawElementsInstancedCommandNV = unchecked((uint)0x0006),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV")]
    DrawArraysInstancedCommandNV = unchecked((uint)0x0007),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ELEMENT_ADDRESS_COMMAND_NV")]
    ElementAddressCommandNV = unchecked((uint)0x0008),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ATTRIBUTE_ADDRESS_COMMAND_NV")]
    AttributeAddressCommandNV = unchecked((uint)0x0009),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNIFORM_ADDRESS_COMMAND_NV")]
    UniformAddressCommandNV = unchecked((uint)0x000A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_BLEND_COLOR_COMMAND_NV")]
    BlendColorCommandNV = unchecked((uint)0x000B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_STENCIL_REF_COMMAND_NV")]
    StencilRefCommandNV = unchecked((uint)0x000C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LINE_WIDTH_COMMAND_NV")]
    LineWidthCommandNV = unchecked((uint)0x000D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_POLYGON_OFFSET_COMMAND_NV")]
    PolygonOffsetCommandNV = unchecked((uint)0x000E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ALPHA_REF_COMMAND_NV")]
    AlphaRefCommandNV = unchecked((uint)0x000F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VIEWPORT_COMMAND_NV")]
    ViewportCommandNV = unchecked((uint)0x0010),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SCISSOR_COMMAND_NV")]
    ScissorCommandNV = unchecked((uint)0x0011),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FRONT_FACE_COMMAND_NV")]
    FrontFaceCommandNV = unchecked((uint)0x0012),
}
