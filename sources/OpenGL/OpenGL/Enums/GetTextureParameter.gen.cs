// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("GetTextureParameter")]
[Transformed]
public enum GetTextureParameter : uint
{
    [NativeName("GL_TEXTURE_MAG_FILTER")]
    TextureMagFilter = unchecked((uint)0x2800),

    [NativeName("GL_TEXTURE_MIN_FILTER")]
    TextureMinFilter = unchecked((uint)0x2801),

    [NativeName("GL_TEXTURE_WRAP_S")]
    TextureWrapS = unchecked((uint)0x2802),

    [NativeName("GL_TEXTURE_WRAP")]
    [NameAffix("Suffix", "_T", -1)]
    TextureWrap = unchecked((uint)0x2803),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_NORMAL_MAP_OES")]
    NormalMapOES = unchecked((uint)0x8511),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_REFLECTION_MAP_OES")]
    ReflectionMapOES = unchecked((uint)0x8512),

    [NativeName("GL_TEXTURE_WIDTH")]
    TextureWidth = unchecked((uint)0x1000),

    [NativeName("GL_TEXTURE_HEIGHT")]
    TextureHeight = unchecked((uint)0x1001),

    [NativeName("GL_TEXTURE_BORDER_COLOR")]
    TextureBorderColor = unchecked((uint)0x1004),

    [NativeName("GL_TEXTURE_COMPONENTS")]
    TextureComponents = unchecked((uint)0x1003),

    [NativeName("GL_TEXTURE_BORDER")]
    TextureBorder = unchecked((uint)0x1005),

    [NativeName("GL_TEXTURE_INTERNAL_FORMAT")]
    TextureInternalFormat = unchecked((uint)0x1003),

    [NativeName("GL_TEXTURE_RED_SIZE")]
    TextureRedSize = unchecked((uint)0x805C),

    [NativeName("GL_TEXTURE_GREEN_SIZE")]
    TextureGreenSize = unchecked((uint)0x805D),

    [NativeName("GL_TEXTURE_BLUE_SIZE")]
    TextureBlueSize = unchecked((uint)0x805E),

    [NativeName("GL_TEXTURE_ALPHA_SIZE")]
    TextureAlphaSize = unchecked((uint)0x805F),

    [NativeName("GL_TEXTURE_LUMINANCE_SIZE")]
    TextureLuminanceSize = unchecked((uint)0x8060),

    [NativeName("GL_TEXTURE_INTENSITY_SIZE")]
    TextureIntensitySize = unchecked((uint)0x8061),

    [NativeName("GL_TEXTURE_PRIORITY")]
    TexturePriority = unchecked((uint)0x8066),

    [NativeName("GL_TEXTURE_RESIDENT")]
    TextureResident = unchecked((uint)0x8067),

    [NativeName("GL_NORMAL_MAP")]
    NormalMap = unchecked((uint)0x8511),

    [NativeName("GL_REFLECTION_MAP")]
    ReflectionMap = unchecked((uint)0x8512),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_NORMAL_MAP_ARB")]
    NormalMapARB = unchecked((uint)0x8511),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_REFLECTION_MAP_ARB")]
    ReflectionMapARB = unchecked((uint)0x8512),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_DEPTH_EXT")]
    TextureDepthEXT = unchecked((uint)0x8071),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_WRAP_R_EXT")]
    TextureWrapREXT = unchecked((uint)0x8072),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_NORMAL_MAP_EXT")]
    NormalMapEXT = unchecked((uint)0x8511),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_REFLECTION_MAP_EXT")]
    ReflectionMapEXT = unchecked((uint)0x8512),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_NORMAL_MAP_NV")]
    NormalMapNV = unchecked((uint)0x8511),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_REFLECTION_MAP_NV")]
    ReflectionMapNV = unchecked((uint)0x8512),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DETAIL_TEXTURE_LEVEL_SGIS")]
    DetailTextureLevelSGIS = unchecked((uint)0x809A),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DETAIL_TEXTURE_MODE_SGIS")]
    DetailTextureModeSGIS = unchecked((uint)0x809B),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS")]
    DetailTextureFuncPointsSGIS = unchecked((uint)0x809C),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_GENERATE_MIPMAP_SGIS")]
    GenerateMipmapSGIS = unchecked((uint)0x8191),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS")]
    SharpenTextureFuncPointsSGIS = unchecked((uint)0x80B0),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_4DSIZE_SGIS")]
    Texture4DsizeSGIS = unchecked((uint)0x8136),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_WRAP_Q_SGIS")]
    TextureWrapQSGIS = unchecked((uint)0x8137),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_FILTER4_SIZE_SGIS")]
    TextureFilter4SizeSGIS = unchecked((uint)0x8147),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_MIN_LOD_SGIS")]
    TextureMinLodSGIS = unchecked((uint)0x813A),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_MAX_LOD_SGIS")]
    TextureMaxLodSGIS = unchecked((uint)0x813B),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_BASE_LEVEL_SGIS")]
    TextureBaseLevelSGIS = unchecked((uint)0x813C),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_TEXTURE_MAX_LEVEL_SGIS")]
    TextureMaxLevelSGIS = unchecked((uint)0x813D),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_DUAL_TEXTURE_SELECT_SGIS")]
    DualTextureSelectSGIS = unchecked((uint)0x8124),

    [NameAffix("Suffix", "SGIS", 0)]
    [NativeName("GL_QUAD_TEXTURE_SELECT_SGIS")]
    QuadTextureSelectSGIS = unchecked((uint)0x8125),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_CENTER_SGIX")]
    TextureClipmapCenterSGIX = unchecked((uint)0x8171),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_FRAME_SGIX")]
    TextureClipmapFrameSGIX = unchecked((uint)0x8172),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_OFFSET_SGIX")]
    TextureClipmapOffsetSGIX = unchecked((uint)0x8173),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX")]
    TextureClipmapVirtualDepthSGIX = unchecked((uint)0x8174),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX")]
    TextureClipmapLodOffsetSGIX = unchecked((uint)0x8175),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_CLIPMAP_DEPTH_SGIX")]
    TextureClipmapDepthSGIX = unchecked((uint)0x8176),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_COMPARE_SGIX")]
    TextureCompareSGIX = unchecked((uint)0x819A),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_COMPARE_OPERATOR_SGIX")]
    TextureCompareOperatorSGIX = unchecked((uint)0x819B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_LEQUAL_R_SGIX")]
    TextureLequalRSGIX = unchecked((uint)0x819C),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_GEQUAL_R_SGIX")]
    TextureGequalRSGIX = unchecked((uint)0x819D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_SHADOW_AMBIENT_SGIX")]
    ShadowAmbientSGIX = unchecked((uint)0x80BF),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_MAX_CLAMP_S_SGIX")]
    TextureMaxClampSSGIX = unchecked((uint)0x8369),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_MAX_CLAMP_T_SGIX")]
    TextureMaxClampTSGIX = unchecked((uint)0x836A),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_MAX_CLAMP_R_SGIX")]
    TextureMaxClampRSGIX = unchecked((uint)0x836B),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_LOD_BIAS_S_SGIX")]
    TextureLodBiasSSGIX = unchecked((uint)0x818E),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_LOD_BIAS_T_SGIX")]
    TextureLodBiasTSGIX = unchecked((uint)0x818F),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_TEXTURE_LOD_BIAS_R_SGIX")]
    TextureLodBiasRSGIX = unchecked((uint)0x8190),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_POST_TEXTURE_FILTER_BIAS_SGIX")]
    PostTextureFilterBiasSGIX = unchecked((uint)0x8179),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_POST_TEXTURE_FILTER_SCALE_SGIX")]
    PostTextureFilterScaleSGIX = unchecked((uint)0x817A),

    [NameAffix("Suffix", "ARM", 0)]
    [NativeName("GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    TextureUnnormalizedCoordinatesARM = unchecked((uint)0x8F6A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_EXT")]
    SurfaceCompressionEXT = unchecked((uint)0x96C0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_TEXTURE_BORDER_COLOR_NV")]
    TextureBorderColorNV = unchecked((uint)0x1004),
}
