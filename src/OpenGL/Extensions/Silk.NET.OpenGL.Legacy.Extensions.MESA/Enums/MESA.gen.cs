// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.MESA
{
    [NativeName("Name", "GLenum")]
    public enum MESA : int
    {
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_X_MESA")]
        FramebufferFlipXMesa = 0x8BBC,
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_Y_MESA")]
        FramebufferFlipYMesa = 0x8BBB,
        [NativeName("Name", "GL_FRAMEBUFFER_SWAP_XY_MESA")]
        FramebufferSwapXYMesa = 0x8BBD,
        [NativeName("Name", "GL_PACK_INVERT_MESA")]
        PackInvertMesa = 0x8758,
        [NativeName("Name", "GL_PROGRAM_BINARY_FORMAT_MESA")]
        ProgramBinaryFormatMesa = 0x875F,
        [NativeName("Name", "GL_CONST_BW_TILING_MESA")]
        ConstBWTilingMesa = 0x8BBE,
        [NativeName("Name", "GL_TILE_RASTER_ORDER_FIXED_MESA")]
        TileRasterOrderFixedMesa = 0x8BB8,
        [NativeName("Name", "GL_TILE_RASTER_ORDER_INCREASING_X_MESA")]
        TileRasterOrderIncreasingXMesa = 0x8BB9,
        [NativeName("Name", "GL_TILE_RASTER_ORDER_INCREASING_Y_MESA")]
        TileRasterOrderIncreasingYMesa = 0x8BBA,
        [NativeName("Name", "GL_UNSIGNED_SHORT_8_8_MESA")]
        UnsignedShort88Mesa = 0x85BA,
        [NativeName("Name", "GL_UNSIGNED_SHORT_8_8_REV_MESA")]
        UnsignedShort88RevMesa = 0x85BB,
        [NativeName("Name", "GL_YCBCR_MESA")]
        YcbcrMesa = 0x8757,
    }
}
