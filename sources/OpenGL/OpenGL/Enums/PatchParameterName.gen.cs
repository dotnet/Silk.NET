// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PatchParameterName")]
[Transformed]
public enum PatchParameterName : uint
{
    [NativeName("GL_PATCH_VERTICES")]
    Vertices = unchecked((uint)0x8E72),

    [NativeName("GL_PATCH_DEFAULT_INNER_LEVEL")]
    DefaultInnerLevel = unchecked((uint)0x8E73),

    [NativeName("GL_PATCH_DEFAULT_OUTER_LEVEL")]
    DefaultOuterLevel = unchecked((uint)0x8E74),
}
