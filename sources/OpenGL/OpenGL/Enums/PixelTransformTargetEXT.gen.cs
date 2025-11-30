// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("PixelTransformTargetEXT")]
[Transformed]
public enum PixelTransformTargetEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_TRANSFORM_2D_EXT")]
    PixelTransform2DEXT = unchecked((uint)0x8330),
}
