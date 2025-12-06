// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SpriteModeSGIX")]
public enum SpriteModeSGIX : uint
{
    [NativeName("GL_SPRITE_AXIAL_SGIX")]
    Axial = 33100,

    [NativeName("GL_SPRITE_OBJECT_ALIGNED_SGIX")]
    ObjectAligned = 33101,

    [NativeName("GL_SPRITE_EYE_ALIGNED_SGIX")]
    EyeAligned = 33102,
}
