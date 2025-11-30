// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "SGIX", 0)]
[NativeName("SpriteModeSGIX")]
[Transformed]
public enum SpriteModeSgix : uint
{
    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_AXIAL_SGIX")]
    Axialsgix = unchecked((uint)0x814C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_OBJECT_ALIGNED_SGIX")]
    ObjectAlignedsgix = unchecked((uint)0x814D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SPRITE_EYE_ALIGNED_SGIX")]
    EyeAlignedsgix = unchecked((uint)0x814E),
}
