// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VertexShaderStorageTypeEXT")]
[Transformed]
public enum VertexShaderStorageTypeExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VARIANT_EXT")]
    Variantext = unchecked((uint)0x87C1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INVARIANT_EXT")]
    Invariantext = unchecked((uint)0x87C2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LOCAL_CONSTANT_EXT")]
    LocalConstantext = unchecked((uint)0x87C3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LOCAL_EXT")]
    Localext = unchecked((uint)0x87C4),
}
