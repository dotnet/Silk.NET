// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureGenMode : uint
{
    EyeLinear = 0x2400,
    ObjectLinear = 0x2401,
    SphereMap = 0x2402,
    EyeDistanceToPointSGIS = 0x81F0,
    ObjectDistanceToPointSGIS = 0x81F1,
    EyeDistanceToLineSGIS = 0x81F2,
    ObjectDistanceToLineSGIS = 0x81F3
}
