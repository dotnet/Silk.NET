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
    TerminateSequenceCommand = 0,

    [NativeName("GL_NOP_COMMAND_NV")]
    NopCommand = 1,

    [NativeName("GL_DRAW_ELEMENTS_COMMAND_NV")]
    DrawElementsCommand = 2,

    [NativeName("GL_DRAW_ARRAYS_COMMAND_NV")]
    DrawArraysCommand = 3,

    [NativeName("GL_DRAW_ELEMENTS_STRIP_COMMAND_NV")]
    DrawElementsStripCommand = 4,

    [NativeName("GL_DRAW_ARRAYS_STRIP_COMMAND_NV")]
    DrawArraysStripCommand = 5,

    [NativeName("GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV")]
    DrawElementsInstancedCommand = 6,

    [NativeName("GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV")]
    DrawArraysInstancedCommand = 7,

    [NativeName("GL_ELEMENT_ADDRESS_COMMAND_NV")]
    ElementAddressCommand = 8,

    [NativeName("GL_ATTRIBUTE_ADDRESS_COMMAND_NV")]
    AttributeAddressCommand = 9,

    [NativeName("GL_UNIFORM_ADDRESS_COMMAND_NV")]
    UniformAddressCommand = 10,

    [NativeName("GL_BLEND_COLOR_COMMAND_NV")]
    BlendColorCommand = 11,

    [NativeName("GL_STENCIL_REF_COMMAND_NV")]
    StencilRefCommand = 12,

    [NativeName("GL_LINE_WIDTH_COMMAND_NV")]
    LineWidthCommand = 13,

    [NativeName("GL_POLYGON_OFFSET_COMMAND_NV")]
    PolygonOffsetCommand = 14,

    [NativeName("GL_ALPHA_REF_COMMAND_NV")]
    AlphaRefCommand = 15,

    [NativeName("GL_VIEWPORT_COMMAND_NV")]
    ViewportCommand = 16,

    [NativeName("GL_SCISSOR_COMMAND_NV")]
    ScissorCommand = 17,

    [NativeName("GL_FRONT_FACE_COMMAND_NV")]
    FrontFaceCommand = 18,
}
