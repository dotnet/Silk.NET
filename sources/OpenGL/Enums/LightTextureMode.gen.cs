// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum LightTextureMode : uint
{
    Depth = 0x8452,
    DepthEXT = 0x8452,
    MaterialEXT = 0x8349,
    NormalEXT = 0x834A,
    ColorEXT = 0x834C
}
