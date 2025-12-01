// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelTransformPNameEXT")]
public enum PixelTransformPNameEXT : uint
{
    [NativeName("GL_PIXEL_MAG_FILTER_EXT")]
    MagFilterEXT = unchecked((uint)0x8331),

    [NativeName("GL_PIXEL_MIN_FILTER_EXT")]
    MinFilterEXT = unchecked((uint)0x8332),

    [NativeName("GL_PIXEL_CUBIC_WEIGHT_EXT")]
    CubicWeightEXT = unchecked((uint)0x8333),
}
