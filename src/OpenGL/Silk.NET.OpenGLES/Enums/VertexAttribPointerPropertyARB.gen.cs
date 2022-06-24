// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VertexAttribPointerPropertyARB")]
    public enum VertexAttribPointerPropertyARB : int
    {
        [Obsolete("Deprecated in favour of \"Pointer\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_POINTER")]
        VertexAttribArrayPointer = 0x8645,
        [Obsolete("Deprecated in favour of \"PointerArb\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
        VertexAttribArrayPointerArb = 0x8645,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_POINTER")]
        Pointer = 0x8645,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
        PointerArb = 0x8645,
    }
}
