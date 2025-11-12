// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PathGenMode : uint
{
    None = unchecked((uint)0),
    EyeLinear = unchecked((uint)0x2400),
    ObjectLinear = unchecked((uint)0x2401),
    Constant = unchecked((uint)0x8576),
    PathObjectBoundingBoxNV = unchecked((uint)0x908A),
}
