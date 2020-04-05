// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL.Legacy
{
    public enum PixelStoreParameter
    {
        UnpackSwapBytes = 0xCF0,
        UnpackLsbFirst = 0xCF1,
        UnpackRowLength = 0xCF2,
        UnpackRowLengthExt = 0xCF2,
        UnpackSkipRows = 0xCF3,
        UnpackSkipRowsExt = 0xCF3,
        UnpackSkipPixels = 0xCF4,
        UnpackSkipPixelsExt = 0xCF4,
        UnpackAlignment = 0xCF5,
        PackSwapBytes = 0xD00,
        PackLsbFirst = 0xD01,
        PackRowLength = 0xD02,
        PackSkipRows = 0xD03,
        PackSkipPixels = 0xD04,
        PackAlignment = 0xD05,
        PackSkipImages = 0x806B,
        PackSkipImagesExt = 0x806B,
        PackImageHeight = 0x806C,
        PackImageHeightExt = 0x806C,
        UnpackSkipImages = 0x806D,
        UnpackSkipImagesExt = 0x806D,
        UnpackImageHeight = 0x806E,
        UnpackImageHeightExt = 0x806E,
        PackSkipVolumesSgis = 0x8130,
        PackImageDepthSgis = 0x8131,
        UnpackSkipVolumesSgis = 0x8132,
        UnpackImageDepthSgis = 0x8133,
        PixelTileWidthSgix = 0x8140,
        PixelTileHeightSgix = 0x8141,
        PixelTileGridWidthSgix = 0x8142,
        PixelTileGridHeightSgix = 0x8143,
        PixelTileGridDepthSgix = 0x8144,
        PixelTileCacheSizeSgix = 0x8145,
        PackResampleSgix = 0x842E,
        UnpackResampleSgix = 0x842F,
        PackSubsampleRateSgix = 0x85A0,
        UnpackSubsampleRateSgix = 0x85A1,
        PackResampleOml = 0x8984,
        UnpackResampleOml = 0x8985,
    }
}
