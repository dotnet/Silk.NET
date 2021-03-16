// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TraceMaskMESA")]
    public enum TraceMaskMESA : int
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
