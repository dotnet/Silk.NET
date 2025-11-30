// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("GetMinmaxParameterPNameEXT")]
[Transformed]
public enum GetMinmaxParameterPNameExt : uint
{
    [NativeName("GL_MINMAX_FORMAT")]
    Format = unchecked((uint)0x802F),

    [NativeName("GL_MINMAX_SINK")]
    Sink = unchecked((uint)0x8030),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MINMAX_FORMAT_EXT")]
    Formatext = unchecked((uint)0x802F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_MINMAX_SINK_EXT")]
    Sinkext = unchecked((uint)0x8030),
}
