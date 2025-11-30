// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureGenMode")]
[Transformed]
public enum TextureGenMode : uint
{
    [NativeName("GL_EYE_LINEAR")]
    EyeLinear = unchecked((uint)0x2400),

    [NativeName("GL_OBJECT_LINEAR")]
    ObjectLinear = unchecked((uint)0x2401),

    [NativeName("GL_SPHERE_MAP")]
    SphereMap = unchecked((uint)0x2402),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_EYE_DISTANCE_TO_POINT_SGIS")]
    EyeDistanceToPointsgis = unchecked((uint)0x81F0),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_OBJECT_DISTANCE_TO_POINT_SGIS")]
    ObjectDistanceToPointsgis = unchecked((uint)0x81F1),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_EYE_DISTANCE_TO_LINE_SGIS")]
    EyeDistanceToLinesgis = unchecked((uint)0x81F2),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_OBJECT_DISTANCE_TO_LINE_SGIS")]
    ObjectDistanceToLinesgis = unchecked((uint)0x81F3),
}
