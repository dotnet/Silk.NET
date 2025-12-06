// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureMagFilter : uint
{
    Nearest = unchecked((uint)0x2600),
    Linear = unchecked((uint)0x2601),
    LinearDetailSGIS = unchecked((uint)0x8097),
    LinearDetailAlphaSGIS = unchecked((uint)0x8098),
    LinearDetailColorSGIS = unchecked((uint)0x8099),
    LinearSharpenSGIS = unchecked((uint)0x80AD),
    LinearSharpenAlphaSGIS = unchecked((uint)0x80AE),
    LinearSharpenColorSGIS = unchecked((uint)0x80AF),
    Filter4Sgis = unchecked((uint)0x8146),
}
