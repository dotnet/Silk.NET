// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("LightTextureModeEXT")]
public enum LightTextureModeEXT : uint
{
    [NativeName("GL_FRAGMENT_DEPTH")]
    Depth = unchecked((uint)0x8452),

    [NativeName("GL_FRAGMENT_DEPTH_EXT")]
    DepthEXT = unchecked((uint)0x8452),

    [NativeName("GL_FRAGMENT_MATERIAL_EXT")]
    MaterialEXT = unchecked((uint)0x8349),

    [NativeName("GL_FRAGMENT_NORMAL_EXT")]
    NormalEXT = unchecked((uint)0x834A),

    [NativeName("GL_FRAGMENT_COLOR_EXT")]
    ColorEXT = unchecked((uint)0x834C),
}
