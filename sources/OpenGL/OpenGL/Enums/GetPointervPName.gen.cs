// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GetPointervPName")]
public enum GetPointervPName : uint
{
    [NativeName("GL_VERTEX_ARRAY_POINTER")]
    VertexArrayPointer = 32910,

    [NativeName("GL_NORMAL_ARRAY_POINTER")]
    NormalArrayPointer = 32911,

    [NativeName("GL_COLOR_ARRAY_POINTER")]
    ColorArrayPointer = 32912,

    [NativeName("GL_INDEX_ARRAY_POINTER")]
    IndexArrayPointer = 32913,

    [NativeName("GL_TEXTURE_COORD_ARRAY_POINTER")]
    TextureCoordArrayPointer = 32914,

    [NativeName("GL_EDGE_FLAG_ARRAY_POINTER")]
    EdgeFlagArrayPointer = 32915,

    [NativeName("GL_FEEDBACK_BUFFER_POINTER")]
    FeedbackBufferPointer = 3568,

    [NativeName("GL_SELECTION_BUFFER_POINTER")]
    SelectionBufferPointer = 3571,

    [NativeName("GL_DEBUG_CALLBACK_FUNCTION")]
    DebugCallbackFunction = 33348,

    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM")]
    DebugCallbackUserParam = 33349,

    [NativeName("GL_VERTEX_ARRAY_POINTER_EXT")]
    VertexArrayPointerEXT = 32910,

    [NativeName("GL_NORMAL_ARRAY_POINTER_EXT")]
    NormalArrayPointerEXT = 32911,

    [NativeName("GL_COLOR_ARRAY_POINTER_EXT")]
    ColorArrayPointerEXT = 32912,

    [NativeName("GL_INDEX_ARRAY_POINTER_EXT")]
    IndexArrayPointerEXT = 32913,

    [NativeName("GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
    TextureCoordArrayPointerEXT = 32914,

    [NativeName("GL_EDGE_FLAG_ARRAY_POINTER_EXT")]
    EdgeFlagArrayPointerEXT = 32915,

    [NativeName("GL_INSTRUMENT_BUFFER_POINTER_SGIX")]
    InstrumentBufferPointerSGIX = 33152,
}
