// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "INTEL", 0)]
[NativeName("MapTextureFormatINTEL")]
public enum MapTextureFormatINTEL : uint
{
    [NameAffix("Suffix", "INTEL", -1)]
    [NativeName("GL_LAYOUT_DEFAULT_INTEL")]
    Default = unchecked((uint)0),

    [NameAffix("Suffix", "INTEL", -1)]
    [NativeName("GL_LAYOUT_LINEAR_INTEL")]
    Linear = unchecked((uint)1),

    [NameAffix("Suffix", "INTEL", -1)]
    [NativeName("GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
    LinearCpuCached = unchecked((uint)2),
}
