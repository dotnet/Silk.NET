// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TraceMaskMESA")]
    public enum TraceMaskMESA
    {
        [NativeName("Name", "GL_TRACE_OPERATIONS_BIT_MESA")]
        TraceOperationsBitMesa = 0x1,
        [NativeName("Name", "GL_TRACE_PRIMITIVES_BIT_MESA")]
        TracePrimitivesBitMesa = 0x2,
        [NativeName("Name", "GL_TRACE_ARRAYS_BIT_MESA")]
        TraceArraysBitMesa = 0x4,
        [NativeName("Name", "GL_TRACE_TEXTURES_BIT_MESA")]
        TraceTexturesBitMesa = 0x8,
        [NativeName("Name", "GL_TRACE_PIXELS_BIT_MESA")]
        TracePixelsBitMesa = 0x10,
        [NativeName("Name", "GL_TRACE_ERRORS_BIT_MESA")]
        TraceErrorsBitMesa = 0x20,
        [NativeName("Name", "GL_TRACE_ALL_BITS_MESA")]
        TraceAllBitsMesa = 0xFFFF,
    }
}
