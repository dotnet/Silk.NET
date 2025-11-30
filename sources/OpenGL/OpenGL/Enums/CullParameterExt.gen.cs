// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("CullParameterEXT")]
[Transformed]
public enum CullParameterExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CULL_VERTEX_EYE_POSITION_EXT")]
    EyePositionext = unchecked((uint)0x81AB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CULL_VERTEX_OBJECT_POSITION_EXT")]
    ObjectPositionext = unchecked((uint)0x81AC),
}
