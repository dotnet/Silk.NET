// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("TextureNormalModeEXT")]
public enum TextureNormalModeEXT : uint
{
    [NameAffix("Suffix", "EXT", -1)]
    [NativeName("GL_PERTURB_EXT")]
    Perturb = unchecked((uint)0x85AE),
}
