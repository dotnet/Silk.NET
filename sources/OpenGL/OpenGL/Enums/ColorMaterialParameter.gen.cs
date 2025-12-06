// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ColorMaterialParameter")]
public enum ColorMaterialParameter : uint
{
    [NativeName("GL_AMBIENT")]
    Ambient = 4608,

    [NativeName("GL_DIFFUSE")]
    Diffuse = 4609,

    [NativeName("GL_SPECULAR")]
    Specular = 4610,

    [NativeName("GL_EMISSION")]
    Emission = 5632,

    [NativeName("GL_AMBIENT_AND_DIFFUSE")]
    AmbientAndDiffuse = 5634,
}
