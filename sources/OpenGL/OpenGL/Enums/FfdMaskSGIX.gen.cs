// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FfdMaskSGIX")]
[Flags]
public enum FfdMaskSGIX : uint
{
    None = 0x0,

    [NativeName("GL_TEXTURE_DEFORMATION_BIT_SGIX")]
    TextureDeformationBit = 0x1,

    [NativeName("GL_GEOMETRY_DEFORMATION_BIT_SGIX")]
    GeometryDeformationBit = 0x2,
}
