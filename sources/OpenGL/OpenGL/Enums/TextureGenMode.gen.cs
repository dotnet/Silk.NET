// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureGenMode : uint
{
    EyeLinear = unchecked((uint)0x2400),
    ObjectLinear = unchecked((uint)0x2401),
    SphereMap = unchecked((uint)0x2402),
    EyeDistanceToPointSGIS = unchecked((uint)0x81F0),
    ObjectDistanceToPointSGIS = unchecked((uint)0x81F1),
    EyeDistanceToLineSGIS = unchecked((uint)0x81F2),
    ObjectDistanceToLineSGIS = unchecked((uint)0x81F3),
}
