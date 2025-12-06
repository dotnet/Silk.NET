// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("BufferPNameARB")]
public enum BufferPName : uint
{
    [NativeName("GL_BUFFER_SIZE")]
    Size = 34660,

    [NativeName("GL_BUFFER_USAGE")]
    Usage = 34661,

    [NativeName("GL_BUFFER_ACCESS")]
    Access = 35003,

    [NativeName("GL_BUFFER_MAPPED")]
    Mapped = 35004,

    [NativeName("GL_BUFFER_ACCESS_FLAGS")]
    AccessFlags = 37151,

    [NativeName("GL_BUFFER_MAP_LENGTH")]
    MapLength = 37152,

    [NativeName("GL_BUFFER_MAP_OFFSET")]
    MapOffset = 37153,

    [NativeName("GL_BUFFER_IMMUTABLE_STORAGE")]
    ImmutableStorage = 33311,

    [NativeName("GL_BUFFER_STORAGE_FLAGS")]
    StorageFlags = 33312,

    [NativeName("GL_BUFFER_SIZE_ARB")]
    SizeARB = 34660,

    [NativeName("GL_BUFFER_USAGE_ARB")]
    UsageARB = 34661,

    [NativeName("GL_BUFFER_ACCESS_ARB")]
    AccessARB = 35003,

    [NativeName("GL_BUFFER_MAPPED_ARB")]
    MappedARB = 35004,
}
