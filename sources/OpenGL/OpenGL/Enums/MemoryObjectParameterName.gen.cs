// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MemoryObjectParameterName")]
[Transformed]
public enum MemoryObjectParameterName : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEDICATED_MEMORY_OBJECT_EXT")]
    DedicatedMemoryObjectext = unchecked((uint)0x9581),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PROTECTED_MEMORY_OBJECT_EXT")]
    ProtectedMemoryObjectext = unchecked((uint)0x959B),
}
