// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelMap : uint
{
    IToI = unchecked((uint)0x0C70),
    SToS = unchecked((uint)0x0C71),
    IToR = unchecked((uint)0x0C72),
    IToG = unchecked((uint)0x0C73),
    IToB = unchecked((uint)0x0C74),
    IToA = unchecked((uint)0x0C75),
    RToR = unchecked((uint)0x0C76),
    GToG = unchecked((uint)0x0C77),
    BToB = unchecked((uint)0x0C78),
    AToA = unchecked((uint)0x0C79),
}
