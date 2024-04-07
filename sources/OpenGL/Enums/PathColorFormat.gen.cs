// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PathColorFormat : uint
{
    NONE = 0,
    Alpha = 0x1906,
    RGB = 0x1907,
    RGBA = 0x1908,
    Luminance = 0x1909,
    LuminanceAlpha = 0x190A,
    Intensity = 0x8049
}
