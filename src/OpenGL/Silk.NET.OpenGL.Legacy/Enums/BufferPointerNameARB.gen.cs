// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "BufferPointerNameARB")]
    public enum BufferPointerNameARB : int
    {
        [Obsolete("Deprecated in favour of \"Pointer\"")]
        [NativeName("Name", "GL_BUFFER_MAP_POINTER")]
        BufferMapPointer = 0x88BD,
        [Obsolete("Deprecated in favour of \"PointerArb\"")]
        [NativeName("Name", "GL_BUFFER_MAP_POINTER_ARB")]
        BufferMapPointerArb = 0x88BD,
        [NativeName("Name", "GL_BUFFER_MAP_POINTER")]
        Pointer = 0x88BD,
        [NativeName("Name", "GL_BUFFER_MAP_POINTER_ARB")]
        PointerArb = 0x88BD,
    }
}
