// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("LightTexturePNameEXT")]
[Transformed]
public enum LightTexturePNameExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ATTENUATION_EXT")]
    Attenuationext = unchecked((uint)0x834D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADOW_ATTENUATION_EXT")]
    ShadowAttenuationext = unchecked((uint)0x834E),
}
