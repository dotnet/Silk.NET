// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PNTrianglesPNameATI : uint
{
    PointMode = unchecked((uint)0x87F2),
    NormalMode = unchecked((uint)0x87F3),
    TesselationLevel = unchecked((uint)0x87F4),
}
