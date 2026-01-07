// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("OcclusionQueryParameterNameNV")]
public enum OcclusionQueryParameterNameNV : uint
{
    [NativeName("GL_PIXEL_COUNT_NV")]
    PixelCount = 34918,

    [NativeName("GL_PIXEL_COUNT_AVAILABLE_NV")]
    PixelCountAvailable = 34919,
}
