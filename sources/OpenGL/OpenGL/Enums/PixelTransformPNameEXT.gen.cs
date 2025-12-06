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
    MagFilter = 33585,

    [NativeName("GL_PIXEL_MIN_FILTER_EXT")]
    MinFilter = 33586,

    [NativeName("GL_PIXEL_CUBIC_WEIGHT_EXT")]
    CubicWeight = 33587,
}
