// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "BufferPNameARB")]
    public enum BufferPNameARB
    {
        [NativeName("Name", "GL_BUFFER_IMMUTABLE_STORAGE")]
        BufferImmutableStorage = 0x821F,
        [NativeName("Name", "GL_BUFFER_STORAGE_FLAGS")]
        BufferStorageFlags = 0x8220,
        [NativeName("Name", "GL_BUFFER_SIZE")]
        BufferSize = 0x8764,
        [NativeName("Name", "GL_BUFFER_SIZE_ARB")]
        BufferSizeArb = 0x8764,
        [NativeName("Name", "GL_BUFFER_USAGE")]
        BufferUsage = 0x8765,
        [NativeName("Name", "GL_BUFFER_USAGE_ARB")]
        BufferUsageArb = 0x8765,
        [NativeName("Name", "GL_BUFFER_ACCESS")]
        BufferAccess = 0x88BB,
        [NativeName("Name", "GL_BUFFER_ACCESS_ARB")]
        BufferAccessArb = 0x88BB,
        [NativeName("Name", "GL_BUFFER_MAPPED")]
        BufferMapped = 0x88BC,
        [NativeName("Name", "GL_BUFFER_MAPPED_ARB")]
        BufferMappedArb = 0x88BC,
        [NativeName("Name", "GL_BUFFER_ACCESS_FLAGS")]
        BufferAccessFlags = 0x911F,
        [NativeName("Name", "GL_BUFFER_MAP_LENGTH")]
        BufferMapLength = 0x9120,
        [NativeName("Name", "GL_BUFFER_MAP_OFFSET")]
        BufferMapOffset = 0x9121,
    }
}
