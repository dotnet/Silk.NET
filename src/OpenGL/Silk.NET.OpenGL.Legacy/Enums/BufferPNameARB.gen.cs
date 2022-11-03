// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "BufferPNameARB")]
    public enum BufferPNameARB : int
    {
        [Obsolete("Deprecated in favour of \"ImmutableStorage\"")]
        [NativeName("Name", "GL_BUFFER_IMMUTABLE_STORAGE")]
        BufferImmutableStorage = 0x821F,
        [Obsolete("Deprecated in favour of \"StorageFlags\"")]
        [NativeName("Name", "GL_BUFFER_STORAGE_FLAGS")]
        BufferStorageFlags = 0x8220,
        [Obsolete("Deprecated in favour of \"Size\"")]
        [NativeName("Name", "GL_BUFFER_SIZE")]
        BufferSize = 0x8764,
        [Obsolete("Deprecated in favour of \"SizeArb\"")]
        [NativeName("Name", "GL_BUFFER_SIZE_ARB")]
        BufferSizeArb = 0x8764,
        [Obsolete("Deprecated in favour of \"Usage\"")]
        [NativeName("Name", "GL_BUFFER_USAGE")]
        BufferUsage = 0x8765,
        [Obsolete("Deprecated in favour of \"UsageArb\"")]
        [NativeName("Name", "GL_BUFFER_USAGE_ARB")]
        BufferUsageArb = 0x8765,
        [Obsolete("Deprecated in favour of \"Access\"")]
        [NativeName("Name", "GL_BUFFER_ACCESS")]
        BufferAccess = 0x88BB,
        [Obsolete("Deprecated in favour of \"AccessArb\"")]
        [NativeName("Name", "GL_BUFFER_ACCESS_ARB")]
        BufferAccessArb = 0x88BB,
        [Obsolete("Deprecated in favour of \"Mapped\"")]
        [NativeName("Name", "GL_BUFFER_MAPPED")]
        BufferMapped = 0x88BC,
        [Obsolete("Deprecated in favour of \"MappedArb\"")]
        [NativeName("Name", "GL_BUFFER_MAPPED_ARB")]
        BufferMappedArb = 0x88BC,
        [Obsolete("Deprecated in favour of \"AccessFlags\"")]
        [NativeName("Name", "GL_BUFFER_ACCESS_FLAGS")]
        BufferAccessFlags = 0x911F,
        [Obsolete("Deprecated in favour of \"MapLength\"")]
        [NativeName("Name", "GL_BUFFER_MAP_LENGTH")]
        BufferMapLength = 0x9120,
        [Obsolete("Deprecated in favour of \"MapOffset\"")]
        [NativeName("Name", "GL_BUFFER_MAP_OFFSET")]
        BufferMapOffset = 0x9121,
        [NativeName("Name", "GL_BUFFER_IMMUTABLE_STORAGE")]
        ImmutableStorage = 0x821F,
        [NativeName("Name", "GL_BUFFER_STORAGE_FLAGS")]
        StorageFlags = 0x8220,
        [NativeName("Name", "GL_BUFFER_SIZE")]
        Size = 0x8764,
        [NativeName("Name", "GL_BUFFER_SIZE_ARB")]
        SizeArb = 0x8764,
        [NativeName("Name", "GL_BUFFER_USAGE")]
        Usage = 0x8765,
        [NativeName("Name", "GL_BUFFER_USAGE_ARB")]
        UsageArb = 0x8765,
        [NativeName("Name", "GL_BUFFER_ACCESS")]
        Access = 0x88BB,
        [NativeName("Name", "GL_BUFFER_ACCESS_ARB")]
        AccessArb = 0x88BB,
        [NativeName("Name", "GL_BUFFER_MAPPED")]
        Mapped = 0x88BC,
        [NativeName("Name", "GL_BUFFER_MAPPED_ARB")]
        MappedArb = 0x88BC,
        [NativeName("Name", "GL_BUFFER_ACCESS_FLAGS")]
        AccessFlags = 0x911F,
        [NativeName("Name", "GL_BUFFER_MAP_LENGTH")]
        MapLength = 0x9120,
        [NativeName("Name", "GL_BUFFER_MAP_OFFSET")]
        MapOffset = 0x9121,
    }
}
