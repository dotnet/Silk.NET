// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MapTarget")]
[Transformed]
public enum MapTarget : uint
{
    [NativeName("GL_MAP1_COLOR_4")]
    Map1Color4 = unchecked((uint)0x0D90),

    [NativeName("GL_MAP1_INDEX")]
    Map1Index = unchecked((uint)0x0D91),

    [NativeName("GL_MAP1_NORMAL")]
    Map1Normal = unchecked((uint)0x0D92),

    [NativeName("GL_MAP1_TEXTURE_COORD_1")]
    Map1TextureCoord1 = unchecked((uint)0x0D93),

    [NativeName("GL_MAP1_TEXTURE_COORD_2")]
    Map1TextureCoord2 = unchecked((uint)0x0D94),

    [NativeName("GL_MAP1_TEXTURE_COORD_3")]
    Map1TextureCoord3 = unchecked((uint)0x0D95),

    [NativeName("GL_MAP1_TEXTURE_COORD_4")]
    Map1TextureCoord4 = unchecked((uint)0x0D96),

    [NativeName("GL_MAP1_VERTEX_3")]
    Map1Vertex3 = unchecked((uint)0x0D97),

    [NativeName("GL_MAP1_VERTEX_4")]
    Map1Vertex4 = unchecked((uint)0x0D98),

    [NativeName("GL_MAP2_COLOR_4")]
    Map2Color4 = unchecked((uint)0x0DB0),

    [NativeName("GL_MAP2_INDEX")]
    Map2Index = unchecked((uint)0x0DB1),

    [NativeName("GL_MAP2_NORMAL")]
    Map2Normal = unchecked((uint)0x0DB2),

    [NativeName("GL_MAP2_TEXTURE_COORD_1")]
    Map2TextureCoord1 = unchecked((uint)0x0DB3),

    [NativeName("GL_MAP2_TEXTURE_COORD_2")]
    Map2TextureCoord2 = unchecked((uint)0x0DB4),

    [NativeName("GL_MAP2_TEXTURE_COORD_3")]
    Map2TextureCoord3 = unchecked((uint)0x0DB5),

    [NativeName("GL_MAP2_TEXTURE_COORD_4")]
    Map2TextureCoord4 = unchecked((uint)0x0DB6),

    [NativeName("GL_MAP2_VERTEX_3")]
    Map2Vertex3 = unchecked((uint)0x0DB7),

    [NativeName("GL_MAP2_VERTEX_4")]
    Map2Vertex4 = unchecked((uint)0x0DB8),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_GEOMETRY_DEFORMATION_SGIX")]
    GeometryDeformationSGIX = unchecked((uint)0x8194),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_DEFORMATION_SGIX")]
    TextureDeformationSGIX = unchecked((uint)0x8195),
}
