// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureWrapMode : uint
{
    LinearMipmapLinear = unchecked((uint)0x2703),
    Repeat = unchecked((uint)0x2901),
    Clamp = unchecked((uint)0x2900),
    ClampToEdge = unchecked((uint)0x812F),
    ClampToBorder = unchecked((uint)0x812D),
    MirroredRepeat = unchecked((uint)0x8370),
    ClampToBorderARB = unchecked((uint)0x812D),
    ClampToBorderSGIS = unchecked((uint)0x812D),
    ClampToEdgeSGIS = unchecked((uint)0x812F),
    ClampToBorderNV = unchecked((uint)0x812D),
}
