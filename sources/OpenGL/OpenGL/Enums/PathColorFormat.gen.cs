// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PathColorFormat : uint
{
    None = unchecked((uint)0),
    Alpha = unchecked((uint)0x1906),
    Rgb = unchecked((uint)0x1907),
    Rgba = unchecked((uint)0x1908),
    Luminance = unchecked((uint)0x1909),
    LuminanceAlpha = unchecked((uint)0x190A),
    Intensity = unchecked((uint)0x8049),
}
