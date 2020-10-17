// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "BufferPointerNameARB")]
    public enum BufferPointerNameARB
    {
        [NativeName("Name", "GL_BUFFER_MAP_POINTER")]
        BufferMapPointer = 0x88BD,
        [NativeName("Name", "GL_BUFFER_MAP_POINTER_ARB")]
        BufferMapPointerArb = 0x88BD,
    }
}
