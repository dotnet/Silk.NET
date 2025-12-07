// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ShadingRate : uint
{
    Rate1X1PixelsEXT = unchecked((uint)0x96A6),
    Rate1X2PixelsEXT = unchecked((uint)0x96A7),
    Rate2X1PixelsEXT = unchecked((uint)0x96A8),
    Rate2X2PixelsEXT = unchecked((uint)0x96A9),
    Rate1X4PixelsEXT = unchecked((uint)0x96AA),
    Rate4X1PixelsEXT = unchecked((uint)0x96AB),
    Rate4X2PixelsEXT = unchecked((uint)0x96AC),
    Rate2X4PixelsEXT = unchecked((uint)0x96AD),
    Rate4X4PixelsEXT = unchecked((uint)0x96AE),
}
