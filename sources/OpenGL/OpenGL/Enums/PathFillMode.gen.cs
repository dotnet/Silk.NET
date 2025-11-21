// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PathFillMode : uint
{
    Invert = unchecked((uint)0x150A),
    PathFillModeNV = unchecked((uint)0x9080),
    CountUpNV = unchecked((uint)0x9088),
    CountDownNV = unchecked((uint)0x9089),
}
