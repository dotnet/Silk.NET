// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CommandOpcodesNV")]
public enum CommandOpcodesNV : uint
{
    [NativeName("GL_TERMINATE_SEQUENCE_COMMAND_NV")]
    TerminateSequenceCommand = unchecked((uint)0x0000),

    [NativeName("GL_NOP_COMMAND_NV")]
    NopCommand = unchecked((uint)0x0001),

    [NativeName("GL_DRAW_ELEMENTS_COMMAND_NV")]
    DrawElementsCommand = unchecked((uint)0x0002),

    [NativeName("GL_DRAW_ARRAYS_COMMAND_NV")]
    DrawArraysCommand = unchecked((uint)0x0003),

    [NativeName("GL_DRAW_ELEMENTS_STRIP_COMMAND_NV")]
    DrawElementsStripCommand = unchecked((uint)0x0004),

    [NativeName("GL_DRAW_ARRAYS_STRIP_COMMAND_NV")]
    DrawArraysStripCommand = unchecked((uint)0x0005),

    [NativeName("GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV")]
    DrawElementsInstancedCommand = unchecked((uint)0x0006),

    [NativeName("GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV")]
    DrawArraysInstancedCommand = unchecked((uint)0x0007),

    [NativeName("GL_ELEMENT_ADDRESS_COMMAND_NV")]
    ElementAddressCommand = unchecked((uint)0x0008),

    [NativeName("GL_ATTRIBUTE_ADDRESS_COMMAND_NV")]
    AttributeAddressCommand = unchecked((uint)0x0009),

    [NativeName("GL_UNIFORM_ADDRESS_COMMAND_NV")]
    UniformAddressCommand = unchecked((uint)0x000A),

    [NativeName("GL_BLEND_COLOR_COMMAND_NV")]
    BlendColorCommand = unchecked((uint)0x000B),

    [NativeName("GL_STENCIL_REF_COMMAND_NV")]
    StencilRefCommand = unchecked((uint)0x000C),

    [NativeName("GL_LINE_WIDTH_COMMAND_NV")]
    LineWidthCommand = unchecked((uint)0x000D),

    [NativeName("GL_POLYGON_OFFSET_COMMAND_NV")]
    PolygonOffsetCommand = unchecked((uint)0x000E),

    [NativeName("GL_ALPHA_REF_COMMAND_NV")]
    AlphaRefCommand = unchecked((uint)0x000F),

    [NativeName("GL_VIEWPORT_COMMAND_NV")]
    ViewportCommand = unchecked((uint)0x0010),

    [NativeName("GL_SCISSOR_COMMAND_NV")]
    ScissorCommand = unchecked((uint)0x0011),

    [NativeName("GL_FRONT_FACE_COMMAND_NV")]
    FrontFaceCommand = unchecked((uint)0x0012),
}
