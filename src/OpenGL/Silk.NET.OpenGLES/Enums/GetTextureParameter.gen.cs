// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GetTextureParameter")]
    public enum GetTextureParameter : int
    {
        [NativeName("Name", "GL_TEXTURE_WIDTH")]
        TextureWidth = 0x1000,
        [NativeName("Name", "GL_TEXTURE_HEIGHT")]
        TextureHeight = 0x1001,
        [NativeName("Name", "GL_TEXTURE_INTERNAL_FORMAT")]
        TextureInternalFormat = 0x1003,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_COMPONENTS")]
        TextureComponents = 0x1003,
        [NativeName("Name", "GL_TEXTURE_BORDER_COLOR")]
        TextureBorderColor = 0x1004,
        [NativeName("Name", "GL_TEXTURE_BORDER_COLOR_NV")]
        TextureBorderColorNV = 0x1004,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_BORDER")]
        TextureBorder = 0x1005,
        [NativeName("Name", "GL_TEXTURE_MAG_FILTER")]
        TextureMagFilter = 0x2800,
        [NativeName("Name", "GL_TEXTURE_MIN_FILTER")]
        TextureMinFilter = 0x2801,
        [NativeName("Name", "GL_TEXTURE_WRAP_S")]
        TextureWrapS = 0x2802,
        [NativeName("Name", "GL_TEXTURE_WRAP_T")]
        TextureWrapT = 0x2803,
        [NativeName("Name", "GL_TEXTURE_RED_SIZE")]
        TextureRedSize = 0x805C,
        [NativeName("Name", "GL_TEXTURE_GREEN_SIZE")]
        TextureGreenSize = 0x805D,
        [NativeName("Name", "GL_TEXTURE_BLUE_SIZE")]
        TextureBlueSize = 0x805E,
        [NativeName("Name", "GL_TEXTURE_ALPHA_SIZE")]
        TextureAlphaSize = 0x805F,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_LUMINANCE_SIZE")]
        TextureLuminanceSize = 0x8060,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_INTENSITY_SIZE")]
        TextureIntensitySize = 0x8061,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_PRIORITY")]
        TexturePriority = 0x8066,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_RESIDENT")]
        TextureResident = 0x8067,
        [NativeName("Name", "GL_TEXTURE_DEPTH_EXT")]
        TextureDepthExt = 0x8071,
        [NativeName("Name", "GL_TEXTURE_WRAP_R_EXT")]
        TextureWrapRExt = 0x8072,
        [NativeName("Name", "GL_DETAIL_TEXTURE_LEVEL_SGIS")]
        DetailTextureLevelSgis = 0x809A,
        [NativeName("Name", "GL_DETAIL_TEXTURE_MODE_SGIS")]
        DetailTextureModeSgis = 0x809B,
        [NativeName("Name", "GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS")]
        DetailTextureFuncPointsSgis = 0x809C,
        [NativeName("Name", "GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS")]
        SharpenTextureFuncPointsSgis = 0x80B0,
        [NativeName("Name", "GL_SHADOW_AMBIENT_SGIX")]
        ShadowAmbientSgix = 0x80BF,
        [NativeName("Name", "GL_DUAL_TEXTURE_SELECT_SGIS")]
        DualTextureSelectSgis = 0x8124,
        [NativeName("Name", "GL_QUAD_TEXTURE_SELECT_SGIS")]
        QuadTextureSelectSgis = 0x8125,
        [NativeName("Name", "GL_TEXTURE_4DSIZE_SGIS")]
        Texture4DsizeSgis = 0x8136,
        [NativeName("Name", "GL_TEXTURE_WRAP_Q_SGIS")]
        TextureWrapQSgis = 0x8137,
        [NativeName("Name", "GL_TEXTURE_MIN_LOD_SGIS")]
        TextureMinLodSgis = 0x813A,
        [NativeName("Name", "GL_TEXTURE_MAX_LOD_SGIS")]
        TextureMaxLodSgis = 0x813B,
        [NativeName("Name", "GL_TEXTURE_BASE_LEVEL_SGIS")]
        TextureBaseLevelSgis = 0x813C,
        [NativeName("Name", "GL_TEXTURE_MAX_LEVEL_SGIS")]
        TextureMaxLevelSgis = 0x813D,
        [NativeName("Name", "GL_TEXTURE_FILTER4_SIZE_SGIS")]
        TextureFilter4SizeSgis = 0x8147,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_CENTER_SGIX")]
        TextureClipmapCenterSgix = 0x8171,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_FRAME_SGIX")]
        TextureClipmapFrameSgix = 0x8172,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_OFFSET_SGIX")]
        TextureClipmapOffsetSgix = 0x8173,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
        TextureClipmapVirtualDepthSgix = 0x8174,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX")]
        TextureClipmapLodOffsetSgix = 0x8175,
        [NativeName("Name", "GL_TEXTURE_CLIPMAP_DEPTH_SGIX")]
        TextureClipmapDepthSgix = 0x8176,
        [NativeName("Name", "GL_POST_TEXTURE_FILTER_BIAS_SGIX")]
        PostTextureFilterBiasSgix = 0x8179,
        [NativeName("Name", "GL_POST_TEXTURE_FILTER_SCALE_SGIX")]
        PostTextureFilterScaleSgix = 0x817A,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS_S_SGIX")]
        TextureLodBiasSSgix = 0x818E,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS_T_SGIX")]
        TextureLodBiasTSgix = 0x818F,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS_R_SGIX")]
        TextureLodBiasRSgix = 0x8190,
        [NativeName("Name", "GL_GENERATE_MIPMAP_SGIS")]
        GenerateMipmapSgis = 0x8191,
        [NativeName("Name", "GL_TEXTURE_COMPARE_SGIX")]
        TextureCompareSgix = 0x819A,
        [NativeName("Name", "GL_TEXTURE_COMPARE_OPERATOR_SGIX")]
        TextureCompareOperatorSgix = 0x819B,
        [NativeName("Name", "GL_TEXTURE_LEQUAL_R_SGIX")]
        TextureLequalRSgix = 0x819C,
        [NativeName("Name", "GL_TEXTURE_GEQUAL_R_SGIX")]
        TextureGequalRSgix = 0x819D,
        [NativeName("Name", "GL_TEXTURE_MAX_CLAMP_S_SGIX")]
        TextureMaxClampSSgix = 0x8369,
        [NativeName("Name", "GL_TEXTURE_MAX_CLAMP_T_SGIX")]
        TextureMaxClampTSgix = 0x836A,
        [NativeName("Name", "GL_TEXTURE_MAX_CLAMP_R_SGIX")]
        TextureMaxClampRSgix = 0x836B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_NORMAL_MAP")]
        NormalMap = 0x8511,
        [NativeName("Name", "GL_NORMAL_MAP_ARB")]
        NormalMapArb = 0x8511,
        [NativeName("Name", "GL_NORMAL_MAP_EXT")]
        NormalMapExt = 0x8511,
        [NativeName("Name", "GL_NORMAL_MAP_NV")]
        NormalMapNV = 0x8511,
        [NativeName("Name", "GL_NORMAL_MAP_OES")]
        NormalMapOes = 0x8511,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_REFLECTION_MAP")]
        ReflectionMap = 0x8512,
        [NativeName("Name", "GL_REFLECTION_MAP_ARB")]
        ReflectionMapArb = 0x8512,
        [NativeName("Name", "GL_REFLECTION_MAP_EXT")]
        ReflectionMapExt = 0x8512,
        [NativeName("Name", "GL_REFLECTION_MAP_NV")]
        ReflectionMapNV = 0x8512,
        [NativeName("Name", "GL_REFLECTION_MAP_OES")]
        ReflectionMapOes = 0x8512,
        [NativeName("Name", "GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
        TextureUnnormalizedCoordinatesArm = 0x8F6A,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_EXT")]
        SurfaceCompressionExt = 0x96C0,
        [NativeName("Name", "GL_TEXTURE_Y_DEGAMMA_QCOM")]
        TextureYDegammaQCom = 0x9710,
        [NativeName("Name", "GL_TEXTURE_CBCR_DEGAMMA_QCOM")]
        TextureCbcrDegammaQCom = 0x9711,
    }
}
