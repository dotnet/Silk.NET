// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureMagFilter : uint
{
    Nearest = 0x2600,
    Linear = 0x2601,
    LinearDetailSGIS = 0x8097,
    LinearDetailAlphaSGIS = 0x8098,
    LinearDetailColorSGIS = 0x8099,
    LinearSharpenSGIS = 0x80AD,
    LinearSharpenAlphaSGIS = 0x80AE,
    LinearSharpenColorSGIS = 0x80AF,
    Filter4Sgis = 0x8146
}
