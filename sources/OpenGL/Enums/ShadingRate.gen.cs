// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ShadingRate : uint
{
    X1X1PixelsEXT = unchecked((uint)0x96A6),
    X1X2PixelsEXT = unchecked((uint)0x96A7),
    X2X1PixelsEXT = unchecked((uint)0x96A8),
    X2X2PixelsEXT = unchecked((uint)0x96A9),
    X1X4PixelsEXT = unchecked((uint)0x96AA),
    X4X1PixelsEXT = unchecked((uint)0x96AB),
    X4X2PixelsEXT = unchecked((uint)0x96AC),
    X2X4PixelsEXT = unchecked((uint)0x96AD),
    X4X4PixelsEXT = unchecked((uint)0x96AE)
}
