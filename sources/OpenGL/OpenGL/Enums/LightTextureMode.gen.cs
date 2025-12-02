// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", -1)]
[NativeName("LightTextureModeEXT")]
public enum LightTextureMode : uint
{
    [NativeName("GL_FRAGMENT_DEPTH")]
    Depth = 33874,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_DEPTH_EXT")]
    DepthEXT = 33874,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_MATERIAL_EXT")]
    MaterialEXT = 33609,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_NORMAL_EXT")]
    NormalEXT = 33610,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAGMENT_COLOR_EXT")]
    ColorEXT = 33612,
}
