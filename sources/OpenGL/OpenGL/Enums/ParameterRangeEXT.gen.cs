// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("ParameterRangeEXT")]
public enum ParameterRangeEXT : uint
{
    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_NORMALIZED_RANGE_EXT")]
    NormalizedRange = unchecked((uint)0x87E0),

    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_FULL_RANGE_EXT")]
    FullRange = unchecked((uint)0x87E1),
}
