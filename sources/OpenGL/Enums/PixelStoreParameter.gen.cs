// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum PixelStoreParameter
{
    UnpackSwapBytes = 0x0CF0,
    UnpackLsbFirst = 0x0CF1,
    UnpackRowLength = 0x0CF2,
    UnpackSkipRows = 0x0CF3,
    UnpackSkipPixels = 0x0CF4,
    UnpackAlignment = 0x0CF5,
    PackSwapBytes = 0x0D00,
    PackLsbFirst = 0x0D01,
    PackRowLength = 0x0D02,
    PackSkipRows = 0x0D03,
    PackSkipPixels = 0x0D04,
    PackAlignment = 0x0D05,
    PackSkipImages = 0x806B,
    PackImageHeight = 0x806C,
    UnpackSkipImages = 0x806D,
    UnpackImageHeight = 0x806E,
    PackSkipImagesEXT = 0x806B,
    PackImageHeightEXT = 0x806C,
    UnpackSkipImagesEXT = 0x806D,
    UnpackImageHeightEXT = 0x806E,
    PackResampleOML = 0x8984,
    UnpackResampleOML = 0x8985,
    PackSkipVolumesSGIS = 0x8130,
    PackImageDepthSGIS = 0x8131,
    UnpackSkipVolumesSGIS = 0x8132,
    UnpackImageDepthSGIS = 0x8133,
    PixelTileWidthSGIX = 0x8140,
    PixelTileHeightSGIX = 0x8141,
    PixelTileGridWidthSGIX = 0x8142,
    PixelTileGridHeightSGIX = 0x8143,
    PixelTileGridDepthSGIX = 0x8144,
    PixelTileCacheSizeSGIX = 0x8145,
    PackResampleSGIX = 0x842E,
    UnpackResampleSGIX = 0x842F,
    PackSubsampleRateSGIX = 0x85A0,
    UnpackSubsampleRateSGIX = 0x85A1,
    UnpackRowLengthEXT = 0x0CF2,
    UnpackSkipRowsEXT = 0x0CF3,
    UnpackSkipPixelsEXT = 0x0CF4,
    PackRowLengthNV = 0x0D02,
    PackSkipRowsNV = 0x0D03,
    PackSkipPixelsNV = 0x0D04
}
