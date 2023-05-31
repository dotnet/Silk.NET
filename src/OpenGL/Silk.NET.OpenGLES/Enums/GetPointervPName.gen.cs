// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GetPointervPName")]
    public enum GetPointervPName : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FEEDBACK_BUFFER_POINTER")]
        FeedbackBufferPointer = 0xDF0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SELECTION_BUFFER_POINTER")]
        SelectionBufferPointer = 0xDF3,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_VERTEX_ARRAY_POINTER")]
        VertexArrayPointer = 0x808E,
        [NativeName("Name", "GL_VERTEX_ARRAY_POINTER_EXT")]
        VertexArrayPointerExt = 0x808E,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_NORMAL_ARRAY_POINTER")]
        NormalArrayPointer = 0x808F,
        [NativeName("Name", "GL_NORMAL_ARRAY_POINTER_EXT")]
        NormalArrayPointerExt = 0x808F,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_ARRAY_POINTER")]
        ColorArrayPointer = 0x8090,
        [NativeName("Name", "GL_COLOR_ARRAY_POINTER_EXT")]
        ColorArrayPointerExt = 0x8090,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_INDEX_ARRAY_POINTER")]
        IndexArrayPointer = 0x8091,
        [NativeName("Name", "GL_INDEX_ARRAY_POINTER_EXT")]
        IndexArrayPointerExt = 0x8091,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_POINTER")]
        TextureCoordArrayPointer = 0x8092,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
        TextureCoordArrayPointerExt = 0x8092,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_POINTER")]
        EdgeFlagArrayPointer = 0x8093,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_POINTER_EXT")]
        EdgeFlagArrayPointerExt = 0x8093,
        [NativeName("Name", "GL_INSTRUMENT_BUFFER_POINTER_SGIX")]
        InstrumentBufferPointerSgix = 0x8180,
        [NativeName("Name", "GL_DEBUG_CALLBACK_FUNCTION")]
        DebugCallbackFunction = 0x8244,
        [NativeName("Name", "GL_DEBUG_CALLBACK_USER_PARAM")]
        DebugCallbackUserParam = 0x8245,
    }
}
