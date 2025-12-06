// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathColor")]
public enum PathColor : uint
{
    [NativeName("GL_PRIMARY_COLOR")]
    PrimaryColor = 34167,

    [NativeName("GL_PRIMARY_COLOR_NV")]
    PrimaryColorNV = 34092,

    [NativeName("GL_SECONDARY_COLOR_NV")]
    SecondaryColorNV = 34093,
}
