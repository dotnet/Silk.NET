// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "GetPointervPName")]
    public enum GetPointervPName
    {
        [NativeName("Name", "GL_VERTEX_ARRAY_POINTER_EXT")]
        VertexArrayPointerExt = 0x808E,
        [NativeName("Name", "GL_NORMAL_ARRAY_POINTER_EXT")]
        NormalArrayPointerExt = 0x808F,
        [NativeName("Name", "GL_COLOR_ARRAY_POINTER_EXT")]
        ColorArrayPointerExt = 0x8090,
        [NativeName("Name", "GL_INDEX_ARRAY_POINTER_EXT")]
        IndexArrayPointerExt = 0x8091,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_POINTER_EXT")]
        TextureCoordArrayPointerExt = 0x8092,
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
