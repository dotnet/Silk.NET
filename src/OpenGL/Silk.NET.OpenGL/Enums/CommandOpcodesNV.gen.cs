// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "CommandOpcodesNV")]
    public enum CommandOpcodesNV : int
    {
        [NativeName("Name", "GL_TERMINATE_SEQUENCE_COMMAND_NV")]
        TerminateSequenceCommandNV = 0x0,
        [NativeName("Name", "GL_NOP_COMMAND_NV")]
        NopCommandNV = 0x1,
        [NativeName("Name", "GL_DRAW_ELEMENTS_COMMAND_NV")]
        DrawElementsCommandNV = 0x2,
        [NativeName("Name", "GL_DRAW_ARRAYS_COMMAND_NV")]
        DrawArraysCommandNV = 0x3,
        [NativeName("Name", "GL_DRAW_ELEMENTS_STRIP_COMMAND_NV")]
        DrawElementsStripCommandNV = 0x4,
        [NativeName("Name", "GL_DRAW_ARRAYS_STRIP_COMMAND_NV")]
        DrawArraysStripCommandNV = 0x5,
        [NativeName("Name", "GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV")]
        DrawElementsInstancedCommandNV = 0x6,
        [NativeName("Name", "GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV")]
        DrawArraysInstancedCommandNV = 0x7,
        [NativeName("Name", "GL_ELEMENT_ADDRESS_COMMAND_NV")]
        ElementAddressCommandNV = 0x8,
        [NativeName("Name", "GL_ATTRIBUTE_ADDRESS_COMMAND_NV")]
        AttributeAddressCommandNV = 0x9,
        [NativeName("Name", "GL_UNIFORM_ADDRESS_COMMAND_NV")]
        UniformAddressCommandNV = 0xA,
        [NativeName("Name", "GL_BLEND_COLOR_COMMAND_NV")]
        BlendColorCommandNV = 0xB,
        [NativeName("Name", "GL_STENCIL_REF_COMMAND_NV")]
        StencilRefCommandNV = 0xC,
        [NativeName("Name", "GL_LINE_WIDTH_COMMAND_NV")]
        LineWidthCommandNV = 0xD,
        [NativeName("Name", "GL_POLYGON_OFFSET_COMMAND_NV")]
        PolygonOffsetCommandNV = 0xE,
        [NativeName("Name", "GL_ALPHA_REF_COMMAND_NV")]
        AlphaRefCommandNV = 0xF,
        [NativeName("Name", "GL_VIEWPORT_COMMAND_NV")]
        ViewportCommandNV = 0x10,
        [NativeName("Name", "GL_SCISSOR_COMMAND_NV")]
        ScissorCommandNV = 0x11,
        [NativeName("Name", "GL_FRONT_FACE_COMMAND_NV")]
        FrontFaceCommandNV = 0x12,
    }
}
