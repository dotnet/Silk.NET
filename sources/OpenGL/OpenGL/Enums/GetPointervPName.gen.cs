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
    VertexArrayPointer = unchecked((uint)0x808E),

    [NativeName("GL_NORMAL_ARRAY_POINTER")]
    NormalArrayPointer = unchecked((uint)0x808F),

    [NativeName("GL_COLOR_ARRAY_POINTER")]
    ColorArrayPointer = unchecked((uint)0x8090),

    [NativeName("GL_TEXTURE_COORD_ARRAY_POINTER")]
    TextureCoordArrayPointer = unchecked((uint)0x8092),

    [NativeName("GL_INDEX_ARRAY_POINTER")]
    IndexArrayPointer = unchecked((uint)0x8091),

    [NativeName("GL_EDGE_FLAG_ARRAY_POINTER")]
    EdgeFlagArrayPointer = unchecked((uint)0x8093),

    [NativeName("GL_FEEDBACK_BUFFER_POINTER")]
    FeedbackBufferPointer = unchecked((uint)0x0DF0),

    [NativeName("GL_SELECTION_BUFFER_POINTER")]
    SelectionBufferPointer = unchecked((uint)0x0DF3),

    [NativeName("GL_DEBUG_CALLBACK_FUNCTION")]
    DebugCallbackFunction = unchecked((uint)0x8244),

    [NativeName("GL_DEBUG_CALLBACK_USER_PARAM")]
    DebugCallbackUserParam = unchecked((uint)0x8245),

    [NativeName("GL_VERTEX_ARRAY_POINTER_EXT")]
    VertexArrayPointerEXT = unchecked((uint)0x808E),

    [NativeName("GL_NORMAL_ARRAY_POINTER_EXT")]
    NormalArrayPointerEXT = unchecked((uint)0x808F),

    [NativeName("GL_COLOR_ARRAY_POINTER_EXT")]
    ColorArrayPointerEXT = unchecked((uint)0x8090),

    [NativeName("GL_INDEX_ARRAY_POINTER_EXT")]
    IndexArrayPointerEXT = unchecked((uint)0x8091),

    [NativeName("GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
    TextureCoordArrayPointerEXT = unchecked((uint)0x8092),

    [NativeName("GL_EDGE_FLAG_ARRAY_POINTER_EXT")]
    EdgeFlagArrayPointerEXT = unchecked((uint)0x8093),

    [NativeName("GL_INSTRUMENT_BUFFER_POINTER_SGIX")]
    InstrumentBufferPointerSGIX = unchecked((uint)0x8180),
}
