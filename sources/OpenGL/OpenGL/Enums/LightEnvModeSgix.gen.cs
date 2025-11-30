// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "SGIX", 0)]
[NativeName("LightEnvModeSGIX")]
[Transformed]
public enum LightEnvModeSgix : uint
{
    [NativeName("GL_REPLACE")]
    Replace = unchecked((uint)0x1E01),

    [NativeName("GL_MODULATE")]
    Modulate = unchecked((uint)0x2100),

    [NativeName("GL_ADD")]
    Add = unchecked((uint)0x0104),
}
