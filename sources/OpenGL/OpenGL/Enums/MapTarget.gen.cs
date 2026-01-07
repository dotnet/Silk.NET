// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MapTarget")]
public enum MapTarget : uint
{
    [NativeName("GL_MAP1_COLOR_4")]
    Map1Color4 = 3472,

    [NativeName("GL_MAP1_INDEX")]
    Map1Index = 3473,

    [NativeName("GL_MAP1_NORMAL")]
    Map1Normal = 3474,

    [NativeName("GL_MAP1_TEXTURE_COORD_1")]
    Map1TextureCoord1 = 3475,

    [NativeName("GL_MAP1_TEXTURE_COORD_2")]
    Map1TextureCoord2 = 3476,

    [NativeName("GL_MAP1_TEXTURE_COORD_3")]
    Map1TextureCoord3 = 3477,

    [NativeName("GL_MAP1_TEXTURE_COORD_4")]
    Map1TextureCoord4 = 3478,

    [NativeName("GL_MAP1_VERTEX_3")]
    Map1Vertex3 = 3479,

    [NativeName("GL_MAP1_VERTEX_4")]
    Map1Vertex4 = 3480,

    [NativeName("GL_MAP2_COLOR_4")]
    Map2Color4 = 3504,

    [NativeName("GL_MAP2_INDEX")]
    Map2Index = 3505,

    [NativeName("GL_MAP2_NORMAL")]
    Map2Normal = 3506,

    [NativeName("GL_MAP2_TEXTURE_COORD_1")]
    Map2TextureCoord1 = 3507,

    [NativeName("GL_MAP2_TEXTURE_COORD_2")]
    Map2TextureCoord2 = 3508,

    [NativeName("GL_MAP2_TEXTURE_COORD_3")]
    Map2TextureCoord3 = 3509,

    [NativeName("GL_MAP2_TEXTURE_COORD_4")]
    Map2TextureCoord4 = 3510,

    [NativeName("GL_MAP2_VERTEX_3")]
    Map2Vertex3 = 3511,

    [NativeName("GL_MAP2_VERTEX_4")]
    Map2Vertex4 = 3512,

    [NativeName("GL_GEOMETRY_DEFORMATION_SGIX")]
    GeometryDeformationSGIX = 33172,

    [NativeName("GL_TEXTURE_DEFORMATION_SGIX")]
    TextureDeformationSGIX = 33173,
}
