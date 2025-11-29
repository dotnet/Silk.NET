// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelStoreParameter : uint
{
    UnpackSwapBytes = unchecked((uint)0x0CF0),
    UnpackLsbFirst = unchecked((uint)0x0CF1),
    UnpackRowLength = unchecked((uint)0x0CF2),
    UnpackSkipRows = unchecked((uint)0x0CF3),
    UnpackSkipPixels = unchecked((uint)0x0CF4),
    UnpackAlignment = unchecked((uint)0x0CF5),
    PackSwapBytes = unchecked((uint)0x0D00),
    PackLsbFirst = unchecked((uint)0x0D01),
    PackRowLength = unchecked((uint)0x0D02),
    PackSkipRows = unchecked((uint)0x0D03),
    PackSkipPixels = unchecked((uint)0x0D04),
    PackAlignment = unchecked((uint)0x0D05),
    PackSkipImages = unchecked((uint)0x806B),
    PackImageHeight = unchecked((uint)0x806C),
    UnpackSkipImages = unchecked((uint)0x806D),
    UnpackImageHeight = unchecked((uint)0x806E),
    PackSkipImagesEXT = unchecked((uint)0x806B),
    PackImageHeightEXT = unchecked((uint)0x806C),
    UnpackSkipImagesEXT = unchecked((uint)0x806D),
    UnpackImageHeightEXT = unchecked((uint)0x806E),
    PackResampleOML = unchecked((uint)0x8984),
    UnpackResampleOML = unchecked((uint)0x8985),
    PackSkipVolumesSGIS = unchecked((uint)0x8130),
    PackImageDepthSGIS = unchecked((uint)0x8131),
    UnpackSkipVolumesSGIS = unchecked((uint)0x8132),
    UnpackImageDepthSGIS = unchecked((uint)0x8133),
    PixelTileWidthSGIX = unchecked((uint)0x8140),
    PixelTileHeightSGIX = unchecked((uint)0x8141),
    PixelTileGridWidthSGIX = unchecked((uint)0x8142),
    PixelTileGridHeightSGIX = unchecked((uint)0x8143),
    PixelTileGridDepthSGIX = unchecked((uint)0x8144),
    PixelTileCacheSizeSGIX = unchecked((uint)0x8145),
    PackResampleSGIX = unchecked((uint)0x842E),
    UnpackResampleSGIX = unchecked((uint)0x842F),
    PackSubsampleRateSGIX = unchecked((uint)0x85A0),
    UnpackSubsampleRateSGIX = unchecked((uint)0x85A1),
    UnpackRowLengthEXT = unchecked((uint)0x0CF2),
    UnpackSkipRowsEXT = unchecked((uint)0x0CF3),
    UnpackSkipPixelsEXT = unchecked((uint)0x0CF4),
    PackRowLengthNV = unchecked((uint)0x0D02),
    PackSkipRowsNV = unchecked((uint)0x0D03),
    PackSkipPixelsNV = unchecked((uint)0x0D04),
}
