// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [NativeName("Name", "GLenum")]
    public enum IBM : int
    {
        [NativeName("Name", "GL_CULL_VERTEX_IBM")]
        CullVertexIbm = 0x103050,
        [NativeName("Name", "GL_RASTER_POSITION_UNCLIPPED_IBM")]
        RasterPositionUnclippedIbm = 0x19262,
        [NativeName("Name", "GL_ALL_STATIC_DATA_IBM")]
        AllStaticDataIbm = 0x103060,
        [NativeName("Name", "GL_STATIC_VERTEX_ARRAY_IBM")]
        StaticVertexArrayIbm = 0x103061,
        [NativeName("Name", "GL_MIRRORED_REPEAT_IBM")]
        MirroredRepeatIbm = 0x8370,
        [NativeName("Name", "GL_VERTEX_ARRAY_LIST_IBM")]
        VertexArrayListIbm = 0x103070,
        [NativeName("Name", "GL_NORMAL_ARRAY_LIST_IBM")]
        NormalArrayListIbm = 0x103071,
        [NativeName("Name", "GL_COLOR_ARRAY_LIST_IBM")]
        ColorArrayListIbm = 0x103072,
        [NativeName("Name", "GL_INDEX_ARRAY_LIST_IBM")]
        IndexArrayListIbm = 0x103073,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_LIST_IBM")]
        TextureCoordArrayListIbm = 0x103074,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_LIST_IBM")]
        EdgeFlagArrayListIbm = 0x103075,
        [NativeName("Name", "GL_FOG_COORDINATE_ARRAY_LIST_IBM")]
        FogCoordinateArrayListIbm = 0x103076,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_LIST_IBM")]
        SecondaryColorArrayListIbm = 0x103077,
        [NativeName("Name", "GL_VERTEX_ARRAY_LIST_STRIDE_IBM")]
        VertexArrayListStrideIbm = 0x103080,
        [NativeName("Name", "GL_NORMAL_ARRAY_LIST_STRIDE_IBM")]
        NormalArrayListStrideIbm = 0x103081,
        [NativeName("Name", "GL_COLOR_ARRAY_LIST_STRIDE_IBM")]
        ColorArrayListStrideIbm = 0x103082,
        [NativeName("Name", "GL_INDEX_ARRAY_LIST_STRIDE_IBM")]
        IndexArrayListStrideIbm = 0x103083,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM")]
        TextureCoordArrayListStrideIbm = 0x103084,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM")]
        EdgeFlagArrayListStrideIbm = 0x103085,
        [NativeName("Name", "GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM")]
        FogCoordinateArrayListStrideIbm = 0x103086,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM")]
        SecondaryColorArrayListStrideIbm = 0x103087,
    }
}
