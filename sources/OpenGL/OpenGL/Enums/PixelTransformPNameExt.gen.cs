// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("PixelTransformPNameEXT")]
[Transformed]
public enum PixelTransformPNameExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_MAG_FILTER_EXT")]
    MagFilterext = unchecked((uint)0x8331),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_MIN_FILTER_EXT")]
    MinFilterext = unchecked((uint)0x8332),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_CUBIC_WEIGHT_EXT")]
    CubicWeightext = unchecked((uint)0x8333),
}
