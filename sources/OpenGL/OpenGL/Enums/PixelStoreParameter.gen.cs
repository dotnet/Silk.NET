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
    UnpackAlignment = unchecked((uint)0x0CF5),

    [NativeName("GL_PACK_ALIGNMENT")]
    PackAlignment = unchecked((uint)0x0D05),

    [NativeName("GL_UNPACK_SWAP_BYTES")]
    UnpackSwapBytes = unchecked((uint)0x0CF0),

    [NativeName("GL_UNPACK_LSB_FIRST")]
    UnpackLsbFirst = unchecked((uint)0x0CF1),

    [NativeName("GL_UNPACK_ROW_LENGTH")]
    UnpackRowLength = unchecked((uint)0x0CF2),

    [NativeName("GL_UNPACK_SKIP_ROWS")]
    UnpackSkipRows = unchecked((uint)0x0CF3),

    [NativeName("GL_UNPACK_SKIP_PIXELS")]
    UnpackSkipPixels = unchecked((uint)0x0CF4),

    [NativeName("GL_PACK_SWAP_BYTES")]
    PackSwapBytes = unchecked((uint)0x0D00),

    [NativeName("GL_PACK_LSB_FIRST")]
    PackLsbFirst = unchecked((uint)0x0D01),

    [NativeName("GL_PACK_ROW_LENGTH")]
    PackRowLength = unchecked((uint)0x0D02),

    [NativeName("GL_PACK_SKIP_ROWS")]
    PackSkipRows = unchecked((uint)0x0D03),

    [NativeName("GL_PACK_SKIP_PIXELS")]
    PackSkipPixels = unchecked((uint)0x0D04),

    [NativeName("GL_PACK_SKIP_IMAGES")]
    PackSkipImages = unchecked((uint)0x806B),

    [NativeName("GL_PACK_IMAGE_HEIGHT")]
    PackImageHeight = unchecked((uint)0x806C),

    [NativeName("GL_UNPACK_SKIP_IMAGES")]
    UnpackSkipImages = unchecked((uint)0x806D),

    [NativeName("GL_UNPACK_IMAGE_HEIGHT")]
    UnpackImageHeight = unchecked((uint)0x806E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PACK_SKIP_IMAGES_EXT")]
    PackSkipImagesEXT = unchecked((uint)0x806B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PACK_IMAGE_HEIGHT_EXT")]
    PackImageHeightEXT = unchecked((uint)0x806C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_SKIP_IMAGES_EXT")]
    UnpackSkipImagesEXT = unchecked((uint)0x806D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_IMAGE_HEIGHT_EXT")]
    UnpackImageHeightEXT = unchecked((uint)0x806E),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_PACK_RESAMPLE_OML")]
    PackResampleOML = unchecked((uint)0x8984),

    [NameAffix("Suffix", "OML", 0)]
    [NativeName("GL_UNPACK_RESAMPLE_OML")]
    UnpackResampleOML = unchecked((uint)0x8985),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PACK_SKIP_VOLUMES_SGIS")]
    PackSkipVolumesSGIS = unchecked((uint)0x8130),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_PACK_IMAGE_DEPTH_SGIS")]
    PackImageDepthSGIS = unchecked((uint)0x8131),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_UNPACK_SKIP_VOLUMES_SGIS")]
    UnpackSkipVolumesSGIS = unchecked((uint)0x8132),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_UNPACK_IMAGE_DEPTH_SGIS")]
    UnpackImageDepthSGIS = unchecked((uint)0x8133),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_WIDTH_SGIX")]
    PixelTileWidthSGIX = unchecked((uint)0x8140),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_HEIGHT_SGIX")]
    PixelTileHeightSGIX = unchecked((uint)0x8141),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_GRID_WIDTH_SGIX")]
    PixelTileGridWidthSGIX = unchecked((uint)0x8142),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_GRID_HEIGHT_SGIX")]
    PixelTileGridHeightSGIX = unchecked((uint)0x8143),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_GRID_DEPTH_SGIX")]
    PixelTileGridDepthSGIX = unchecked((uint)0x8144),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_TILE_CACHE_SIZE_SGIX")]
    PixelTileCacheSizeSGIX = unchecked((uint)0x8145),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PACK_RESAMPLE_SGIX")]
    PackResampleSGIX = unchecked((uint)0x842E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_UNPACK_RESAMPLE_SGIX")]
    UnpackResampleSGIX = unchecked((uint)0x842F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PACK_SUBSAMPLE_RATE_SGIX")]
    PackSubsampleRateSGIX = unchecked((uint)0x85A0),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_UNPACK_SUBSAMPLE_RATE_SGIX")]
    UnpackSubsampleRateSGIX = unchecked((uint)0x85A1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_ROW_LENGTH_EXT")]
    UnpackRowLengthEXT = unchecked((uint)0x0CF2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_SKIP_ROWS_EXT")]
    UnpackSkipRowsEXT = unchecked((uint)0x0CF3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNPACK_SKIP_PIXELS_EXT")]
    UnpackSkipPixelsEXT = unchecked((uint)0x0CF4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PACK_ROW_LENGTH_NV")]
    PackRowLengthNV = unchecked((uint)0x0D02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PACK_SKIP_ROWS_NV")]
    PackSkipRowsNV = unchecked((uint)0x0D03),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PACK_SKIP_PIXELS_NV")]
    PackSkipPixelsNV = unchecked((uint)0x0D04),
}
