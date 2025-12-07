// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ImageTransformPNameHP : uint
{
    ScaleX = unchecked((uint)0x8155),
    ScaleY = unchecked((uint)0x8156),
    TranslateX = unchecked((uint)0x8157),
    TranslateY = unchecked((uint)0x8158),
    RotateAngle = unchecked((uint)0x8159),
    RotateOriginX = unchecked((uint)0x815A),
    RotateOriginY = unchecked((uint)0x815B),
    MagFilter = unchecked((uint)0x815C),
    MinFilter = unchecked((uint)0x815D),
    CubicWeight = unchecked((uint)0x815E),
}
