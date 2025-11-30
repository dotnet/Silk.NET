// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ARB", 0)]
[NativeName("BufferPNameARB")]
[Transformed]
public enum BufferPNameArb : uint
{
    [NativeName("GL_BUFFER_SIZE")]
    Size = unchecked((uint)0x8764),

    [NativeName("GL_BUFFER_USAGE")]
    Usage = unchecked((uint)0x8765),

    [NativeName("GL_BUFFER_ACCESS")]
    Access = unchecked((uint)0x88BB),

    [NativeName("GL_BUFFER_MAPPED")]
    Mapped = unchecked((uint)0x88BC),

    [NativeName("GL_BUFFER_ACCESS_FLAGS")]
    AccessFlags = unchecked((uint)0x911F),

    [NativeName("GL_BUFFER_MAP_LENGTH")]
    MapLength = unchecked((uint)0x9120),

    [NativeName("GL_BUFFER_MAP_OFFSET")]
    MapOffset = unchecked((uint)0x9121),

    [NativeName("GL_BUFFER_IMMUTABLE_STORAGE")]
    ImmutableStorage = unchecked((uint)0x821F),

    [NativeName("GL_BUFFER_STORAGE_FLAGS")]
    StorageFlags = unchecked((uint)0x8220),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_SIZE_ARB")]
    Sizearb = unchecked((uint)0x8764),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_USAGE_ARB")]
    Usagearb = unchecked((uint)0x8765),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_ACCESS_ARB")]
    Accessarb = unchecked((uint)0x88BB),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_MAPPED_ARB")]
    Mappedarb = unchecked((uint)0x88BC),
}
