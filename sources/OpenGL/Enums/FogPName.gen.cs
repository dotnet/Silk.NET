// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FogPName : uint
{
    FogIndex = 0x0B61,
    FogDensity = 0x0B62,
    FogStart = 0x0B63,
    FogEnd = 0x0B64,
    FogMode = 0x0B65,
    FogCoordSrc = 0x8450
}
