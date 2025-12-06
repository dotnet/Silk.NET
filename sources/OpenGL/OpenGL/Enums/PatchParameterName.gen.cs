// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PatchParameterName")]
public enum PatchParameterName : uint
{
    [NativeName("GL_PATCH_VERTICES")]
    Vertices = 36466,

    [NativeName("GL_PATCH_DEFAULT_INNER_LEVEL")]
    DefaultInnerLevel = 36467,

    [NativeName("GL_PATCH_DEFAULT_OUTER_LEVEL")]
    DefaultOuterLevel = 36468,
}
