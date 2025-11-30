// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "APPLE", 0)]
[NativeName("VertexArrayPNameAPPLE")]
[Transformed]
public enum VertexArrayPNameApple : uint
{
    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_STORAGE_CACHED_APPLE")]
    Cachedapple = unchecked((uint)0x85BE),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_STORAGE_SHARED_APPLE")]
    Sharedapple = unchecked((uint)0x85BF),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_STORAGE_CLIENT_APPLE")]
    Clientapple = unchecked((uint)0x85B4),
}
