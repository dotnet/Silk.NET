// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL.Legacy
{
    public enum GetTextureParameter
    {
        TextureWidth = 0x1000,
        TextureHeight = 0x1001,
        TextureInternalFormat = 0x1003,
        TextureComponents = 0x1003,
        TextureBorderColor = 0x1004,
        TextureBorderColorNV = 0x1004,
        TextureBorder = 0x1005,
        TextureMagFilter = 0x2800,
        TextureMinFilter = 0x2801,
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
        TextureRedSize = 0x805C,
        TextureGreenSize = 0x805D,
        TextureBlueSize = 0x805E,
        TextureAlphaSize = 0x805F,
        TextureLuminanceSize = 0x8060,
        TextureIntensitySize = 0x8061,
        TexturePriority = 0x8066,
        TextureResident = 0x8067,
        TextureDepthExt = 0x8071,
        TextureWrapRExt = 0x8072,
        DetailTextureLevelSgis = 0x809A,
        DetailTextureModeSgis = 0x809B,
        DetailTextureFuncPointsSgis = 0x809C,
        SharpenTextureFuncPointsSgis = 0x80B0,
        ShadowAmbientSgix = 0x80BF,
        DualTextureSelectSgis = 0x8124,
        QuadTextureSelectSgis = 0x8125,
        Texture4DsizeSgis = 0x8136,
        TextureWrapQSgis = 0x8137,
        TextureMinLodSgis = 0x813A,
        TextureMaxLodSgis = 0x813B,
        TextureBaseLevelSgis = 0x813C,
        TextureMaxLevelSgis = 0x813D,
        TextureFilter4SizeSgis = 0x8147,
        TextureClipmapCenterSgix = 0x8171,
        TextureClipmapFrameSgix = 0x8172,
        TextureClipmapOffsetSgix = 0x8173,
        TextureClipmapVirtualDepthSgix = 0x8174,
        TextureClipmapLodOffsetSgix = 0x8175,
        TextureClipmapDepthSgix = 0x8176,
        PostTextureFilterBiasSgix = 0x8179,
        PostTextureFilterScaleSgix = 0x817A,
        TextureLodBiasSSgix = 0x818E,
        TextureLodBiasTSgix = 0x818F,
        TextureLodBiasRSgix = 0x8190,
        GenerateMipmapSgis = 0x8191,
        TextureCompareSgix = 0x819A,
        TextureCompareOperatorSgix = 0x819B,
        TextureLequalRSgix = 0x819C,
        TextureGequalRSgix = 0x819D,
        TextureMaxClampSSgix = 0x8369,
        TextureMaxClampTSgix = 0x836A,
        TextureMaxClampRSgix = 0x836B,
    }
}
