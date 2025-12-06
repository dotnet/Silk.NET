// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureParameterName")]
public enum TextureParameterName : uint
{
    [NativeName("GL_TEXTURE_WIDTH")]
    TextureWidth = 4096,

    [NativeName("GL_TEXTURE_HEIGHT")]
    TextureHeight = 4097,

    [NativeName("GL_TEXTURE_BORDER_COLOR")]
    TextureBorderColor = 4100,

    [NativeName("GL_TEXTURE_MAG_FILTER")]
    TextureMagFilter = 10240,

    [NativeName("GL_TEXTURE_MIN_FILTER")]
    TextureMinFilter = 10241,

    [NativeName("GL_TEXTURE_WRAP_S")]
    TextureWrapS = 10242,

    [NativeName("GL_TEXTURE_WRAP_T")]
    TextureWrapT = 10243,

    [NativeName("GL_TEXTURE_COMPONENTS")]
    TextureComponents = 4099,

    [NativeName("GL_TEXTURE_BORDER")]
    TextureBorder = 4101,

    [NativeName("GL_TEXTURE_INTERNAL_FORMAT")]
    TextureInternalFormat = 4099,

    [NativeName("GL_TEXTURE_RED_SIZE")]
    TextureRedSize = 32860,

    [NativeName("GL_TEXTURE_GREEN_SIZE")]
    TextureGreenSize = 32861,

    [NativeName("GL_TEXTURE_BLUE_SIZE")]
    TextureBlueSize = 32862,

    [NativeName("GL_TEXTURE_ALPHA_SIZE")]
    TextureAlphaSize = 32863,

    [NativeName("GL_TEXTURE_LUMINANCE_SIZE")]
    TextureLuminanceSize = 32864,

    [NativeName("GL_TEXTURE_INTENSITY_SIZE")]
    TextureIntensitySize = 32865,

    [NativeName("GL_TEXTURE_PRIORITY")]
    TexturePriority = 32870,

    [NativeName("GL_TEXTURE_RESIDENT")]
    TextureResident = 32871,

    [NativeName("GL_TEXTURE_WRAP_R")]
    TextureWrapR = 32882,

    [NativeName("GL_TEXTURE_MIN_LOD")]
    TextureMinLod = 33082,

    [NativeName("GL_TEXTURE_MAX_LOD")]
    TextureMaxLod = 33083,

    [NativeName("GL_TEXTURE_BASE_LEVEL")]
    TextureBaseLevel = 33084,

    [NativeName("GL_TEXTURE_MAX_LEVEL")]
    TextureMaxLevel = 33085,

    [NativeName("GL_TEXTURE_LOD_BIAS")]
    TextureLodBias = 34049,

    [NativeName("GL_TEXTURE_COMPARE_MODE")]
    TextureCompareMode = 34892,

    [NativeName("GL_TEXTURE_COMPARE_FUNC")]
    TextureCompareFunc = 34893,

    [NativeName("GL_GENERATE_MIPMAP")]
    GenerateMipmap = 33169,

    [NativeName("GL_TEXTURE_SWIZZLE_R")]
    TextureSwizzleR = 36418,

    [NativeName("GL_TEXTURE_SWIZZLE_G")]
    TextureSwizzleG = 36419,

    [NativeName("GL_TEXTURE_SWIZZLE_B")]
    TextureSwizzleB = 36420,

    [NativeName("GL_TEXTURE_SWIZZLE_A")]
    TextureSwizzleA = 36421,

    [NativeName("GL_TEXTURE_SWIZZLE_RGBA")]
    TextureSwizzleRgba = 36422,

    [NativeName("GL_DEPTH_STENCIL_TEXTURE_MODE")]
    DepthStencilTextureMode = 37098,

    [NativeName("GL_TEXTURE_MAX_ANISOTROPY")]
    TextureMaxAnisotropy = 34046,

    [NativeName("GL_TEXTURE_TILING_EXT")]
    TextureTilingEXT = 38272,

    [NativeName("GL_TEXTURE_DEPTH_EXT")]
    TextureDepthEXT = 32881,

    [NativeName("GL_TEXTURE_WRAP_R_EXT")]
    TextureWrapREXT = 32882,

    [NativeName("GL_TEXTURE_PRIORITY_EXT")]
    TexturePriorityEXT = 32870,

    [NativeName("GL_TEXTURE_MEMORY_LAYOUT_INTEL")]
    TextureMemoryLayoutINTEL = 33791,

    [NativeName("GL_DETAIL_TEXTURE_LEVEL_SGIS")]
    DetailTextureLevelSGIS = 32922,

    [NativeName("GL_DETAIL_TEXTURE_MODE_SGIS")]
    DetailTextureModeSGIS = 32923,

    [NativeName("GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS")]
    DetailTextureFuncPointsSGIS = 32924,

    [NativeName("GL_GENERATE_MIPMAP_SGIS")]
    GenerateMipmapSGIS = 33169,

    [NativeName("GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS")]
    SharpenTextureFuncPointsSGIS = 32944,

    [NativeName("GL_TEXTURE_4DSIZE_SGIS")]
    Texture4DsizeSGIS = 33078,

    [NativeName("GL_TEXTURE_WRAP_Q_SGIS")]
    TextureWrapQSGIS = 33079,

    [NativeName("GL_TEXTURE_FILTER4_SIZE_SGIS")]
    TextureFilter4SizeSGIS = 33095,

    [NativeName("GL_TEXTURE_MIN_LOD_SGIS")]
    TextureMinLodSGIS = 33082,

    [NativeName("GL_TEXTURE_MAX_LOD_SGIS")]
    TextureMaxLodSGIS = 33083,

    [NativeName("GL_TEXTURE_BASE_LEVEL_SGIS")]
    TextureBaseLevelSGIS = 33084,

    [NativeName("GL_TEXTURE_MAX_LEVEL_SGIS")]
    TextureMaxLevelSGIS = 33085,

    [NativeName("GL_DUAL_TEXTURE_SELECT_SGIS")]
    DualTextureSelectSGIS = 33060,

    [NativeName("GL_QUAD_TEXTURE_SELECT_SGIS")]
    QuadTextureSelectSGIS = 33061,

    [NativeName("GL_TEXTURE_CLIPMAP_CENTER_SGIX")]
    TextureClipmapCenterSGIX = 33137,

    [NativeName("GL_TEXTURE_CLIPMAP_FRAME_SGIX")]
    TextureClipmapFrameSGIX = 33138,

    [NativeName("GL_TEXTURE_CLIPMAP_OFFSET_SGIX")]
    TextureClipmapOffsetSGIX = 33139,

    [NativeName("GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    TextureClipmapVirtualDepthSGIX = 33140,

    [NativeName("GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX")]
    TextureClipmapLodOffsetSGIX = 33141,

    [NativeName("GL_TEXTURE_CLIPMAP_DEPTH_SGIX")]
    TextureClipmapDepthSGIX = 33142,

    [NativeName("GL_TEXTURE_COMPARE_SGIX")]
    TextureCompareSGIX = 33178,

    [NativeName("GL_TEXTURE_COMPARE_OPERATOR_SGIX")]
    TextureCompareOperatorSGIX = 33179,

    [NativeName("GL_TEXTURE_LEQUAL_R_SGIX")]
    TextureLequalRSGIX = 33180,

    [NativeName("GL_TEXTURE_GEQUAL_R_SGIX")]
    TextureGequalRSGIX = 33181,

    [NativeName("GL_SHADOW_AMBIENT_SGIX")]
    ShadowAmbientSGIX = 32959,

    [NativeName("GL_TEXTURE_MAX_CLAMP_S_SGIX")]
    TextureMaxClampSSGIX = 33641,

    [NativeName("GL_TEXTURE_MAX_CLAMP_T_SGIX")]
    TextureMaxClampTSGIX = 33642,

    [NativeName("GL_TEXTURE_MAX_CLAMP_R_SGIX")]
    TextureMaxClampRSGIX = 33643,

    [NativeName("GL_TEXTURE_LOD_BIAS_S_SGIX")]
    TextureLodBiasSSGIX = 33166,

    [NativeName("GL_TEXTURE_LOD_BIAS_T_SGIX")]
    TextureLodBiasTSGIX = 33167,

    [NativeName("GL_TEXTURE_LOD_BIAS_R_SGIX")]
    TextureLodBiasRSGIX = 33168,

    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_SGIX")]
    PostTextureFilterBiasSGIX = 33145,

    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_SGIX")]
    PostTextureFilterScaleSGIX = 33146,

    [NativeName("GL_TEXTURE_WRAP_R_OES")]
    TextureWrapROES = 32882,

    [NativeName("GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    TextureUnnormalizedCoordinatesARM = 36714,

    [NativeName("GL_TEXTURE_BORDER_COLOR_NV")]
    TextureBorderColorNV = 4100,

    [NativeName("GL_TEXTURE_FOVEATED_CUTOFF_DENSITY_QCOM")]
    TextureFoveatedCutoffDensityQCOM = 38560,
}
