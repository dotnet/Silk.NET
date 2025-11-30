// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "INTEL", 0)]
[NativeName("MapTextureFormatINTEL")]
[Transformed]
public enum MapTextureFormatIntel : uint
{
    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_LAYOUT_DEFAULT_INTEL")]
    Defaultintel = unchecked((uint)0),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_LAYOUT_LINEAR_INTEL")]
    Linearintel = unchecked((uint)1),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
    LinearCpuCachedintel = unchecked((uint)2),
}
