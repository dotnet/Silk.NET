// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelStoreParameter")]
public enum PixelStoreParameter : uint
{
    [NativeName("GL_UNPACK_ALIGNMENT")]
    UnpackAlignment = 3317,

    [NativeName("GL_PACK_ALIGNMENT")]
    PackAlignment = 3333,

    [NativeName("GL_UNPACK_SWAP_BYTES")]
    UnpackSwapBytes = 3312,

    [NativeName("GL_UNPACK_LSB_FIRST")]
    UnpackLsbFirst = 3313,

    [NativeName("GL_UNPACK_ROW_LENGTH")]
    UnpackRowLength = 3314,

    [NativeName("GL_UNPACK_SKIP_ROWS")]
    UnpackSkipRows = 3315,

    [NativeName("GL_UNPACK_SKIP_PIXELS")]
    UnpackSkipPixels = 3316,

    [NativeName("GL_PACK_SWAP_BYTES")]
    PackSwapBytes = 3328,

    [NativeName("GL_PACK_LSB_FIRST")]
    PackLsbFirst = 3329,

    [NativeName("GL_PACK_ROW_LENGTH")]
    PackRowLength = 3330,

    [NativeName("GL_PACK_SKIP_ROWS")]
    PackSkipRows = 3331,

    [NativeName("GL_PACK_SKIP_PIXELS")]
    PackSkipPixels = 3332,

    [NativeName("GL_PACK_SKIP_IMAGES")]
    PackSkipImages = 32875,

    [NativeName("GL_PACK_IMAGE_HEIGHT")]
    PackImageHeight = 32876,

    [NativeName("GL_UNPACK_SKIP_IMAGES")]
    UnpackSkipImages = 32877,

    [NativeName("GL_UNPACK_IMAGE_HEIGHT")]
    UnpackImageHeight = 32878,

    [NativeName("GL_PACK_SKIP_IMAGES_EXT")]
    PackSkipImagesEXT = 32875,

    [NativeName("GL_PACK_IMAGE_HEIGHT_EXT")]
    PackImageHeightEXT = 32876,

    [NativeName("GL_UNPACK_SKIP_IMAGES_EXT")]
    UnpackSkipImagesEXT = 32877,

    [NativeName("GL_UNPACK_IMAGE_HEIGHT_EXT")]
    UnpackImageHeightEXT = 32878,

    [NativeName("GL_PACK_RESAMPLE_OML")]
    PackResampleOML = 35204,

    [NativeName("GL_UNPACK_RESAMPLE_OML")]
    UnpackResampleOML = 35205,

    [NativeName("GL_PACK_SKIP_VOLUMES_SGIS")]
    PackSkipVolumesSGIS = 33072,

    [NativeName("GL_PACK_IMAGE_DEPTH_SGIS")]
    PackImageDepthSGIS = 33073,

    [NativeName("GL_UNPACK_SKIP_VOLUMES_SGIS")]
    UnpackSkipVolumesSGIS = 33074,

    [NativeName("GL_UNPACK_IMAGE_DEPTH_SGIS")]
    UnpackImageDepthSGIS = 33075,

    [NativeName("GL_PIXEL_TILE_WIDTH_SGIX")]
    PixelTileWidthSGIX = 33088,

    [NativeName("GL_PIXEL_TILE_HEIGHT_SGIX")]
    PixelTileHeightSGIX = 33089,

    [NativeName("GL_PIXEL_TILE_GRID_WIDTH_SGIX")]
    PixelTileGridWidthSGIX = 33090,

    [NativeName("GL_PIXEL_TILE_GRID_HEIGHT_SGIX")]
    PixelTileGridHeightSGIX = 33091,

    [NativeName("GL_PIXEL_TILE_GRID_DEPTH_SGIX")]
    PixelTileGridDepthSGIX = 33092,

    [NativeName("GL_PIXEL_TILE_CACHE_SIZE_SGIX")]
    PixelTileCacheSizeSGIX = 33093,

    [NativeName("GL_PACK_RESAMPLE_SGIX")]
    PackResampleSGIX = 33838,

    [NativeName("GL_UNPACK_RESAMPLE_SGIX")]
    UnpackResampleSGIX = 33839,

    [NativeName("GL_PACK_SUBSAMPLE_RATE_SGIX")]
    PackSubsampleRateSGIX = 34208,

    [NativeName("GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
    UnpackSubsampleRateSGIX = 34209,

    [NativeName("GL_UNPACK_ROW_LENGTH_EXT")]
    UnpackRowLengthEXT = 3314,

    [NativeName("GL_UNPACK_SKIP_ROWS_EXT")]
    UnpackSkipRowsEXT = 3315,

    [NativeName("GL_UNPACK_SKIP_PIXELS_EXT")]
    UnpackSkipPixelsEXT = 3316,

    [NativeName("GL_PACK_ROW_LENGTH_NV")]
    PackRowLengthNV = 3330,

    [NativeName("GL_PACK_SKIP_ROWS_NV")]
    PackSkipRowsNV = 3331,

    [NativeName("GL_PACK_SKIP_PIXELS_NV")]
    PackSkipPixelsNV = 3332,
}
