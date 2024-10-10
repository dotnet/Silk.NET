// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FogParameter : uint
{
    FogIndex = unchecked((uint)0x0B61),
    FogDensity = unchecked((uint)0x0B62),
    FogStart = unchecked((uint)0x0B63),
    FogEnd = unchecked((uint)0x0B64),
    FogMode = unchecked((uint)0x0B65),
    FogColor = unchecked((uint)0x0B66),
    FogOffsetValueSGIX = unchecked((uint)0x8199)
}
