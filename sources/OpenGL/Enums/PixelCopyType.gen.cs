// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelCopyType : uint
{
    Color = 0x1800,
    Depth = 0x1801,
    Stencil = 0x1802,
    ColorEXT = 0x1800,
    DepthEXT = 0x1801,
    StencilEXT = 0x1802
}
