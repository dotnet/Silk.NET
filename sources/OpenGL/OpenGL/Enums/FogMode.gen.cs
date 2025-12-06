// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FogMode")]
public enum FogMode : uint
{
    [NativeName("GL_EXP")]
    Exp = 2048,

    [NativeName("GL_EXP2")]
    Exp2 = 2049,

    [NativeName("GL_LINEAR")]
    Linear = 9729,

    [NativeName("GL_FOG_FUNC_SGIS")]
    FogFuncSGIS = 33066,
}
