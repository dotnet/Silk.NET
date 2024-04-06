// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum TextureWrapMode
{
    LinearMipmapLinear = 0x2703,
    Repeat = 0x2901,
    ClampToEdge = 0x812F,
    ClampToBorder = 0x812D,
    MirroredRepeat = 0x8370,
    ClampToBorderARB = 0x812D,
    Clamp = 0x2900,
    ClampToBorderSGIS = 0x812D,
    ClampToEdgeSGIS = 0x812F,
    ClampToBorderNV = 0x812D
}
