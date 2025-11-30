// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "SGIX", 0)]
[NativeName("FfdTargetSGIX")]
[Transformed]
public enum FfdTargetSGIX : uint
{
    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_GEOMETRY_DEFORMATION_SGIX")]
    GeometryDeformationSGIX = unchecked((uint)0x8194),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_DEFORMATION_SGIX")]
    TextureDeformationSGIX = unchecked((uint)0x8195),
}
