// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexArrayPNameAPPLE")]
public enum VertexArrayPNameAPPLE : uint
{
    [NativeName("GL_STORAGE_CACHED_APPLE")]
    Cached = unchecked((uint)0x85BE),

    [NativeName("GL_STORAGE_SHARED_APPLE")]
    Shared = unchecked((uint)0x85BF),

    [NativeName("GL_STORAGE_CLIENT_APPLE")]
    Client = unchecked((uint)0x85B4),
}
