// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "MapTarget")]
    public enum MapTarget : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_COLOR_4")]
        Map1Color4 = 0xD90,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_INDEX")]
        Map1Index = 0xD91,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_NORMAL")]
        Map1Normal = 0xD92,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_1")]
        Map1TextureCoord1 = 0xD93,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_2")]
        Map1TextureCoord2 = 0xD94,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_3")]
        Map1TextureCoord3 = 0xD95,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_TEXTURE_COORD_4")]
        Map1TextureCoord4 = 0xD96,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_VERTEX_3")]
        Map1Vertex3 = 0xD97,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP1_VERTEX_4")]
        Map1Vertex4 = 0xD98,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_COLOR_4")]
        Map2Color4 = 0xDB0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_INDEX")]
        Map2Index = 0xDB1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_NORMAL")]
        Map2Normal = 0xDB2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_1")]
        Map2TextureCoord1 = 0xDB3,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_2")]
        Map2TextureCoord2 = 0xDB4,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_3")]
        Map2TextureCoord3 = 0xDB5,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_TEXTURE_COORD_4")]
        Map2TextureCoord4 = 0xDB6,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_VERTEX_3")]
        Map2Vertex3 = 0xDB7,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MAP2_VERTEX_4")]
        Map2Vertex4 = 0xDB8,
        [NativeName("Name", "GL_GEOMETRY_DEFORMATION_SGIX")]
        GeometryDeformationSgix = 0x8194,
        [NativeName("Name", "GL_TEXTURE_DEFORMATION_SGIX")]
        TextureDeformationSgix = 0x8195,
    }
}
