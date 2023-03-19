// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelStoreParameter")]
    public enum PixelStoreParameter : int
    {
        [NativeName("Name", "GL_UNPACK_SWAP_BYTES")]
        UnpackSwapBytes = 0xCF0,
        [NativeName("Name", "GL_UNPACK_LSB_FIRST")]
        UnpackLsbFirst = 0xCF1,
        [NativeName("Name", "GL_UNPACK_ROW_LENGTH")]
        UnpackRowLength = 0xCF2,
        [NativeName("Name", "GL_UNPACK_ROW_LENGTH_EXT")]
        UnpackRowLengthExt = 0xCF2,
        [NativeName("Name", "GL_UNPACK_SKIP_ROWS")]
        UnpackSkipRows = 0xCF3,
        [NativeName("Name", "GL_UNPACK_SKIP_ROWS_EXT")]
        UnpackSkipRowsExt = 0xCF3,
        [NativeName("Name", "GL_UNPACK_SKIP_PIXELS")]
        UnpackSkipPixels = 0xCF4,
        [NativeName("Name", "GL_UNPACK_SKIP_PIXELS_EXT")]
        UnpackSkipPixelsExt = 0xCF4,
        [NativeName("Name", "GL_UNPACK_ALIGNMENT")]
        UnpackAlignment = 0xCF5,
        [NativeName("Name", "GL_PACK_SWAP_BYTES")]
        PackSwapBytes = 0xD00,
        [NativeName("Name", "GL_PACK_LSB_FIRST")]
        PackLsbFirst = 0xD01,
        [NativeName("Name", "GL_PACK_ROW_LENGTH")]
        PackRowLength = 0xD02,
        [NativeName("Name", "GL_PACK_ROW_LENGTH_NV")]
        PackRowLengthNV = 0xD02,
        [NativeName("Name", "GL_PACK_SKIP_ROWS")]
        PackSkipRows = 0xD03,
        [NativeName("Name", "GL_PACK_SKIP_ROWS_NV")]
        PackSkipRowsNV = 0xD03,
        [NativeName("Name", "GL_PACK_SKIP_PIXELS")]
        PackSkipPixels = 0xD04,
        [NativeName("Name", "GL_PACK_SKIP_PIXELS_NV")]
        PackSkipPixelsNV = 0xD04,
        [NativeName("Name", "GL_PACK_ALIGNMENT")]
        PackAlignment = 0xD05,
        [NativeName("Name", "GL_PACK_SKIP_IMAGES")]
        PackSkipImages = 0x806B,
        [NativeName("Name", "GL_PACK_SKIP_IMAGES_EXT")]
        PackSkipImagesExt = 0x806B,
        [NativeName("Name", "GL_PACK_IMAGE_HEIGHT")]
        PackImageHeight = 0x806C,
        [NativeName("Name", "GL_PACK_IMAGE_HEIGHT_EXT")]
        PackImageHeightExt = 0x806C,
        [NativeName("Name", "GL_UNPACK_SKIP_IMAGES")]
        UnpackSkipImages = 0x806D,
        [NativeName("Name", "GL_UNPACK_SKIP_IMAGES_EXT")]
        UnpackSkipImagesExt = 0x806D,
        [NativeName("Name", "GL_UNPACK_IMAGE_HEIGHT")]
        UnpackImageHeight = 0x806E,
        [NativeName("Name", "GL_UNPACK_IMAGE_HEIGHT_EXT")]
        UnpackImageHeightExt = 0x806E,
        [NativeName("Name", "GL_PACK_SKIP_VOLUMES_SGIS")]
        PackSkipVolumesSgis = 0x8130,
        [NativeName("Name", "GL_PACK_IMAGE_DEPTH_SGIS")]
        PackImageDepthSgis = 0x8131,
        [NativeName("Name", "GL_UNPACK_SKIP_VOLUMES_SGIS")]
        UnpackSkipVolumesSgis = 0x8132,
        [NativeName("Name", "GL_UNPACK_IMAGE_DEPTH_SGIS")]
        UnpackImageDepthSgis = 0x8133,
        [NativeName("Name", "GL_PIXEL_TILE_WIDTH_SGIX")]
        PixelTileWidthSgix = 0x8140,
        [NativeName("Name", "GL_PIXEL_TILE_HEIGHT_SGIX")]
        PixelTileHeightSgix = 0x8141,
        [NativeName("Name", "GL_PIXEL_TILE_GRID_WIDTH_SGIX")]
        PixelTileGridWidthSgix = 0x8142,
        [NativeName("Name", "GL_PIXEL_TILE_GRID_HEIGHT_SGIX")]
        PixelTileGridHeightSgix = 0x8143,
        [NativeName("Name", "GL_PIXEL_TILE_GRID_DEPTH_SGIX")]
        PixelTileGridDepthSgix = 0x8144,
        [NativeName("Name", "GL_PIXEL_TILE_CACHE_SIZE_SGIX")]
        PixelTileCacheSizeSgix = 0x8145,
        [NativeName("Name", "GL_PACK_RESAMPLE_SGIX")]
        PackResampleSgix = 0x842E,
        [NativeName("Name", "GL_UNPACK_RESAMPLE_SGIX")]
        UnpackResampleSgix = 0x842F,
        [NativeName("Name", "GL_PACK_SUBSAMPLE_RATE_SGIX")]
        PackSubsampleRateSgix = 0x85A0,
        [NativeName("Name", "GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
        UnpackSubsampleRateSgix = 0x85A1,
        [NativeName("Name", "GL_PACK_RESAMPLE_OML")]
        PackResampleOml = 0x8984,
        [NativeName("Name", "GL_UNPACK_RESAMPLE_OML")]
        UnpackResampleOml = 0x8985,
    }
}
