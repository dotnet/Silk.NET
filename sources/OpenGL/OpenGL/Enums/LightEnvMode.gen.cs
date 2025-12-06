// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("LightEnvModeSGIX")]
public enum LightEnvMode : uint
{
    [NativeName("GL_REPLACE")]
    Replace = 7681,

    [NativeName("GL_ADD")]
    Add = 260,

    [NativeName("GL_MODULATE")]
    Modulate = 8448,
}
