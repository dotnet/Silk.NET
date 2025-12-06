// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelDataRangeTargetNV")]
public enum PixelDataRangeTargetNV : uint
{
    [NativeName("GL_WRITE_PIXEL_DATA_RANGE_NV")]
    WritePixelDataRange = 34936,

    [NativeName("GL_READ_PIXEL_DATA_RANGE_NV")]
    ReadPixelDataRange = 34937,
}
